namespace HuntTheWumpus
{
    partial class HintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HintForm));
            this.HintLabel = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.BackColor = System.Drawing.Color.Transparent;
            this.HintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HintLabel.ForeColor = System.Drawing.Color.White;
            this.HintLabel.Location = new System.Drawing.Point(25, 74);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(40, 20);
            this.HintLabel.TabIndex = 0;
            this.HintLabel.Text = "Hint";
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.ok.Location = new System.Drawing.Point(541, 270);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(126, 72);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // HintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1185, 348);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.HintLabel);
            this.Name = "HintForm";
            this.Text = "HintForm";
            this.Load += new System.EventHandler(this.HintForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Button ok;
    }
}