namespace HuntTheWumpus
{
    partial class StatusFormGood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusFormGood));
            this.ArrowGood = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArrowGood
            // 
            this.ArrowGood.AutoSize = true;
            this.ArrowGood.BackColor = System.Drawing.Color.Transparent;
            this.ArrowGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ArrowGood.ForeColor = System.Drawing.Color.White;
            this.ArrowGood.Location = new System.Drawing.Point(141, 62);
            this.ArrowGood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ArrowGood.Name = "ArrowGood";
            this.ArrowGood.Size = new System.Drawing.Size(401, 17);
            this.ArrowGood.TabIndex = 1;
            this.ArrowGood.Text = "Awesome! You got 2 questions right, giving you 2 extra arrows!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Awesome! You got 2 questions right, giving you a secret piece of intelligence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Awesome! You got 2 questions right, allowing you to barely escape the clutches of" +
    " the Wumpus!";
            // 
            // StatusFormGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(646, 276);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArrowGood);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StatusFormGood";
            this.Text = "StatusFormGood";
            this.Load += new System.EventHandler(this.StatusFormGood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArrowGood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}