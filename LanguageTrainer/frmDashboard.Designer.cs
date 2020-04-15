namespace LanguageTrainer
{
    partial class frmDashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.btnAddWords = new System.Windows.Forms.Button();
            this.btnaAddPlayers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Viner Hand ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(134, 68);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(111, 53);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnPlayGame);
            this.panel1.Controls.Add(this.btnAddWords);
            this.panel1.Controls.Add(this.btnaAddPlayers);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 663);
            this.panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Viner Hand ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(102, 514);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(304, 83);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayGame.FlatAppearance.BorderSize = 0;
            this.btnPlayGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayGame.Font = new System.Drawing.Font("Viner Hand ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayGame.ForeColor = System.Drawing.Color.White;
            this.btnPlayGame.Location = new System.Drawing.Point(102, 167);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(304, 76);
            this.btnPlayGame.TabIndex = 1;
            this.btnPlayGame.Text = "Play Game";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // btnAddWords
            // 
            this.btnAddWords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddWords.FlatAppearance.BorderSize = 0;
            this.btnAddWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWords.Font = new System.Drawing.Font("Viner Hand ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWords.ForeColor = System.Drawing.Color.White;
            this.btnAddWords.Location = new System.Drawing.Point(102, 403);
            this.btnAddWords.Name = "btnAddWords";
            this.btnAddWords.Size = new System.Drawing.Size(304, 83);
            this.btnAddWords.TabIndex = 1;
            this.btnAddWords.Text = "Add Words";
            this.btnAddWords.UseVisualStyleBackColor = true;
            this.btnAddWords.Click += new System.EventHandler(this.btnAddWords_Click);
            // 
            // btnaAddPlayers
            // 
            this.btnaAddPlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaAddPlayers.FlatAppearance.BorderSize = 0;
            this.btnaAddPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaAddPlayers.Font = new System.Drawing.Font("Viner Hand ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaAddPlayers.ForeColor = System.Drawing.Color.White;
            this.btnaAddPlayers.Location = new System.Drawing.Point(102, 281);
            this.btnaAddPlayers.Name = "btnaAddPlayers";
            this.btnaAddPlayers.Size = new System.Drawing.Size(304, 81);
            this.btnaAddPlayers.TabIndex = 1;
            this.btnaAddPlayers.Text = "Add Players";
            this.btnaAddPlayers.UseVisualStyleBackColor = true;
            this.btnaAddPlayers.Click += new System.EventHandler(this.btnaAddPlayers_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(538, 685);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Button btnAddWords;
        private System.Windows.Forms.Button btnaAddPlayers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
    }
}