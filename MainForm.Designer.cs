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
            this.endpointComboBox = new MetroFramework.Controls.MetroComboBox();
            this.observeButton = new MetroFramework.Controls.MetroButton();
            this.stopObervingButton = new MetroFramework.Controls.MetroButton();
            this.loggingTextBox = new MetroFramework.Controls.MetroTextBox();
            this.observeAllToggle = new MetroFramework.Controls.MetroToggle();
            this.oberseAllText = new MetroFramework.Controls.MetroLabel();
            this.observedTextBox = new MetroFramework.Controls.MetroTextBox();
            this.currentlyObservedtext = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // endpointComboBox
            // 
            this.endpointComboBox.FormattingEnabled = true;
            this.endpointComboBox.ItemHeight = 24;
            this.endpointComboBox.Items.AddRange(new object[] {
            "builtin",
            "cookie-jar",
            "data-store",
            "performance",
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
            this.endpointComboBox.Location = new System.Drawing.Point(659, 63);
            this.endpointComboBox.Name = "endpointComboBox";
            this.endpointComboBox.Size = new System.Drawing.Size(354, 30);
            this.endpointComboBox.TabIndex = 0;
            this.endpointComboBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // observeButton
            // 
            this.observeButton.Location = new System.Drawing.Point(659, 99);
            this.observeButton.Name = "observeButton";
            this.observeButton.Size = new System.Drawing.Size(178, 28);
            this.observeButton.TabIndex = 1;
            this.observeButton.Text = "Observe";
            this.observeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.observeButton.Click += new System.EventHandler(this.observeButton_Click);
            // 
            // stopObervingButton
            // 
            this.stopObervingButton.Location = new System.Drawing.Point(843, 99);
            this.stopObervingButton.Name = "stopObervingButton";
            this.stopObervingButton.Size = new System.Drawing.Size(170, 28);
            this.stopObervingButton.TabIndex = 2;
            this.stopObervingButton.Text = "Stop observing";
            this.stopObervingButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stopObervingButton.Click += new System.EventHandler(this.stopObervingButton_Click);
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
            // observeAllToggle
            // 
            this.observeAllToggle.AccessibleName = "observeAllToggle";
            this.observeAllToggle.AutoSize = true;
            this.observeAllToggle.Checked = true;
            this.observeAllToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.observeAllToggle.Location = new System.Drawing.Point(873, 144);
            this.observeAllToggle.Name = "observeAllToggle";
            this.observeAllToggle.Size = new System.Drawing.Size(80, 21);
            this.observeAllToggle.TabIndex = 4;
            this.observeAllToggle.Text = "On";
            this.observeAllToggle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.observeAllToggle.UseVisualStyleBackColor = true;
            // 
            // oberseAllText
            // 
            this.oberseAllText.AutoSize = true;
            this.oberseAllText.Location = new System.Drawing.Point(693, 144);
            this.oberseAllText.Name = "oberseAllText";
            this.oberseAllText.Size = new System.Drawing.Size(169, 20);
            this.oberseAllText.TabIndex = 5;
            this.oberseAllText.Text = "Observe all the endpoints";
            this.oberseAllText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // observedTextBox
            // 
            this.observedTextBox.AccessibleName = "logging";
            this.observedTextBox.Location = new System.Drawing.Point(693, 231);
            this.observedTextBox.Multiline = true;
            this.observedTextBox.Name = "observedTextBox";
            this.observedTextBox.ReadOnly = true;
            this.observedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observedTextBox.Size = new System.Drawing.Size(306, 196);
            this.observedTextBox.TabIndex = 6;
            this.observedTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // currentlyObservedtext
            // 
            this.currentlyObservedtext.AutoSize = true;
            this.currentlyObservedtext.Location = new System.Drawing.Point(746, 199);
            this.currentlyObservedtext.Name = "currentlyObservedtext";
            this.currentlyObservedtext.Size = new System.Drawing.Size(197, 20);
            this.currentlyObservedtext.TabIndex = 7;
            this.currentlyObservedtext.Text = "Currently observed endpoints:";
            this.currentlyObservedtext.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 457);
            this.Controls.Add(this.currentlyObservedtext);
            this.Controls.Add(this.observedTextBox);
            this.Controls.Add(this.oberseAllText);
            this.Controls.Add(this.observeAllToggle);
            this.Controls.Add(this.loggingTextBox);
            this.Controls.Add(this.stopObervingButton);
            this.Controls.Add(this.observeButton);
            this.Controls.Add(this.endpointComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Stealth Ward";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox endpointComboBox;
        private MetroFramework.Controls.MetroButton observeButton;
        private MetroFramework.Controls.MetroButton stopObervingButton;
        private MetroFramework.Controls.MetroTextBox loggingTextBox;
        private MetroFramework.Controls.MetroToggle observeAllToggle;
        private MetroFramework.Controls.MetroLabel oberseAllText;
        private MetroFramework.Controls.MetroTextBox observedTextBox;
        private MetroFramework.Controls.MetroLabel currentlyObservedtext;
    }
}

