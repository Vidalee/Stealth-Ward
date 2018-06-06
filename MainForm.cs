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
            String toAdd = null;
            observeAllToggle.Checked = false;
            String endpoint = (String) endpointComboBox.SelectedItem;
            switch (endpoint)
            {
                case "builtin":
                    toAdd = "async";
                    toAdd = "v1";
                    toAdd = "v2";
                    toAdd = "v3";
                    break;
                case "cookie-jar":
                    toAdd = "cookie-jar";
                    break;
                case "data-store":
                    toAdd = "data-store";
                    break;
                case "Plugin Manager":
                    toAdd = "plugin-manager";
                    break;
                case "Plugin Patcher":
                    toAdd = "patcher";
                    break;
                case "performance":
                    toAdd = "performance";
                    break;
                case "riotclient":
                    toAdd = "riotclient";
                    break;
                case "system":
                    toAdd = "system";
                    break;
                case "telemetry":
                    toAdd = "telemetry";
                    break;
            }

            if (endpoint.StartsWith("Plugin"))
            {
                String[] splitted = endpoint.Split(' ');
                if(splitted[1] == splitted[1].ToLower())
                {
                    toAdd = splitted[1];
                }
            }
            if (toAdd != null)
            {
                endpoints.Add(toAdd);
                refreshObservedTextBox();
            }
        }

        private void stopObervingButton_Click(object sender, EventArgs e)
        {
            if (endpointComboBox.SelectedItem == null)
                return;
            String toRemove = null;
            String endpoint = (String)endpointComboBox.SelectedItem;
            switch (endpoint)
            {
                case "builtin":
                    toRemove = "async";
                    toRemove = "v1";
                    toRemove = "v2";
                    toRemove = "v3";
                    break;
                case "cookie-jar":
                    toRemove = "cookie-jar";
                    break;
                case "data-store":
                    toRemove = "data-store";
                    break;
                case "Plugin Manager":
                    toRemove = "plugin-manager";
                    break;
                case "Plugin Patcher":
                    toRemove = "patcher";
                    break;
                case "performance":
                    toRemove = "performance";
                    break;
                case "riotclient":
                    toRemove = "riotclient";
                    break;
                case "system":
                    toRemove = "system";
                    break;
                case "telemetry":
                    toRemove = "telemetry";
                    break;
            }

            if (endpoint.StartsWith("Plugin"))
            {
                String[] splitted = endpoint.Split(' ');
                if (splitted[1] == splitted[1].ToLower())
                {
                    toRemove = splitted[1];
                }
            }

            if (toRemove != null)
            {
                endpoints.Remove(toRemove);
                refreshObservedTextBox();
            }
        }

        private void refreshObservedTextBox()
        {
            observedTextBox.Clear();
            foreach (var endpoint in endpoints)
            {
                observedTextBox.AppendText(endpoint);
                observedTextBox.AppendText(Environment.NewLine);
            }
        }
    }
}


