namespace LanguageTrainer
{
    partial class frmChooseOpponent
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
            this.grpChoose = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.rdoEng2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoEng1 = new System.Windows.Forms.RadioButton();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChoose
            // 
            this.grpChoose.BackColor = System.Drawing.Color.DimGray;
            this.grpChoose.Location = new System.Drawing.Point(12, 12);
            this.grpChoose.Name = "grpChoose";
            this.grpChoose.Size = new System.Drawing.Size(629, 319);
            this.grpChoose.TabIndex = 0;
            this.grpChoose.TabStop = false;
            this.grpChoose.Text = "Choose An Opponent";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(489, 540);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(130, 52);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(343, 540);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(130, 52);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // rdoEng2
            // 
            this.rdoEng2.AutoSize = true;
            this.rdoEng2.ForeColor = System.Drawing.Color.White;
            this.rdoEng2.Location = new System.Drawing.Point(26, 83);
            this.rdoEng2.Name = "rdoEng2";
            this.rdoEng2.Size = new System.Drawing.Size(205, 27);
            this.rdoEng2.TabIndex = 0;
            this.rdoEng2.TabStop = true;
            this.rdoEng2.Text = "English To Chinese";
            this.rdoEng2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.rdoEng1);
            this.groupBox1.Controls.Add(this.rdoEng2);
            this.groupBox1.Location = new System.Drawing.Point(11, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose A Word Set";
            // 
            // rdoEng1
            // 
            this.rdoEng1.AutoSize = true;
            this.rdoEng1.ForeColor = System.Drawing.Color.White;
            this.rdoEng1.Location = new System.Drawing.Point(26, 41);
            this.rdoEng1.Name = "rdoEng1";
            this.rdoEng1.Size = new System.Drawing.Size(192, 27);
            this.rdoEng1.TabIndex = 0;
            this.rdoEng1.TabStop = true;
            this.rdoEng1.Text = "English To Nepali";
            this.rdoEng1.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(33, 555);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 23);
            this.lblError.TabIndex = 3;
            // 
            // frmChooseOpponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(652, 648);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grpChoose);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChooseOpponent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Opponent";
            this.Load += new System.EventHandler(this.frmChooseOpponent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChoose;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.RadioButton rdoEng2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoEng1;
        private System.Windows.Forms.Label lblError;
    }
}