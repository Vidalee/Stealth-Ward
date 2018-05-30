using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Stealth_Ward
{
    static class Program
    {
        public static Thread controller;
        internal static MainForm mainForm;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            controller = new Thread(lcuCheck);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            Application.Run(mainForm); 
        }

        private static void lcuCheck()
        {
            if (null == System.Windows.Application.Current)
            {
                new System.Windows.Application();
            }
            Console.WriteLine("Controller launched");
            var lcuPath = LeagueMonitor.GetLCUPath();
            if (lcuPath == null)
            {
                MessageBox.Show("Could not determine path to LCU!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Abort
            }
            Console.WriteLine(lcuPath);
            LeagueMonitor leagueMonitor = new LeagueMonitor(lcuPath, onLeagueStart, onLeagueStop);
        }

        private static void onLeagueStart(string lockfileContents)
        {
            Console.WriteLine("League Started.");
            mainForm.Invoke(new Action(() => { mainForm.addCall("League started."); }));
            var parts = lockfileContents.Split(':');
            var port = int.Parse(parts[2]);
            LeagueSocketBehavior ls = new LeagueSocketBehavior(port, parts[3]);
            ls.makeRequest("/");
        }

        private static void onLeagueStop()
        {
            Console.WriteLine("League Stopped.");
            mainForm.Invoke(new Action(() => { mainForm.addCall("League stopped."); }));
        }
    }
}
