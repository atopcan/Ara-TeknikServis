namespace PcTeknikServis
{
    partial class Satis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satis));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uaciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ustokmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunlerBinding = new System.Windows.Forms.BindingSource(this.components);
            this.urunDataSet = new PcTeknikServis.urunDataSet();
            this.uRUN_TABLETableAdapter = new PcTeknikServis.urunDataSetTableAdapters.URUN_TABLETableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUrunTip = new System.Windows.Forms.ComboBox();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOnay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHesap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uidDataGridViewTextBoxColumn,
            this.markaAdiDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.uaciklamaDataGridViewTextBoxColumn,
            this.ustokmiktarDataGridViewTextBoxColumn,
            this.ufiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunlerBinding;
            this.dataGridView1.Location = new System.Drawing.Point(1, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // uidDataGridViewTextBoxColumn
            // 
            this.uidDataGridViewTextBoxColumn.DataPropertyName = "Uid";
            this.uidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
            this.uidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markaAdiDataGridViewTextBoxColumn
            // 
            this.markaAdiDataGridViewTextBoxColumn.DataPropertyName = "MarkaAdi";
            this.markaAdiDataGridViewTextBoxColumn.HeaderText = "MARKA";
            this.markaAdiDataGridViewTextBoxColumn.Name = "markaAdiDataGridViewTextBoxColumn";
            this.markaAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "TİPİ";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uaciklamaDataGridViewTextBoxColumn
            // 
            this.uaciklamaDataGridViewTextBoxColumn.DataPropertyName = "Uaciklama";
            this.uaciklamaDataGridViewTextBoxColumn.HeaderText = "AÇIKLAMA";
            this.uaciklamaDataGridViewTextBoxColumn.Name = "uaciklamaDataGridViewTextBoxColumn";
            this.uaciklamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ustokmiktarDataGridViewTextBoxColumn
            // 
            this.ustokmiktarDataGridViewTextBoxColumn.DataPropertyName = "Ustokmiktar";
            this.ustokmiktarDataGridViewTextBoxColumn.HeaderText = "S.MİKAR";
            this.ustokmiktarDataGridViewTextBoxColumn.Name = "ustokmiktarDataGridViewTextBoxColumn";
            this.ustokmiktarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ufiyatDataGridViewTextBoxColumn
            // 
            this.ufiyatDataGridViewTextBoxColumn.DataPropertyName = "Ufiyat";
            this.ufiyatDataGridViewTextBoxColumn.HeaderText = "FİYAT";
            this.ufiyatDataGridViewTextBoxColumn.Name = "ufiyatDataGridViewTextBoxColumn";
            this.ufiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunlerBinding
            // 
            this.urunlerBinding.DataMember = "URUN_TABLE";
            this.urunlerBinding.DataSource = this.urunDataSet;
            // 
            // urunDataSet
            // 
            this.urunDataSet.DataSetName = "urunDataSet";
            this.urunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uRUN_TABLETableAdapter
            // 
            this.uRUN_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(247, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Tipi";
            // 
            // cbUrunTip
            // 
            this.cbUrunTip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbUrunTip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUrunTip.FormattingEnabled = true;
            this.cbUrunTip.Location = new System.Drawing.Point(320, 40);
            this.cbUrunTip.Name = "cbUrunTip";
            this.cbUrunTip.Size = new System.Drawing.Size(121, 21);
            this.cbUrunTip.TabIndex = 3;
            this.cbUrunTip.SelectedIndexChanged += new System.EventHandler(this.cbUrunTip_SelectedIndexChanged);
            this.cbUrunTip.SelectedValueChanged += new System.EventHandler(this.cbUrunTip_SelectedValueChanged);
            // 
            // cbMarka
            // 
            this.cbMarka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbMarka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(320, 81);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(121, 21);
            this.cbMarka.TabIndex = 5;
            this.cbMarka.SelectedValueChanged += new System.EventHandler(this.cbMarka_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(247, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka";
            // 
            // cbModel
            // 
            this.cbModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(320, 120);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(121, 21);
            this.cbModel.TabIndex = 7;
            this.cbModel.SelectedValueChanged += new System.EventHandler(this.cbModel_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(247, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(247, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Miktar";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(320, 166);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(50, 20);
            this.txtMiktar.TabIndex = 11;
            this.txtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(302, 3);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(139, 31);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Tümünü Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIptal.BackgroundImage")));
            this.btnIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIptal.Location = new System.Drawing.Point(559, 195);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 65);
            this.btnIptal.TabIndex = 14;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOnay
            // 
            this.btnOnay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnay.BackgroundImage")));
            this.btnOnay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnay.Location = new System.Drawing.Point(478, 196);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(75, 65);
            this.btnOnay.TabIndex = 13;
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(376, 163);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(65, 23);
            this.btnHesap.TabIndex = 15;
            this.btnHesap.Text = "HESAPLA";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(247, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tutar(TL)";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.Color.Red;
            this.lblTutar.Location = new System.Drawing.Point(320, 220);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(0, 17);
            this.lblTutar.TabIndex = 17;
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(646, 474);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUrunTip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Satış";
            this.Load += new System.EventHandler(this.Satis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource urunlerBinding;
        private urunDataSet urunDataSet;
        private urunDataSetTableAdapters.URUN_TABLETableAdapter uRUN_TABLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uaciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ustokmiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUrunTip;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTutar;
    }
}