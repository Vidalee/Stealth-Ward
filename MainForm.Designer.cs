namespace Stealth_Ward
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.loggingTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            "builtin",
            "cookie-jar",
            "core",
            "data-store",
            "default",
            "logging",
            "performance",
            "Plugin Asset Serving ",
            "Plugin entitlements ",
            "Plugin lol-account-verification ",
            "Plugin lol-acs ",
            "Plugin lol-active-boosts ",
            "Plugin lol-banners ",
            "Plugin lol-beta-opt-in ",
            "Plugin lol-champ-select ",
            "Plugin lol-champ-select-legacy ",
            "Plugin lol-champions ",
            "Plugin lol-chat ",
            "Plugin lol-clash ",
            "Plugin lol-clubs ",
            "Plugin lol-clubs-public ",
            "Plugin lol-collections ",
            "Plugin lol-content-targeting ",
            "Plugin lol-email-verification ",
            "Plugin lol-end-of-game ",
            "Plugin lol-esport-stream-notifications ",
            "Plugin lol-game-client-chat ",
            "Plugin lol-game-queues ",
            "Plugin lol-game-settings ",
            "Plugin lol-gameflow ",
            "Plugin lol-geoinfo ",
            "Plugin lol-highlights ",
            "Plugin lol-honor-v2 ",
            "Plugin lol-inventory ",
            "Plugin lol-item-sets ",
            "Plugin lol-kickout ",
            "Plugin lol-kr-playtime-reminder ",
            "Plugin lol-kr-shutdown-law ",
            "Plugin lol-las-toxicity ",
            "Plugin lol-leagues ",
            "Plugin lol-leaver-buster ",
            "Plugin lol-license-agreement ",
            "Plugin lol-loadouts ",
            "Plugin lol-lobby ",
            "Plugin lol-lobby-team-builder ",
            "Plugin lol-login ",
            "Plugin lol-loot ",
            "Plugin lol-loyalty ",
            "Plugin lol-maps ",
            "Plugin lol-match-history ",
            "Plugin lol-matchmaking ",
            "Plugin lol-missions ",
            "Plugin lol-npe-tutorial-path ",
            "Plugin lol-perks ",
            "Plugin lol-personalized-offers ",
            "Plugin lol-pft ",
            "Plugin lol-platform-config ",
            "Plugin lol-player-behavior ",
            "Plugin lol-player-level-up ",
            "Plugin lol-player-messaging ",
            "Plugin lol-player-preferences ",
            "Plugin lol-pre-end-of-game ",
            "Plugin lol-premade-voice ",
            "Plugin lol-purchase-widget ",
            "Plugin lol-queue-eligibility ",
            "Plugin lol-ranked-stats ",
            "Plugin lol-replays ",
            "Plugin lol-service-status ",
            "Plugin lol-settings ",
            "Plugin lol-shutdown ",
            "Plugin lol-simple-dialog-messages ",
            "Plugin lol-spectator ",
            "Plugin lol-store ",
            "Plugin lol-suggested-players ",
            "Plugin lol-summoner ",
            "Plugin lol-tencent-qt ",
            "Plugin lol-trophies ",
            "Plugin Manager ",
            "Plugin Manager Diagnostics ",
            "Plugin Manager Info ",
            "Plugin network-testing ",
            "Plugin patcher ",
            "Plugin payments ",
            "Plugin player-notifications ",
            "Plugin recofriender ",
            "Plugin riot-messaging-service ",
            "Plugin rso-auth ",
            "Plugin sanitizer ",
            "Plugin voice-chat ",
            "Plugins ",
            "process-control ",
            "riotclient ",
            "system ",
            "telemetry "});
            this.metroComboBox1.Location = new System.Drawing.Point(659, 63);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(354, 30);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(659, 99);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(178, 28);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Observe";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(843, 99);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(170, 28);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Stop observing";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // loggingTextBox
            // 
            this.loggingTextBox.AccessibleName = "logging";
            this.loggingTextBox.Location = new System.Drawing.Point(35, 63);
            this.loggingTextBox.Multiline = true;
            this.loggingTextBox.Name = "loggingTextBox";
            this.loggingTextBox.ReadOnly = true;
            this.loggingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.loggingTextBox.Size = new System.Drawing.Size(618, 364);
            this.loggingTextBox.TabIndex = 3;
            this.loggingTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loggingTextBox.Click += new System.EventHandler(this.loggingTextBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 457);
            this.Controls.Add(this.loggingTextBox);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroComboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Stealth Ward";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox loggingTextBox;
    }
}

