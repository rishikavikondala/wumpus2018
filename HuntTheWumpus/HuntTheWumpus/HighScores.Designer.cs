namespace HuntTheWumpus
{
    partial class HighScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScores));
            this.title = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.scores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.title.Location = new System.Drawing.Point(462, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(297, 58);
            this.title.TabIndex = 0;
            this.title.Text = "High Scores";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(534, 593);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "B A C K";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(615, 593);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 2;
            this.quit.Text = "Q U I T";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // scores
            // 
            this.scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.scores.Location = new System.Drawing.Point(12, 85);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(1158, 505);
            this.scores.TabIndex = 3;
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.title);
            this.Name = "HighScores";
            this.Text = "HighScores";
            this.Load += new System.EventHandler(this.HighScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label scores;
    }
}