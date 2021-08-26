namespace cihazTakip
{
    partial class dokumanDuzenle
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataDokuman = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dokumanEkle = new System.Windows.Forms.Button();
            this.dokumanGuncelle = new System.Windows.Forms.Button();
            this.dokumanSil = new System.Windows.Forms.Button();
            this.txtDokumanAra = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDokuman)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.dataDokuman, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDokumanAra, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 276);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataDokuman
            // 
            this.dataDokuman.AllowUserToAddRows = false;
            this.dataDokuman.AllowUserToDeleteRows = false;
            this.dataDokuman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDokuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDokuman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDokuman.Location = new System.Drawing.Point(247, 0);
            this.dataDokuman.Margin = new System.Windows.Forms.Padding(0);
            this.dataDokuman.Name = "dataDokuman";
            this.dataDokuman.ReadOnly = true;
            this.dataDokuman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDokuman.Size = new System.Drawing.Size(247, 138);
            this.dataDokuman.TabIndex = 0;
            this.dataDokuman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDokuman_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.dokumanEkle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dokumanGuncelle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dokumanSil, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(247, 179);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 41);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dokumanEkle
            // 
            this.dokumanEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dokumanEkle.Location = new System.Drawing.Point(0, 0);
            this.dokumanEkle.Margin = new System.Windows.Forms.Padding(0);
            this.dokumanEkle.Name = "dokumanEkle";
            this.dokumanEkle.Size = new System.Drawing.Size(82, 41);
            this.dokumanEkle.TabIndex = 0;
            this.dokumanEkle.Text = "Ekle";
            this.dokumanEkle.UseVisualStyleBackColor = true;
            this.dokumanEkle.Click += new System.EventHandler(this.dokumanEkle_Click);
            // 
            // dokumanGuncelle
            // 
            this.dokumanGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dokumanGuncelle.Location = new System.Drawing.Point(82, 0);
            this.dokumanGuncelle.Margin = new System.Windows.Forms.Padding(0);
            this.dokumanGuncelle.Name = "dokumanGuncelle";
            this.dokumanGuncelle.Size = new System.Drawing.Size(82, 41);
            this.dokumanGuncelle.TabIndex = 1;
            this.dokumanGuncelle.Text = "Güncelle";
            this.dokumanGuncelle.UseVisualStyleBackColor = true;
            this.dokumanGuncelle.Click += new System.EventHandler(this.dokumanGuncelle_Click);
            // 
            // dokumanSil
            // 
            this.dokumanSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dokumanSil.Location = new System.Drawing.Point(164, 0);
            this.dokumanSil.Margin = new System.Windows.Forms.Padding(0);
            this.dokumanSil.Name = "dokumanSil";
            this.dokumanSil.Size = new System.Drawing.Size(83, 41);
            this.dokumanSil.TabIndex = 2;
            this.dokumanSil.Text = "Sil";
            this.dokumanSil.UseVisualStyleBackColor = true;
            this.dokumanSil.Click += new System.EventHandler(this.dokumanSil_Click);
            // 
            // txtDokumanAra
            // 
            this.txtDokumanAra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDokumanAra.Location = new System.Drawing.Point(250, 141);
            this.txtDokumanAra.Name = "txtDokumanAra";
            this.txtDokumanAra.Size = new System.Drawing.Size(241, 20);
            this.txtDokumanAra.TabIndex = 2;
            // 
            // dokumanDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 276);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dokumanDuzenle";
            this.Text = "dokumanDuzenle";
            this.Load += new System.EventHandler(this.dokumanDuzenle_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDokuman)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataDokuman;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Button dokumanEkle;
        public System.Windows.Forms.Button dokumanGuncelle;
        public System.Windows.Forms.Button dokumanSil;
        public System.Windows.Forms.TextBox txtDokumanAra;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}