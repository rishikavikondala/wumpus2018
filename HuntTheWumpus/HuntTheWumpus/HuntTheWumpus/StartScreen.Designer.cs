namespace HuntTheWumpus
{
    partial class StartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.play = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.scores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.play.ForeColor = System.Drawing.Color.Black;
            this.play.Location = new System.Drawing.Point(522, 222);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(164, 73);
            this.play.TabIndex = 3;
            this.play.Text = "P L A Y";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.settings.Location = new System.Drawing.Point(411, 301);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(389, 67);
            this.settings.TabIndex = 4;
            this.settings.Text = "I N S T R U C T I O N S";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.quit.Location = new System.Drawing.Point(522, 447);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(164, 77);
            this.quit.TabIndex = 5;
            this.quit.Text = "Q U I T";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // scores
            // 
            this.scores.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.scores.Location = new System.Drawing.Point(411, 374);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(389, 67);
            this.scores.TabIndex = 6;
            this.scores.Text = "H I G H   S C O R E S";
            this.scores.UseVisualStyleBackColor = false;
            this.scores.Click += new System.EventHandler(this.scores_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.play);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button scores;
    }
}