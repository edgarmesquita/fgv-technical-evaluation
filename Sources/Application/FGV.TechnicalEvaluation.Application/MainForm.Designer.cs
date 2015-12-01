namespace FGV.TechnicalEvaluation.Application
{
    partial class MainForm
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditionYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectXmlFile = new System.Windows.Forms.Button();
            this.lblLoadXml = new System.Windows.Forms.Label();
            this.tbXmlPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOrderedBooks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToResizeRows = false;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.AuthorName,
            this.EditionYear});
            this.dgvBooks.Location = new System.Drawing.Point(12, 82);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.Size = new System.Drawing.Size(500, 142);
            this.dgvBooks.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Título";
            this.Title.Name = "Title";
            this.Title.Width = 60;
            // 
            // AuthorName
            // 
            this.AuthorName.DataPropertyName = "AuthorName";
            this.AuthorName.HeaderText = "Autor";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Width = 57;
            // 
            // EditionYear
            // 
            this.EditionYear.DataPropertyName = "EditionYear";
            this.EditionYear.HeaderText = "Edição";
            this.EditionYear.Name = "EditionYear";
            this.EditionYear.Width = 65;
            // 
            // btnSelectXmlFile
            // 
            this.btnSelectXmlFile.Location = new System.Drawing.Point(299, 22);
            this.btnSelectXmlFile.Name = "btnSelectXmlFile";
            this.btnSelectXmlFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectXmlFile.TabIndex = 9;
            this.btnSelectXmlFile.Text = "Selecionar...";
            this.btnSelectXmlFile.UseVisualStyleBackColor = true;
            this.btnSelectXmlFile.Click += new System.EventHandler(this.btnSelectXmlFile_Click);
            // 
            // lblLoadXml
            // 
            this.lblLoadXml.AutoSize = true;
            this.lblLoadXml.Location = new System.Drawing.Point(12, 8);
            this.lblLoadXml.Name = "lblLoadXml";
            this.lblLoadXml.Size = new System.Drawing.Size(213, 13);
            this.lblLoadXml.TabIndex = 8;
            this.lblLoadXml.Text = "Carregue uma lista de livros a ser ordenada:";
            // 
            // tbXmlPath
            // 
            this.tbXmlPath.Location = new System.Drawing.Point(12, 24);
            this.tbXmlPath.Name = "tbXmlPath";
            this.tbXmlPath.Size = new System.Drawing.Size(281, 20);
            this.tbXmlPath.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lista original:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lista ordenada:";
            // 
            // dgvOrderedBooks
            // 
            this.dgvOrderedBooks.AllowUserToAddRows = false;
            this.dgvOrderedBooks.AllowUserToDeleteRows = false;
            this.dgvOrderedBooks.AllowUserToResizeRows = false;
            this.dgvOrderedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvOrderedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvOrderedBooks.Location = new System.Drawing.Point(12, 254);
            this.dgvOrderedBooks.Name = "dgvOrderedBooks";
            this.dgvOrderedBooks.RowHeadersVisible = false;
            this.dgvOrderedBooks.Size = new System.Drawing.Size(500, 142);
            this.dgvOrderedBooks.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Título";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AuthorName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 57;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EditionYear";
            this.dataGridViewTextBoxColumn3.HeaderText = "Edição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 65;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 414);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOrderedBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectXmlFile);
            this.Controls.Add(this.lblLoadXml);
            this.Controls.Add(this.tbXmlPath);
            this.Controls.Add(this.dgvBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FGV Technical Evaluation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditionYear;
        private System.Windows.Forms.Button btnSelectXmlFile;
        private System.Windows.Forms.Label lblLoadXml;
        private System.Windows.Forms.TextBox tbXmlPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvOrderedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

