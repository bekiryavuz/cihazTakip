namespace cihazTakip
{
    partial class cihazTeslim
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butonTutanak = new System.Windows.Forms.Button();
            this.butonMail = new System.Windows.Forms.Button();
            this.textMailAdresi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cihazbtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihaz_marka_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazisyeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazgelisnedeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazyapilanisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihaz_gelis_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazTeslimBilgilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cihazTeslimBilgilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(737, 270);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.88889F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.88889F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.88889F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.butonTutanak, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.butonMail, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textMailAdresi, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(737, 27);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // butonTutanak
            // 
            this.butonTutanak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butonTutanak.Location = new System.Drawing.Point(319, 0);
            this.butonTutanak.Margin = new System.Windows.Forms.Padding(0);
            this.butonTutanak.Name = "butonTutanak";
            this.butonTutanak.Size = new System.Drawing.Size(139, 27);
            this.butonTutanak.TabIndex = 1;
            this.butonTutanak.Text = "Önizle/Yazdır";
            this.butonTutanak.UseVisualStyleBackColor = true;
            this.butonTutanak.Click += new System.EventHandler(this.butonTutanak_Click);
            // 
            // butonMail
            // 
            this.butonMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butonMail.Location = new System.Drawing.Point(597, 0);
            this.butonMail.Margin = new System.Windows.Forms.Padding(0);
            this.butonMail.Name = "butonMail";
            this.butonMail.Size = new System.Drawing.Size(140, 27);
            this.butonMail.TabIndex = 2;
            this.butonMail.Text = "Mail Gönder";
            this.butonMail.UseVisualStyleBackColor = true;
            this.butonMail.Click += new System.EventHandler(this.butonMail_Click);
            // 
            // textMailAdresi
            // 
            this.textMailAdresi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMailAdresi.Location = new System.Drawing.Point(458, 0);
            this.textMailAdresi.Margin = new System.Windows.Forms.Padding(0);
            this.textMailAdresi.Name = "textMailAdresi";
            this.textMailAdresi.Size = new System.Drawing.Size(139, 20);
            this.textMailAdresi.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cihazbtDataGridViewTextBoxColumn,
            this.cihaz_marka_adi,
            this.cihazisyeriDataGridViewTextBoxColumn,
            this.cihazgelisnedeniDataGridViewTextBoxColumn,
            this.cihazyapilanisDataGridViewTextBoxColumn,
            this.cihaz_gelis_tarihi});
            this.dataGridView1.DataSource = this.cihazTeslimBilgilerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 243);
            this.dataGridView1.TabIndex = 1;
            // 
            // cihazbtDataGridViewTextBoxColumn
            // 
            this.cihazbtDataGridViewTextBoxColumn.DataPropertyName = "cihaz_bt";
            this.cihazbtDataGridViewTextBoxColumn.HeaderText = "Bt Numarası";
            this.cihazbtDataGridViewTextBoxColumn.Name = "cihazbtDataGridViewTextBoxColumn";
            this.cihazbtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cihaz_marka_adi
            // 
            this.cihaz_marka_adi.DataPropertyName = "cihaz_marka_adi";
            this.cihaz_marka_adi.HeaderText = "Marka Adı";
            this.cihaz_marka_adi.Name = "cihaz_marka_adi";
            this.cihaz_marka_adi.ReadOnly = true;
            // 
            // cihazisyeriDataGridViewTextBoxColumn
            // 
            this.cihazisyeriDataGridViewTextBoxColumn.DataPropertyName = "cihaz_isyeri";
            this.cihazisyeriDataGridViewTextBoxColumn.HeaderText = "İşyeri";
            this.cihazisyeriDataGridViewTextBoxColumn.Name = "cihazisyeriDataGridViewTextBoxColumn";
            this.cihazisyeriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cihazgelisnedeniDataGridViewTextBoxColumn
            // 
            this.cihazgelisnedeniDataGridViewTextBoxColumn.DataPropertyName = "cihaz_gelis_nedeni";
            this.cihazgelisnedeniDataGridViewTextBoxColumn.HeaderText = "Geliş Nedeni";
            this.cihazgelisnedeniDataGridViewTextBoxColumn.Name = "cihazgelisnedeniDataGridViewTextBoxColumn";
            this.cihazgelisnedeniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cihazyapilanisDataGridViewTextBoxColumn
            // 
            this.cihazyapilanisDataGridViewTextBoxColumn.DataPropertyName = "cihaz_yapilan_is";
            this.cihazyapilanisDataGridViewTextBoxColumn.HeaderText = "Yapılan iş";
            this.cihazyapilanisDataGridViewTextBoxColumn.Name = "cihazyapilanisDataGridViewTextBoxColumn";
            this.cihazyapilanisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cihaz_gelis_tarihi
            // 
            this.cihaz_gelis_tarihi.DataPropertyName = "cihaz_gelis_tarihi";
            this.cihaz_gelis_tarihi.HeaderText = "Geliş Tarihi";
            this.cihaz_gelis_tarihi.Name = "cihaz_gelis_tarihi";
            this.cihaz_gelis_tarihi.ReadOnly = true;
            // 
            // cihazTeslimBilgilerBindingSource
            // 
            this.cihazTeslimBilgilerBindingSource.DataSource = typeof(cihazTakip.cihazTeslimBilgiler);
            // 
            // cihazTeslim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 270);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cihazTeslim";
            this.Text = "cihazTeslim";
            this.Load += new System.EventHandler(this.cihazTeslim_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cihazTeslimBilgilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button butonTutanak;
        public System.Windows.Forms.Button butonMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn btNumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazMarkaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelisNedeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yapilanislemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazGelisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cihazTeslimBilgilerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazmarkaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazgelistarihiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazbtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihaz_marka_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazisyeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazgelisnedeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazyapilanisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihaz_gelis_tarihi;
        private System.Windows.Forms.TextBox textMailAdresi;
    }
}