namespace SheepRace
{
    partial class SheepRace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SheepRace));
            this.rbAli = new System.Windows.Forms.RadioButton();
            this.rbJoJo = new System.Windows.Forms.RadioButton();
            this.rbMoto = new System.Windows.Forms.RadioButton();
            this.btnBet = new System.Windows.Forms.Button();
            this.udBoxBet = new System.Windows.Forms.NumericUpDown();
            this.udBoxSheep = new System.Windows.Forms.NumericUpDown();
            this.btnRace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblAli = new System.Windows.Forms.Label();
            this.lblJoJo = new System.Windows.Forms.Label();
            this.lblMoto = new System.Windows.Forms.Label();
            this.lblBettor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLockIn = new System.Windows.Forms.Button();
            this.pbSheep1 = new System.Windows.Forms.PictureBox();
            this.pbSheep4 = new System.Windows.Forms.PictureBox();
            this.pbSheep3 = new System.Windows.Forms.PictureBox();
            this.pbSheep2 = new System.Windows.Forms.PictureBox();
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxSheep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // rbAli
            // 
            this.rbAli.AutoSize = true;
            this.rbAli.Location = new System.Drawing.Point(44, 334);
            this.rbAli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAli.Name = "rbAli";
            this.rbAli.Size = new System.Drawing.Size(44, 21);
            this.rbAli.TabIndex = 3;
            this.rbAli.TabStop = true;
            this.rbAli.Text = "Ali";
            this.rbAli.UseVisualStyleBackColor = true;
            this.rbAli.CheckedChanged += new System.EventHandler(this.rbAli_CheckedChanged);
            // 
            // rbJoJo
            // 
            this.rbJoJo.AutoSize = true;
            this.rbJoJo.Location = new System.Drawing.Point(44, 361);
            this.rbJoJo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbJoJo.Name = "rbJoJo";
            this.rbJoJo.Size = new System.Drawing.Size(59, 21);
            this.rbJoJo.TabIndex = 4;
            this.rbJoJo.TabStop = true;
            this.rbJoJo.Text = "JoJo";
            this.rbJoJo.UseVisualStyleBackColor = true;
            this.rbJoJo.CheckedChanged += new System.EventHandler(this.rbJoJo_CheckedChanged);
            // 
            // rbMoto
            // 
            this.rbMoto.AutoSize = true;
            this.rbMoto.Location = new System.Drawing.Point(44, 389);
            this.rbMoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMoto.Name = "rbMoto";
            this.rbMoto.Size = new System.Drawing.Size(60, 21);
            this.rbMoto.TabIndex = 5;
            this.rbMoto.TabStop = true;
            this.rbMoto.Text = "Moto";
            this.rbMoto.UseVisualStyleBackColor = true;
            this.rbMoto.CheckedChanged += new System.EventHandler(this.rbMoto_CheckedChanged);
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.Maroon;
            this.btnBet.ForeColor = System.Drawing.Color.White;
            this.btnBet.Location = new System.Drawing.Point(349, 439);
            this.btnBet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(187, 56);
            this.btnBet.TabIndex = 7;
            this.btnBet.Text = "Place Bet!";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // udBoxBet
            // 
            this.udBoxBet.Location = new System.Drawing.Point(116, 433);
            this.udBoxBet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.udBoxBet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udBoxBet.Name = "udBoxBet";
            this.udBoxBet.Size = new System.Drawing.Size(75, 22);
            this.udBoxBet.TabIndex = 8;
            // 
            // udBoxSheep
            // 
            this.udBoxSheep.Location = new System.Drawing.Point(116, 476);
            this.udBoxSheep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.udBoxSheep.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udBoxSheep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udBoxSheep.Name = "udBoxSheep";
            this.udBoxSheep.Size = new System.Drawing.Size(75, 22);
            this.udBoxSheep.TabIndex = 9;
            this.udBoxSheep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.Maroon;
            this.btnRace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRace.Enabled = false;
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.ForeColor = System.Drawing.Color.White;
            this.btnRace.Location = new System.Drawing.Point(699, 440);
            this.btnRace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(137, 53);
            this.btnRace.TabIndex = 11;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bet  $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sheep  #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bettor Name:     Cash Available:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblAli
            // 
            this.lblAli.Location = new System.Drawing.Point(429, 335);
            this.lblAli.Name = "lblAli";
            this.lblAli.Size = new System.Drawing.Size(407, 23);
            this.lblAli.TabIndex = 22;
            this.lblAli.Text = "label4";
            // 
            // lblJoJo
            // 
            this.lblJoJo.Location = new System.Drawing.Point(429, 363);
            this.lblJoJo.Name = "lblJoJo";
            this.lblJoJo.Size = new System.Drawing.Size(407, 23);
            this.lblJoJo.TabIndex = 23;
            this.lblJoJo.Text = "label5";
            // 
            // lblMoto
            // 
            this.lblMoto.Location = new System.Drawing.Point(429, 391);
            this.lblMoto.Name = "lblMoto";
            this.lblMoto.Size = new System.Drawing.Size(407, 23);
            this.lblMoto.TabIndex = 24;
            this.lblMoto.Text = "label6";
            // 
            // lblBettor
            // 
            this.lblBettor.AutoSize = true;
            this.lblBettor.Location = new System.Drawing.Point(229, 480);
            this.lblBettor.Name = "lblBettor";
            this.lblBettor.Size = new System.Drawing.Size(46, 17);
            this.lblBettor.TabIndex = 25;
            this.lblBettor.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Bettor:";
            // 
            // btnLockIn
            // 
            this.btnLockIn.BackColor = System.Drawing.Color.Maroon;
            this.btnLockIn.ForeColor = System.Drawing.Color.White;
            this.btnLockIn.Location = new System.Drawing.Point(554, 440);
            this.btnLockIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLockIn.Name = "btnLockIn";
            this.btnLockIn.Size = new System.Drawing.Size(119, 53);
            this.btnLockIn.TabIndex = 27;
            this.btnLockIn.Text = "Lock In Bets!";
            this.btnLockIn.UseVisualStyleBackColor = false;
            this.btnLockIn.Click += new System.EventHandler(this.btnLockIn_Click);
            // 
            // pbSheep1
            // 
            this.pbSheep1.Image = ((System.Drawing.Image)(resources.GetObject("pbSheep1.Image")));
            this.pbSheep1.Location = new System.Drawing.Point(64, 31);
            this.pbSheep1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSheep1.Name = "pbSheep1";
            this.pbSheep1.Size = new System.Drawing.Size(81, 48);
            this.pbSheep1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSheep1.TabIndex = 17;
            this.pbSheep1.TabStop = false;
            // 
            // pbSheep4
            // 
            this.pbSheep4.Image = ((System.Drawing.Image)(resources.GetObject("pbSheep4.Image")));
            this.pbSheep4.Location = new System.Drawing.Point(64, 233);
            this.pbSheep4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSheep4.Name = "pbSheep4";
            this.pbSheep4.Size = new System.Drawing.Size(81, 37);
            this.pbSheep4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSheep4.TabIndex = 20;
            this.pbSheep4.TabStop = false;
            // 
            // pbSheep3
            // 
            this.pbSheep3.Image = ((System.Drawing.Image)(resources.GetObject("pbSheep3.Image")));
            this.pbSheep3.Location = new System.Drawing.Point(64, 162);
            this.pbSheep3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSheep3.Name = "pbSheep3";
            this.pbSheep3.Size = new System.Drawing.Size(81, 47);
            this.pbSheep3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSheep3.TabIndex = 19;
            this.pbSheep3.TabStop = false;
            // 
            // pbSheep2
            // 
            this.pbSheep2.Image = ((System.Drawing.Image)(resources.GetObject("pbSheep2.Image")));
            this.pbSheep2.Location = new System.Drawing.Point(64, 100);
            this.pbSheep2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSheep2.Name = "pbSheep2";
            this.pbSheep2.Size = new System.Drawing.Size(81, 37);
            this.pbSheep2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSheep2.TabIndex = 18;
            this.pbSheep2.TabStop = false;
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.Image = global::SheepRace.Properties.Resources.track;
            this.pbRaceTrack.Location = new System.Drawing.Point(12, 6);
            this.pbRaceTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(859, 293);
            this.pbRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaceTrack.TabIndex = 21;
            this.pbRaceTrack.TabStop = false;
            // 
            // SheepRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(880, 515);
            this.Controls.Add(this.btnLockIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBettor);
            this.Controls.Add(this.lblMoto);
            this.Controls.Add(this.lblJoJo);
            this.Controls.Add(this.lblAli);
            this.Controls.Add(this.pbSheep1);
            this.Controls.Add(this.pbSheep4);
            this.Controls.Add(this.pbSheep3);
            this.Controls.Add(this.pbSheep2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.udBoxSheep);
            this.Controls.Add(this.udBoxBet);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.rbMoto);
            this.Controls.Add(this.rbJoJo);
            this.Controls.Add(this.rbAli);
            this.Controls.Add(this.pbRaceTrack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SheepRace";
            this.Text = "Sheep Race!";
            ((System.ComponentModel.ISupportInitialize)(this.udBoxBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxSheep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSheep2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbAli;
        private System.Windows.Forms.RadioButton rbJoJo;
        private System.Windows.Forms.RadioButton rbMoto;
        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.NumericUpDown udBoxBet;
        private System.Windows.Forms.NumericUpDown udBoxSheep;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbSheep1;
        private System.Windows.Forms.PictureBox pbSheep2;
        private System.Windows.Forms.PictureBox pbSheep3;
        private System.Windows.Forms.PictureBox pbSheep4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAli;
        private System.Windows.Forms.Label lblJoJo;
        private System.Windows.Forms.Label lblMoto;
        private System.Windows.Forms.Label lblBettor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLockIn;
    }
}
