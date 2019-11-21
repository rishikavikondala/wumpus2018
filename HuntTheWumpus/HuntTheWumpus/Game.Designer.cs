namespace HuntTheWumpus
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.shoot = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.Button();
            this.buyarrow = new System.Windows.Forms.Button();
            this.buysecret = new System.Windows.Forms.Button();
            this.NW = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NE = new System.Windows.Forms.Label();
            this.SE = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.SW = new System.Windows.Forms.Label();
            this.goldBox = new System.Windows.Forms.Label();
            this.arrowBox = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.scoreBox = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.playerOpposite = new System.Windows.Forms.Label();
            this.changemap = new System.Windows.Forms.Button();
            this.highscore = new System.Windows.Forms.Button();
            this.turn = new System.Windows.Forms.Label();
            this.topviewmap = new System.Windows.Forms.Label();
            this.PlayerPosition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reminderlabel = new System.Windows.Forms.Label();
            this.indicatorlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shoot
            // 
            this.shoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.shoot.Location = new System.Drawing.Point(861, 262);
            this.shoot.Name = "shoot";
            this.shoot.Size = new System.Drawing.Size(318, 49);
            this.shoot.TabIndex = 1;
            this.shoot.Text = "S H O O T";
            this.shoot.UseVisualStyleBackColor = false;
            this.shoot.Click += new System.EventHandler(this.shoot_Click);
            // 
            // move
            // 
            this.move.BackColor = System.Drawing.Color.Red;
            this.move.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.move.Location = new System.Drawing.Point(861, 147);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(318, 109);
            this.move.TabIndex = 2;
            this.move.Text = "M O V E";
            this.move.UseVisualStyleBackColor = false;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // buyarrow
            // 
            this.buyarrow.BackColor = System.Drawing.Color.Yellow;
            this.buyarrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buyarrow.Location = new System.Drawing.Point(861, 317);
            this.buyarrow.Name = "buyarrow";
            this.buyarrow.Size = new System.Drawing.Size(318, 49);
            this.buyarrow.TabIndex = 3;
            this.buyarrow.Text = "BUY ARROW ($1)";
            this.buyarrow.UseVisualStyleBackColor = false;
            this.buyarrow.Click += new System.EventHandler(this.buyarrow_Click);
            // 
            // buysecret
            // 
            this.buysecret.BackColor = System.Drawing.Color.Lime;
            this.buysecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buysecret.Location = new System.Drawing.Point(861, 372);
            this.buysecret.Name = "buysecret";
            this.buysecret.Size = new System.Drawing.Size(318, 48);
            this.buysecret.TabIndex = 4;
            this.buysecret.Text = "BUY SECRET ($1)";
            this.buysecret.UseVisualStyleBackColor = false;
            this.buysecret.Click += new System.EventHandler(this.buysecret_Click);
            // 
            // NW
            // 
            this.NW.AutoSize = true;
            this.NW.BackColor = System.Drawing.Color.Transparent;
            this.NW.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NW.Location = new System.Drawing.Point(14, 72);
            this.NW.Name = "NW";
            this.NW.Size = new System.Drawing.Size(47, 17);
            this.NW.TabIndex = 5;
            this.NW.Text = "NW: ?";
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.BackColor = System.Drawing.Color.Transparent;
            this.N.ForeColor = System.Drawing.Color.White;
            this.N.Location = new System.Drawing.Point(93, 43);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(34, 17);
            this.N.TabIndex = 6;
            this.N.Text = "N: ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "O = Open (can move/shoot) | X = Closed";
            // 
            // NE
            // 
            this.NE.AutoSize = true;
            this.NE.BackColor = System.Drawing.Color.Transparent;
            this.NE.ForeColor = System.Drawing.Color.Transparent;
            this.NE.Location = new System.Drawing.Point(165, 72);
            this.NE.Name = "NE";
            this.NE.Size = new System.Drawing.Size(43, 17);
            this.NE.TabIndex = 8;
            this.NE.Text = "NE: ?";
            // 
            // SE
            // 
            this.SE.AutoSize = true;
            this.SE.BackColor = System.Drawing.Color.Transparent;
            this.SE.ForeColor = System.Drawing.Color.White;
            this.SE.Location = new System.Drawing.Point(165, 133);
            this.SE.Name = "SE";
            this.SE.Size = new System.Drawing.Size(42, 17);
            this.SE.TabIndex = 9;
            this.SE.Text = "SE: ?";
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.BackColor = System.Drawing.Color.Transparent;
            this.S.ForeColor = System.Drawing.Color.White;
            this.S.Location = new System.Drawing.Point(93, 166);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(33, 17);
            this.S.TabIndex = 10;
            this.S.Text = "S: ?";
            // 
            // SW
            // 
            this.SW.AutoSize = true;
            this.SW.BackColor = System.Drawing.Color.Transparent;
            this.SW.ForeColor = System.Drawing.Color.White;
            this.SW.Location = new System.Drawing.Point(15, 133);
            this.SW.Name = "SW";
            this.SW.Size = new System.Drawing.Size(46, 17);
            this.SW.TabIndex = 11;
            this.SW.Text = "SW: ?";
            // 
            // goldBox
            // 
            this.goldBox.AutoSize = true;
            this.goldBox.BackColor = System.Drawing.Color.Transparent;
            this.goldBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.goldBox.ForeColor = System.Drawing.Color.White;
            this.goldBox.Location = new System.Drawing.Point(901, 37);
            this.goldBox.Name = "goldBox";
            this.goldBox.Size = new System.Drawing.Size(186, 36);
            this.goldBox.TabIndex = 12;
            this.goldBox.Text = "Total Gold: 0";
            // 
            // arrowBox
            // 
            this.arrowBox.AutoSize = true;
            this.arrowBox.BackColor = System.Drawing.Color.Transparent;
            this.arrowBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.arrowBox.ForeColor = System.Drawing.Color.White;
            this.arrowBox.Location = new System.Drawing.Point(901, 72);
            this.arrowBox.Name = "arrowBox";
            this.arrowBox.Size = new System.Drawing.Size(217, 36);
            this.arrowBox.TabIndex = 13;
            this.arrowBox.Text = "Total Arrows: 2";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(327, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 122);
            this.label11.TabIndex = 15;
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F);
            this.quit.Location = new System.Drawing.Point(861, 589);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(318, 69);
            this.quit.TabIndex = 16;
            this.quit.Text = "Q U I T";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // scoreBox
            // 
            this.scoreBox.AutoSize = true;
            this.scoreBox.BackColor = System.Drawing.Color.Transparent;
            this.scoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.scoreBox.ForeColor = System.Drawing.Color.White;
            this.scoreBox.Location = new System.Drawing.Point(901, 2);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(234, 36);
            this.scoreBox.TabIndex = 17;
            this.scoreBox.Text = "Total Score: 130";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(340, 101);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(354, 22);
            this.input.TabIndex = 19;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // playerOpposite
            // 
            this.playerOpposite.BackColor = System.Drawing.Color.DarkGray;
            this.playerOpposite.Location = new System.Drawing.Point(493, 249);
            this.playerOpposite.Name = "playerOpposite";
            this.playerOpposite.Size = new System.Drawing.Size(226, 190);
            this.playerOpposite.TabIndex = 21;
            // 
            // changemap
            // 
            this.changemap.BackColor = System.Drawing.Color.Blue;
            this.changemap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F);
            this.changemap.Location = new System.Drawing.Point(861, 508);
            this.changemap.Name = "changemap";
            this.changemap.Size = new System.Drawing.Size(318, 75);
            this.changemap.TabIndex = 22;
            this.changemap.Text = "C H A N G E    M A P";
            this.changemap.UseVisualStyleBackColor = false;
            this.changemap.Click += new System.EventHandler(this.changemap_Click);
            // 
            // highscore
            // 
            this.highscore.BackColor = System.Drawing.Color.Cyan;
            this.highscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.highscore.Location = new System.Drawing.Point(861, 427);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(318, 75);
            this.highscore.TabIndex = 23;
            this.highscore.Text = "HIGH  SCORES";
            this.highscore.UseVisualStyleBackColor = false;
            this.highscore.Click += new System.EventHandler(this.highscore_Click);
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.BackColor = System.Drawing.Color.Transparent;
            this.turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.turn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.turn.Location = new System.Drawing.Point(901, 108);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(199, 36);
            this.turn.TabIndex = 26;
            this.turn.Text = "Total Turns: 0";
            // 
            // topviewmap
            // 
            this.topviewmap.Image = ((System.Drawing.Image)(resources.GetObject("topviewmap.Image")));
            this.topviewmap.Location = new System.Drawing.Point(13, 448);
            this.topviewmap.Name = "topviewmap";
            this.topviewmap.Size = new System.Drawing.Size(192, 169);
            this.topviewmap.TabIndex = 27;
            // 
            // PlayerPosition
            // 
            this.PlayerPosition.AutoSize = true;
            this.PlayerPosition.BackColor = System.Drawing.Color.Silver;
            this.PlayerPosition.Location = new System.Drawing.Point(112, 563);
            this.PlayerPosition.Name = "PlayerPosition";
            this.PlayerPosition.Size = new System.Drawing.Size(17, 17);
            this.PlayerPosition.TabIndex = 30;
            this.PlayerPosition.Text = "X";
            this.PlayerPosition.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "X = Player\'s Position";
            // 
            // reminderlabel
            // 
            this.reminderlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.reminderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.reminderlabel.Location = new System.Drawing.Point(16, 211);
            this.reminderlabel.Name = "reminderlabel";
            this.reminderlabel.Size = new System.Drawing.Size(175, 205);
            this.reminderlabel.TabIndex = 32;
            this.reminderlabel.Text = "REMINDER TO PLAYERS: Type in the direction you would like to perform an action in" +
    ", and then click move or shoot.";
            // 
            // indicatorlabel
            // 
            this.indicatorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.indicatorlabel.Location = new System.Drawing.Point(340, 9);
            this.indicatorlabel.Name = "indicatorlabel";
            this.indicatorlabel.Size = new System.Drawing.Size(354, 42);
            this.indicatorlabel.TabIndex = 33;
            this.indicatorlabel.Text = "TYPE A DIRECTION TO PERFORM AN ACTION IN USING THE TEXT BOX BELOW.";
            // 
            // Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 663);
            this.Controls.Add(this.indicatorlabel);
            this.Controls.Add(this.reminderlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerPosition);
            this.Controls.Add(this.topviewmap);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.changemap);
            this.Controls.Add(this.playerOpposite);
            this.Controls.Add(this.input);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.arrowBox);
            this.Controls.Add(this.goldBox);
            this.Controls.Add(this.SW);
            this.Controls.Add(this.S);
            this.Controls.Add(this.SE);
            this.Controls.Add(this.NE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.N);
            this.Controls.Add(this.NW);
            this.Controls.Add(this.buysecret);
            this.Controls.Add(this.buyarrow);
            this.Controls.Add(this.move);
            this.Controls.Add(this.shoot);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button shoot;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.Button buyarrow;
        private System.Windows.Forms.Button buysecret;
        private System.Windows.Forms.Label NW;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NE;
        private System.Windows.Forms.Label SE;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label SW;
        private System.Windows.Forms.Label goldBox;
        private System.Windows.Forms.Label arrowBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label scoreBox;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label playerOpposite;
        private System.Windows.Forms.Button changemap;
        private System.Windows.Forms.Button highscore;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.Label topviewmap;
        private System.Windows.Forms.Label PlayerPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reminderlabel;
        private System.Windows.Forms.Label indicatorlabel;
    }
}