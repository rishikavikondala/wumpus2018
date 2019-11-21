namespace HuntTheWumpus
{
    partial class TriviaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriviaForm));
            this.Question = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.BackColor = System.Drawing.Color.Transparent;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Question.ForeColor = System.Drawing.Color.White;
            this.Question.Location = new System.Drawing.Point(64, 23);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(117, 20);
            this.Question.TabIndex = 0;
            this.Question.Text = "QuestionLabel";
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose A, B, C, or D -------------------->";
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(303, 218);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(100, 22);
            this.Answer.TabIndex = 2;
            this.Answer.TextChanged += new System.EventHandler(this.Answer_TextChanged);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(313, 246);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 3;
            this.Confirm.Text = "Submit";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOTE: PLEASE ANSWER USING LOWER CASE LETTERS";
            // 
            // TriviaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Question);
            this.Name = "TriviaForm";
            this.Text = "TriviaForm";
            this.Load += new System.EventHandler(this.TriviaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label2;
    }
}