using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Stealth_Ward
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public Dispatcher dispatcher;
        public MainForm()
        {
            dispatcher = Dispatcher.CurrentDispatcher;
            InitializeComponent();
            if (null == System.Windows.Application.Current)
            {
                new System.Windows.Application();
            }
            Program.controller.Start();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        internal void addCall(String str)
        {
            loggingTextBox.AppendText(str);
            loggingTextBox.AppendText(Environment.NewLine);
        }

        private void loggingTextBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}


