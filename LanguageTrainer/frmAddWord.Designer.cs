namespace LanguageTrainer
{
    partial class frmAddWord
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoEngB = new System.Windows.Forms.RadioButton();
            this.rdoEngA = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAddWords = new System.Windows.Forms.DataGridView();
            this.wordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddWords)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.rdoEngB);
            this.groupBox1.Controls.Add(this.rdoEngA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTranslation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWord);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(822, 157);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Words";
            // 
            // rdoEngB
            // 
            this.rdoEngB.AutoSize = true;
            this.rdoEngB.ForeColor = System.Drawing.Color.White;
            this.rdoEngB.Location = new System.Drawing.Point(423, 108);
            this.rdoEngB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoEngB.Name = "rdoEngB";
            this.rdoEngB.Size = new System.Drawing.Size(178, 25);
            this.rdoEngB.TabIndex = 3;
            this.rdoEngB.TabStop = true;
            this.rdoEngB.Text = "English to Chinese";
            this.rdoEngB.UseVisualStyleBackColor = true;
            // 
            // rdoEngA
            // 
            this.rdoEngA.AutoSize = true;
            this.rdoEngA.ForeColor = System.Drawing.Color.White;
            this.rdoEngA.Location = new System.Drawing.Point(223, 110);
            this.rdoEngA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoEngA.Name = "rdoEngA";
            this.rdoEngA.Size = new System.Drawing.Size(167, 25);
            this.rdoEngA.TabIndex = 3;
            this.rdoEngA.TabStop = true;
            this.rdoEngA.Text = "English To Nepali";
            this.rdoEngA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(419, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Translation:";
            // 
            // txtTranslation
            // 
            this.txtTranslation.Location = new System.Drawing.Point(556, 40);
            this.txtTranslation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.Size = new System.Drawing.Size(249, 28);
            this.txtTranslation.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose Word Set:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word:";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(112, 40);
            this.txtWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(249, 28);
            this.txtWord.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(45, 219);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 23);
            this.lblError.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(507, 219);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 52);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(683, 219);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 52);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAddWords
            // 
            this.dgvAddWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordID,
            this.word,
            this.translation,
            this.wordSet,
            this.Edit,
            this.Delete});
            this.dgvAddWords.Location = new System.Drawing.Point(127, 322);
            this.dgvAddWords.Name = "dgvAddWords";
            this.dgvAddWords.RowTemplate.Height = 24;
            this.dgvAddWords.Size = new System.Drawing.Size(578, 242);
            this.dgvAddWords.TabIndex = 8;
            this.dgvAddWords.Click += new System.EventHandler(this.dgvAddWords_Click);
            // 
            // wordID
            // 
            this.wordID.DataPropertyName = "wordID";
            this.wordID.HeaderText = "Word ID";
            this.wordID.Name = "wordID";
            this.wordID.Visible = false;
            // 
            // word
            // 
            this.word.DataPropertyName = "word";
            this.word.HeaderText = "Word";
            this.word.Name = "word";
            // 
            // translation
            // 
            this.translation.DataPropertyName = "translation";
            this.translation.HeaderText = "Translation";
            this.translation.Name = "translation";
            // 
            // wordSet
            // 
            this.wordSet.DataPropertyName = "wordSet";
            this.wordSet.HeaderText = "Word Set";
            this.wordSet.Name = "wordSet";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // frmAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(852, 591);
            this.Controls.Add(this.dgvAddWords);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAddWord";
            this.Text = "frmAddWord";
            this.Load += new System.EventHandler(this.frmAddWord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoEngB;
        private System.Windows.Forms.RadioButton rdoEngA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAddWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn word;
        private System.Windows.Forms.DataGridViewTextBoxColumn translation;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordSet;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}