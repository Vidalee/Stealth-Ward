using System;
using System.Collections.Generic;
using System.Windows.Threading;

namespace Stealth_Ward
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private List<String> endpoints = new List<String>();
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
            if (observeAllToggle.Checked)
            {
                loggingTextBox.AppendText(str);
                loggingTextBox.AppendText(Environment.NewLine);
            }
            else
            {
                String[] splitted = str.Split('/');
                if (splitted.Length <= 1)
                    return;

                Console.WriteLine(str.Split('/')[1]);
                if (endpoints.Contains(str.Split('/')[1]))
                {
                    loggingTextBox.AppendText(str);
                    loggingTextBox.AppendText(Environment.NewLine);
                }
            }
        }

        private void loggingTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void observeButton_Click(object sender, EventArgs e)
        {
            if (endpointComboBox.SelectedItem == null)
                return;
            observeAllToggle.Checked = false;
            String endpoint = (String) endpointComboBox.SelectedItem;
            switch (endpoint)
            {
                case "builtin":
                    endpoints.Add("async");
                    endpoints.Add("v1");
                    endpoints.Add("v2");
                    endpoints.Add("v3");
                    break;
                case "cookie-jar":
                    endpoints.Add("cookie-jar");
                    break;
                case "data-store":
                    endpoints.Add("data-store");
                    break;
                case "Plugin Manager":
                    endpoints.Add("plugin-manager");
                    break;
                case "Plugin Patcher":
                    endpoints.Add("patcher");
                    break;
                case "performance":
                    endpoints.Add("performance");
                    break;
                case "riotclient":
                    endpoints.Add("riotclient");
                    break;
                case "system":
                    endpoints.Add("system");
                    break;
                case "telemetry":
                    endpoints.Add("telemetry");
                    break;
            }

            if (endpoint.StartsWith("Plugin"))
            {
                String[] splitted = endpoint.Split(' ');
                if(splitted[1] == splitted[1].ToLower())
                {
                    endpoints.Add(splitted[1]);
                }
            }
        }

        private void stopObervingButton_Click(object sender, EventArgs e)
        {
            if (endpointComboBox.SelectedItem == null)
                return;
            String endpoint = (String)endpointComboBox.SelectedItem;
            switch (endpoint)
            {
                case "builtin":
                    endpoints.Remove("async");
                    endpoints.Remove("v1");
                    endpoints.Remove("v2");
                    endpoints.Remove("v3");
                    break;
                case "cookie-jar":
                    endpoints.Remove("cookie-jar");
                    break;
                case "data-store":
                    endpoints.Remove("data-store");
                    break;
                case "Plugin Manager":
                    endpoints.Remove("plugin-manager");
                    break;
                case "Plugin Patcher":
                    endpoints.Remove("patcher");
                    break;
                case "performance":
                    endpoints.Remove("performance");
                    break;
                case "riotclient":
                    endpoints.Remove("riotclient");
                    break;
                case "system":
                    endpoints.Remove("system");
                    break;
                case "telemetry":
                    endpoints.Remove("telemetry");
                    break;
            }

            if (endpoint.StartsWith("Plugin"))
            {
                String[] splitted = endpoint.Split(' ');
                if (splitted[1] == splitted[1].ToLower())
                {
                    endpoints.Remove(splitted[1]);
                }
            }
        }
    }
}


