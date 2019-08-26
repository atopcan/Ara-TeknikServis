namespace PcTeknikServis
{
    partial class Fatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatura));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.madDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uaciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSDmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSDfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaSATISBinding = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new PcTeknikServis.dbDataSet();
            this.fATURASATISTableAdapter = new PcTeknikServis.dbDataSetTableAdapters.FATURASATISTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.madDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msoyadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sikayetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet1 = new PcTeknikServis.dbDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.fATURATAMIRTableAdapter = new PcTeknikServis.dbDataSet1TableAdapters.FATURATAMIRTableAdapter();
            this.lblstoplam = new System.Windows.Forms.Label();
            this.lblftoplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaSATISBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madDataGridViewTextBoxColumn,
            this.msoyadDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.markaAdiDataGridViewTextBoxColumn,
            this.uaciklamaDataGridViewTextBoxColumn,
            this.fSDmiktarDataGridViewTextBoxColumn,
            this.fSDfiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.faturaSATISBinding;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // madDataGridViewTextBoxColumn
            // 
            this.madDataGridViewTextBoxColumn.DataPropertyName = "Mad";
            this.madDataGridViewTextBoxColumn.HeaderText = "Mad";
            this.madDataGridViewTextBoxColumn.Name = "madDataGridViewTextBoxColumn";
            this.madDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // msoyadDataGridViewTextBoxColumn
            // 
            this.msoyadDataGridViewTextBoxColumn.DataPropertyName = "Msoyad";
            this.msoyadDataGridViewTextBoxColumn.HeaderText = "Msoyad";
            this.msoyadDataGridViewTextBoxColumn.Name = "msoyadDataGridViewTextBoxColumn";
            this.msoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markaAdiDataGridViewTextBoxColumn
            // 
            this.markaAdiDataGridViewTextBoxColumn.DataPropertyName = "MarkaAdi";
            this.markaAdiDataGridViewTextBoxColumn.HeaderText = "MarkaAdi";
            this.markaAdiDataGridViewTextBoxColumn.Name = "markaAdiDataGridViewTextBoxColumn";
            this.markaAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uaciklamaDataGridViewTextBoxColumn
            // 
            this.uaciklamaDataGridViewTextBoxColumn.DataPropertyName = "Uaciklama";
            this.uaciklamaDataGridViewTextBoxColumn.HeaderText = "Uaciklama";
            this.uaciklamaDataGridViewTextBoxColumn.Name = "uaciklamaDataGridViewTextBoxColumn";
            this.uaciklamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fSDmiktarDataGridViewTextBoxColumn
            // 
            this.fSDmiktarDataGridViewTextBoxColumn.DataPropertyName = "FSDmiktar";
            this.fSDmiktarDataGridViewTextBoxColumn.HeaderText = "FSDmiktar";
            this.fSDmiktarDataGridViewTextBoxColumn.Name = "fSDmiktarDataGridViewTextBoxColumn";
            this.fSDmiktarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fSDfiyatDataGridViewTextBoxColumn
            // 
            this.fSDfiyatDataGridViewTextBoxColumn.DataPropertyName = "FSDfiyat";
            this.fSDfiyatDataGridViewTextBoxColumn.HeaderText = "FSDfiyat";
            this.fSDfiyatDataGridViewTextBoxColumn.Name = "fSDfiyatDataGridViewTextBoxColumn";
            this.fSDfiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faturaSATISBinding
            // 
            this.faturaSATISBinding.DataMember = "FATURASATIS";
            this.faturaSATISBinding.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fATURASATISTableAdapter
            // 
            this.fATURASATISTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOPLAM";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madDataGridViewTextBoxColumn1,
            this.msoyadDataGridViewTextBoxColumn1,
            this.tarihDataGridViewTextBoxColumn1,
            this.teslimTarihDataGridViewTextBoxColumn,
            this.sikayetDataGridViewTextBoxColumn,
            this.islemDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 262);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(747, 187);
            this.dataGridView2.TabIndex = 2;
            // 
            // madDataGridViewTextBoxColumn1
            // 
            this.madDataGridViewTextBoxColumn1.DataPropertyName = "Mad";
            this.madDataGridViewTextBoxColumn1.HeaderText = "Mad";
            this.madDataGridViewTextBoxColumn1.Name = "madDataGridViewTextBoxColumn1";
            this.madDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // msoyadDataGridViewTextBoxColumn1
            // 
            this.msoyadDataGridViewTextBoxColumn1.DataPropertyName = "Msoyad";
            this.msoyadDataGridViewTextBoxColumn1.HeaderText = "Msoyad";
            this.msoyadDataGridViewTextBoxColumn1.Name = "msoyadDataGridViewTextBoxColumn1";
            this.msoyadDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn1
            // 
            this.tarihDataGridViewTextBoxColumn1.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn1.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn1.Name = "tarihDataGridViewTextBoxColumn1";
            this.tarihDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // teslimTarihDataGridViewTextBoxColumn
            // 
            this.teslimTarihDataGridViewTextBoxColumn.DataPropertyName = "TeslimTarih";
            this.teslimTarihDataGridViewTextBoxColumn.HeaderText = "TeslimTarih";
            this.teslimTarihDataGridViewTextBoxColumn.Name = "teslimTarihDataGridViewTextBoxColumn";
            this.teslimTarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sikayetDataGridViewTextBoxColumn
            // 
            this.sikayetDataGridViewTextBoxColumn.DataPropertyName = "Sikayet";
            this.sikayetDataGridViewTextBoxColumn.HeaderText = "Sikayet";
            this.sikayetDataGridViewTextBoxColumn.Name = "sikayetDataGridViewTextBoxColumn";
            this.sikayetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // islemDataGridViewTextBoxColumn
            // 
            this.islemDataGridViewTextBoxColumn.DataPropertyName = "Islem";
            this.islemDataGridViewTextBoxColumn.HeaderText = "Islem";
            this.islemDataGridViewTextBoxColumn.Name = "islemDataGridViewTextBoxColumn";
            this.islemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "Ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "Ucret";
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            this.ucretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "FATURATAMIR";
            this.bindingSource1.DataSource = this.dbDataSet1;
            // 
            // dbDataSet1
            // 
            this.dbDataSet1.DataSetName = "dbDataSet1";
            this.dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TOPLAM";
            // 
            // fATURATAMIRTableAdapter
            // 
            this.fATURATAMIRTableAdapter.ClearBeforeFill = true;
            // 
            // lblstoplam
            // 
            this.lblstoplam.AutoSize = true;
            this.lblstoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstoplam.ForeColor = System.Drawing.Color.Red;
            this.lblstoplam.Location = new System.Drawing.Point(66, 215);
            this.lblstoplam.Name = "lblstoplam";
            this.lblstoplam.Size = new System.Drawing.Size(0, 13);
            this.lblstoplam.TabIndex = 4;
            // 
            // lblftoplam
            // 
            this.lblftoplam.AutoSize = true;
            this.lblftoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblftoplam.ForeColor = System.Drawing.Color.Red;
            this.lblftoplam.Location = new System.Drawing.Point(66, 452);
            this.lblftoplam.Name = "lblftoplam";
            this.lblftoplam.Size = new System.Drawing.Size(0, 13);
            this.lblftoplam.TabIndex = 5;
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(869, 474);
            this.Controls.Add(this.lblftoplam);
            this.Controls.Add(this.lblstoplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.Fatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaSATISBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource faturaSATISBinding;
        private dbDataSet dbDataSet;
        private dbDataSetTableAdapters.FATURASATISTableAdapter fATURASATISTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn madDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uaciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSDmiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSDfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private dbDataSet1 dbDataSet1;
        private dbDataSet1TableAdapters.FATURATAMIRTableAdapter fATURATAMIRTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn madDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn msoyadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sikayetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblstoplam;
        private System.Windows.Forms.Label lblftoplam;
    }
}