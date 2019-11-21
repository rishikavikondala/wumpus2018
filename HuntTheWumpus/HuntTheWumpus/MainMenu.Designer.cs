namespace HuntTheWumpus
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.map1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.map2 = new System.Windows.Forms.Button();
            this.map3 = new System.Windows.Forms.Button();
            this.map4 = new System.Windows.Forms.Button();
            this.map5 = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // map1
            // 
            this.map1.Location = new System.Drawing.Point(546, 352);
            this.map1.Name = "map1";
            this.map1.Size = new System.Drawing.Size(75, 31);
            this.map1.TabIndex = 0;
            this.map1.Text = "Map 1";
            this.map1.UseVisualStyleBackColor = true;
            this.map1.Click += new System.EventHandler(this.map1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "S E L E C T  Y O U R   M A P";
            // 
            // map2
            // 
            this.map2.Location = new System.Drawing.Point(546, 389);
            this.map2.Name = "map2";
            this.map2.Size = new System.Drawing.Size(75, 30);
            this.map2.TabIndex = 2;
            this.map2.Text = "Map 2";
            this.map2.UseVisualStyleBackColor = true;
            this.map2.Click += new System.EventHandler(this.map2_Click);
            // 
            // map3
            // 
            this.map3.Location = new System.Drawing.Point(546, 425);
            this.map3.Name = "map3";
            this.map3.Size = new System.Drawing.Size(75, 30);
            this.map3.TabIndex = 3;
            this.map3.Text = "Map 3";
            this.map3.UseVisualStyleBackColor = true;
            this.map3.Click += new System.EventHandler(this.map3_Click);
            // 
            // map4
            // 
            this.map4.Location = new System.Drawing.Point(546, 461);
            this.map4.Name = "map4";
            this.map4.Size = new System.Drawing.Size(75, 30);
            this.map4.TabIndex = 4;
            this.map4.Text = "Map 4";
            this.map4.UseVisualStyleBackColor = true;
            this.map4.Click += new System.EventHandler(this.map4_Click);
            // 
            // map5
            // 
            this.map5.Location = new System.Drawing.Point(546, 497);
            this.map5.Name = "map5";
            this.map5.Size = new System.Drawing.Size(75, 30);
            this.map5.TabIndex = 5;
            this.map5.Text = "Map 5";
            this.map5.UseVisualStyleBackColor = true;
            this.map5.Click += new System.EventHandler(this.map5_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(576, 566);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 50);
            this.quit.TabIndex = 6;
            this.quit.Text = "Q U I T";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(955, 76);
            this.label2.TabIndex = 7;
            this.label2.Text = "N A M E  Y O U R  P L A Y E R";
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(332, 175);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(499, 20);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.TextChanged += new System.EventHandler(this.NameLabel_TextChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(495, 566);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 50);
            this.back.TabIndex = 9;
            this.back.Text = "B A C K";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(441, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Simply type in your name- no additional keys need to be clicked.";
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.map5);
            this.Controls.Add(this.map4);
            this.Controls.Add(this.map3);
            this.Controls.Add(this.map2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button map1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button map2;
        private System.Windows.Forms.Button map3;
        private System.Windows.Forms.Button map4;
        private System.Windows.Forms.Button map5;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameLabel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label3;
    }
}