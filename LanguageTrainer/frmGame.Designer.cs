namespace LanguageTrainer
{
    partial class frmGame
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStat = new System.Windows.Forms.GroupBox();
            this.lblTimeP2 = new System.Windows.Forms.Label();
            this.lblTimeP1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPoints2 = new System.Windows.Forms.Label();
            this.lblPoints1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTranslation = new System.Windows.Forms.GroupBox();
            this.grpWord = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerPlayer1 = new System.Windows.Forms.Timer(this.components);
            this.timerPlayer2 = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip.SuspendLayout();
            this.grpStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1078, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // grpStat
            // 
            this.grpStat.BackColor = System.Drawing.Color.White;
            this.grpStat.Controls.Add(this.lblTimeP2);
            this.grpStat.Controls.Add(this.lblTimeP1);
            this.grpStat.Controls.Add(this.lblTime);
            this.grpStat.Controls.Add(this.lblPoints2);
            this.grpStat.Controls.Add(this.lblPoints1);
            this.grpStat.Controls.Add(this.label6);
            this.grpStat.Controls.Add(this.label4);
            this.grpStat.Controls.Add(this.label2);
            this.grpStat.Controls.Add(this.lblPlayer2);
            this.grpStat.Controls.Add(this.lblPlayer1);
            this.grpStat.Controls.Add(this.label3);
            this.grpStat.Controls.Add(this.label1);
            this.grpStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpStat.Location = new System.Drawing.Point(0, 28);
            this.grpStat.Name = "grpStat";
            this.grpStat.Size = new System.Drawing.Size(1078, 112);
            this.grpStat.TabIndex = 1;
            this.grpStat.TabStop = false;
            this.grpStat.Text = "Game Statistics ";
            // 
            // lblTimeP2
            // 
            this.lblTimeP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTimeP2.AutoSize = true;
            this.lblTimeP2.Location = new System.Drawing.Point(728, 63);
            this.lblTimeP2.Name = "lblTimeP2";
            this.lblTimeP2.Size = new System.Drawing.Size(19, 21);
            this.lblTimeP2.TabIndex = 0;
            this.lblTimeP2.Text = "0";
            // 
            // lblTimeP1
            // 
            this.lblTimeP1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTimeP1.AutoSize = true;
            this.lblTimeP1.Location = new System.Drawing.Point(316, 63);
            this.lblTimeP1.Name = "lblTimeP1";
            this.lblTimeP1.Size = new System.Drawing.Size(19, 21);
            this.lblTimeP1.TabIndex = 0;
            this.lblTimeP1.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(511, 63);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(19, 21);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "0";
            // 
            // lblPoints2
            // 
            this.lblPoints2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPoints2.AutoSize = true;
            this.lblPoints2.Location = new System.Drawing.Point(852, 63);
            this.lblPoints2.Name = "lblPoints2";
            this.lblPoints2.Size = new System.Drawing.Size(19, 21);
            this.lblPoints2.TabIndex = 0;
            this.lblPoints2.Text = "0";
            // 
            // lblPoints1
            // 
            this.lblPoints1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPoints1.AutoSize = true;
            this.lblPoints1.Location = new System.Drawing.Point(198, 63);
            this.lblPoints1.Name = "lblPoints1";
            this.lblPoints1.Size = new System.Drawing.Size(19, 21);
            this.lblPoints1.TabIndex = 0;
            this.lblPoints1.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(692, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "TIME p2";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "TIME p1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "TIME";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(946, 63);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(60, 21);
            this.lblPlayer2.TabIndex = 0;
            this.lblPlayer2.Text = "label1";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(61, 63);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(60, 21);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "label1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(933, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLAYER 1";
            // 
            // grpTranslation
            // 
            this.grpTranslation.BackColor = System.Drawing.Color.Gray;
            this.grpTranslation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpTranslation.ForeColor = System.Drawing.Color.White;
            this.grpTranslation.Location = new System.Drawing.Point(0, 385);
            this.grpTranslation.Name = "grpTranslation";
            this.grpTranslation.Size = new System.Drawing.Size(1078, 212);
            this.grpTranslation.TabIndex = 1;
            this.grpTranslation.TabStop = false;
            this.grpTranslation.Text = "Translated Word";
            // 
            // grpWord
            // 
            this.grpWord.BackColor = System.Drawing.Color.DimGray;
            this.grpWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpWord.ForeColor = System.Drawing.Color.White;
            this.grpWord.Location = new System.Drawing.Point(0, 140);
            this.grpWord.Name = "grpWord";
            this.grpWord.Size = new System.Drawing.Size(1078, 229);
            this.grpWord.TabIndex = 1;
            this.grpWord.TabStop = false;
            this.grpWord.Text = "English Word";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerPlayer1
            // 
            this.timerPlayer1.Tick += new System.EventHandler(this.timerPlayer1_Tick);
            // 
            // timerPlayer2
            // 
            this.timerPlayer2.Tick += new System.EventHandler(this.timerPlayer2_Tick);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 597);
            this.Controls.Add(this.grpTranslation);
            this.Controls.Add(this.grpWord);
            this.Controls.Add(this.grpStat);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.grpStat.ResumeLayout(false);
            this.grpStat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpStat;
        private System.Windows.Forms.GroupBox grpTranslation;
        private System.Windows.Forms.GroupBox grpWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPoints1;
        private System.Windows.Forms.Label lblTimeP2;
        private System.Windows.Forms.Label lblTimeP1;
        private System.Windows.Forms.Label lblPoints2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerPlayer1;
        private System.Windows.Forms.Timer timerPlayer2;
    }
}