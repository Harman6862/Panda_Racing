﻿namespace Panda_Racing
{
    partial class RacingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacingForm));
            this.Panda1 = new System.Windows.Forms.PictureBox();
            this.Panda2 = new System.Windows.Forms.PictureBox();
            this.Panda3 = new System.Windows.Forms.PictureBox();
            this.Panda4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GuriBet = new System.Windows.Forms.Label();
            this.HarmanBet = new System.Windows.Forms.Label();
            this.JassiBet = new System.Windows.Forms.Label();
            this.BetDetails = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.PandaNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BettingAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.GuriRButton = new System.Windows.Forms.RadioButton();
            this.HarmanRButton = new System.Windows.Forms.RadioButton();
            this.JassiButton = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            this.racetrack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Panda1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panda2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panda3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panda4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PandaNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            this.SuspendLayout();
            // 
            // Panda1
            // 
            this.Panda1.Image = ((System.Drawing.Image)(resources.GetObject("Panda1.Image")));
            this.Panda1.Location = new System.Drawing.Point(18, 52);
            this.Panda1.Margin = new System.Windows.Forms.Padding(4);
            this.Panda1.Name = "Panda1";
            this.Panda1.Size = new System.Drawing.Size(89, 56);
            this.Panda1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Panda1.TabIndex = 1;
            this.Panda1.TabStop = false;
            // 
            // Panda2
            // 
            this.Panda2.Image = ((System.Drawing.Image)(resources.GetObject("Panda2.Image")));
            this.Panda2.Location = new System.Drawing.Point(17, 138);
            this.Panda2.Margin = new System.Windows.Forms.Padding(4);
            this.Panda2.Name = "Panda2";
            this.Panda2.Size = new System.Drawing.Size(83, 57);
            this.Panda2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Panda2.TabIndex = 2;
            this.Panda2.TabStop = false;
            // 
            // Panda3
            // 
            this.Panda3.Image = ((System.Drawing.Image)(resources.GetObject("Panda3.Image")));
            this.Panda3.Location = new System.Drawing.Point(18, 226);
            this.Panda3.Margin = new System.Windows.Forms.Padding(4);
            this.Panda3.Name = "Panda3";
            this.Panda3.Size = new System.Drawing.Size(83, 57);
            this.Panda3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Panda3.TabIndex = 3;
            this.Panda3.TabStop = false;
            // 
            // Panda4
            // 
            this.Panda4.Image = ((System.Drawing.Image)(resources.GetObject("Panda4.Image")));
            this.Panda4.Location = new System.Drawing.Point(18, 319);
            this.Panda4.Margin = new System.Windows.Forms.Padding(4);
            this.Panda4.Name = "Panda4";
            this.Panda4.Size = new System.Drawing.Size(83, 57);
            this.Panda4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Panda4.TabIndex = 4;
            this.Panda4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.GuriBet);
            this.groupBox1.Controls.Add(this.HarmanBet);
            this.groupBox1.Controls.Add(this.JassiBet);
            this.groupBox1.Controls.Add(this.BetDetails);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.PandaNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BettingAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.GuriRButton);
            this.groupBox1.Controls.Add(this.HarmanRButton);
            this.groupBox1.Controls.Add(this.JassiButton);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Location = new System.Drawing.Point(-1, 447);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1069, 215);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panda Betting ";
            // 
            // GuriBet
            // 
            this.GuriBet.BackColor = System.Drawing.SystemColors.Info;
            this.GuriBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuriBet.Location = new System.Drawing.Point(649, 110);
            this.GuriBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GuriBet.Name = "GuriBet";
            this.GuriBet.Size = new System.Drawing.Size(386, 20);
            this.GuriBet.TabIndex = 13;
            // 
            // HarmanBet
            // 
            this.HarmanBet.BackColor = System.Drawing.SystemColors.Info;
            this.HarmanBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HarmanBet.Location = new System.Drawing.Point(649, 80);
            this.HarmanBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HarmanBet.Name = "HarmanBet";
            this.HarmanBet.Size = new System.Drawing.Size(386, 20);
            this.HarmanBet.TabIndex = 12;
            // 
            // JassiBet
            // 
            this.JassiBet.BackColor = System.Drawing.SystemColors.Info;
            this.JassiBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JassiBet.Location = new System.Drawing.Point(649, 50);
            this.JassiBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JassiBet.Name = "JassiBet";
            this.JassiBet.Size = new System.Drawing.Size(386, 20);
            this.JassiBet.TabIndex = 11;
            // 
            // BetDetails
            // 
            this.BetDetails.AutoSize = true;
            this.BetDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetDetails.Location = new System.Drawing.Point(645, 20);
            this.BetDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BetDetails.Name = "BetDetails";
            this.BetDetails.Size = new System.Drawing.Size(48, 20);
            this.BetDetails.TabIndex = 10;
            this.BetDetails.Text = "Bets";
            // 
            // race
            // 
            this.race.BackColor = System.Drawing.Color.Green;
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.ForeColor = System.Drawing.Color.White;
            this.race.Location = new System.Drawing.Point(856, 145);
            this.race.Margin = new System.Windows.Forms.Padding(4);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(180, 37);
            this.race.TabIndex = 9;
            this.race.Text = "START RACE";
            this.race.UseVisualStyleBackColor = false;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // PandaNumber
            // 
            this.PandaNumber.Location = new System.Drawing.Point(529, 106);
            this.PandaNumber.Margin = new System.Windows.Forms.Padding(4);
            this.PandaNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PandaNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PandaNumber.Name = "PandaNumber";
            this.PandaNumber.Size = new System.Drawing.Size(85, 22);
            this.PandaNumber.TabIndex = 8;
            this.PandaNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Panda number";
            // 
            // BettingAmount
            // 
            this.BettingAmount.Location = new System.Drawing.Point(531, 47);
            this.BettingAmount.Margin = new System.Windows.Forms.Padding(4);
            this.BettingAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BettingAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.Name = "BettingAmount";
            this.BettingAmount.Size = new System.Drawing.Size(84, 22);
            this.BettingAmount.TabIndex = 6;
            this.BettingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bets
            // 
            this.Bets.BackColor = System.Drawing.Color.Green;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bets.ForeColor = System.Drawing.Color.White;
            this.Bets.Location = new System.Drawing.Point(364, 37);
            this.Bets.Margin = new System.Windows.Forms.Padding(4);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(112, 44);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = false;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // GuriRButton
            // 
            this.GuriRButton.AutoSize = true;
            this.GuriRButton.Checked = true;
            this.GuriRButton.Location = new System.Drawing.Point(19, 119);
            this.GuriRButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuriRButton.Name = "GuriRButton";
            this.GuriRButton.Size = new System.Drawing.Size(56, 21);
            this.GuriRButton.TabIndex = 3;
            this.GuriRButton.TabStop = true;
            this.GuriRButton.Text = "Guri";
            this.GuriRButton.UseVisualStyleBackColor = true;
            this.GuriRButton.CheckedChanged += new System.EventHandler(this.GuriButton_CheckedChanged);
            // 
            // HarmanRButton
            // 
            this.HarmanRButton.AutoSize = true;
            this.HarmanRButton.Location = new System.Drawing.Point(19, 90);
            this.HarmanRButton.Margin = new System.Windows.Forms.Padding(4);
            this.HarmanRButton.Name = "HarmanRButton";
            this.HarmanRButton.Size = new System.Drawing.Size(79, 21);
            this.HarmanRButton.TabIndex = 2;
            this.HarmanRButton.Text = "Harman";
            this.HarmanRButton.UseVisualStyleBackColor = true;
            this.HarmanRButton.CheckedChanged += new System.EventHandler(this.HarmanButton_CheckedChanged);
            // 
            // JassiButton
            // 
            this.JassiButton.AutoSize = true;
            this.JassiButton.Location = new System.Drawing.Point(19, 60);
            this.JassiButton.Margin = new System.Windows.Forms.Padding(4);
            this.JassiButton.Name = "JassiButton";
            this.JassiButton.Size = new System.Drawing.Size(61, 21);
            this.JassiButton.TabIndex = 1;
            this.JassiButton.Text = "Jassi";
            this.JassiButton.UseVisualStyleBackColor = true;
            this.JassiButton.CheckedChanged += new System.EventHandler(this.JassiButton_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(15, 30);
            this.MaximumBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(120, 20);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.SystemColors.Control;
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(-1, 4);
            this.racetrack.Margin = new System.Windows.Forms.Padding(4);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1069, 416);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            // 
            // RacingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Panda4);
            this.Controls.Add(this.Panda3);
            this.Controls.Add(this.Panda2);
            this.Controls.Add(this.Panda1);
            this.Controls.Add(this.racetrack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RacingForm";
            this.Text = "Race Course";
            ((System.ComponentModel.ISupportInitialize)(this.Panda1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panda2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panda3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panda4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PandaNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Panda1;
        private System.Windows.Forms.PictureBox Panda2;
        private System.Windows.Forms.PictureBox Panda3;
        private System.Windows.Forms.PictureBox Panda4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton GuriRButton;
        private System.Windows.Forms.RadioButton HarmanRButton;
        private System.Windows.Forms.RadioButton JassiButton;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BettingAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown PandaNumber;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label BetDetails;
        private System.Windows.Forms.Label JassiBet;
        private System.Windows.Forms.Label GuriBet;
        private System.Windows.Forms.Label HarmanBet;
        private System.Windows.Forms.PictureBox racetrack;
    }
}
