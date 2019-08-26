namespace PcTeknikServis
{
    partial class Teknik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teknik));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIslem = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.tamirBinding = new System.Windows.Forms.BindingSource(this.components);
            this.tamirDataSet = new PcTeknikServis.tamirDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOnay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.madDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sikayetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTDidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAMIR_TABLETableAdapter = new PcTeknikServis.tamirDataSetTableAdapters.TAMIR_TABLETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamirBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-73, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(355, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uygulanan İşlem";
            // 
            // txtIslem
            // 
            this.txtIslem.Location = new System.Drawing.Point(358, 148);
            this.txtIslem.Multiline = true;
            this.txtIslem.Name = "txtIslem";
            this.txtIslem.Size = new System.Drawing.Size(176, 103);
            this.txtIslem.TabIndex = 3;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(434, 275);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(100, 20);
            this.txtUcret.TabIndex = 7;
            this.txtUcret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUcret_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(382, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ücret";
            // 
            // txtSikayet
            // 
            this.txtSikayet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tamirBinding, "Sikayet", true));
            this.txtSikayet.Location = new System.Drawing.Point(358, 24);
            this.txtSikayet.Multiline = true;
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(176, 94);
            this.txtSikayet.TabIndex = 11;
            // 
            // tamirBinding
            // 
            this.tamirBinding.DataMember = "TAMIR_TABLE";
            this.tamirBinding.DataSource = this.tamirDataSet;
            // 
            // tamirDataSet
            // 
            this.tamirDataSet.DataSetName = "tamirDataSet";
            this.tamirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(355, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şikayet";
            // 
            // btnIptal
            // 
            this.btnIptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIptal.BackgroundImage")));
            this.btnIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIptal.Location = new System.Drawing.Point(559, 227);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 65);
            this.btnIptal.TabIndex = 16;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOnay
            // 
            this.btnOnay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnay.BackgroundImage")));
            this.btnOnay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnay.Location = new System.Drawing.Point(559, 148);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(75, 65);
            this.btnOnay.TabIndex = 15;
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madDataGridViewTextBoxColumn,
            this.msoyadDataGridViewTextBoxColumn,
            this.sikayetDataGridViewTextBoxColumn,
            this.islemDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.fTDidDataGridViewTextBoxColumn,
            this.fidDataGridViewTextBoxColumn,
            this.ftipiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tamirBinding;
            this.dataGridView1.Location = new System.Drawing.Point(2, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(919, 161);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // madDataGridViewTextBoxColumn
            // 
            this.madDataGridViewTextBoxColumn.DataPropertyName = "Mad";
            this.madDataGridViewTextBoxColumn.HeaderText = "AD";
            this.madDataGridViewTextBoxColumn.Name = "madDataGridViewTextBoxColumn";
            this.madDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // msoyadDataGridViewTextBoxColumn
            // 
            this.msoyadDataGridViewTextBoxColumn.DataPropertyName = "Msoyad";
            this.msoyadDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.msoyadDataGridViewTextBoxColumn.Name = "msoyadDataGridViewTextBoxColumn";
            this.msoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sikayetDataGridViewTextBoxColumn
            // 
            this.sikayetDataGridViewTextBoxColumn.DataPropertyName = "Sikayet";
            this.sikayetDataGridViewTextBoxColumn.HeaderText = "ŞİKAYET";
            this.sikayetDataGridViewTextBoxColumn.Name = "sikayetDataGridViewTextBoxColumn";
            this.sikayetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // islemDataGridViewTextBoxColumn
            // 
            this.islemDataGridViewTextBoxColumn.DataPropertyName = "Islem";
            this.islemDataGridViewTextBoxColumn.HeaderText = "İŞLEM";
            this.islemDataGridViewTextBoxColumn.Name = "islemDataGridViewTextBoxColumn";
            this.islemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "Ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "ÜCRET";
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            this.ucretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "TARİH";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fTDidDataGridViewTextBoxColumn
            // 
            this.fTDidDataGridViewTextBoxColumn.DataPropertyName = "FTDid";
            this.fTDidDataGridViewTextBoxColumn.HeaderText = "FTDid";
            this.fTDidDataGridViewTextBoxColumn.Name = "fTDidDataGridViewTextBoxColumn";
            this.fTDidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fidDataGridViewTextBoxColumn
            // 
            this.fidDataGridViewTextBoxColumn.DataPropertyName = "Fid";
            this.fidDataGridViewTextBoxColumn.HeaderText = "Fid";
            this.fidDataGridViewTextBoxColumn.Name = "fidDataGridViewTextBoxColumn";
            this.fidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ftipiDataGridViewTextBoxColumn
            // 
            this.ftipiDataGridViewTextBoxColumn.DataPropertyName = "Ftipi";
            this.ftipiDataGridViewTextBoxColumn.HeaderText = "Ftipi";
            this.ftipiDataGridViewTextBoxColumn.Name = "ftipiDataGridViewTextBoxColumn";
            this.ftipiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tAMIR_TABLETableAdapter
            // 
            this.tAMIR_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // Teknik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(923, 474);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.txtSikayet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIslem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Teknik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teknik Servis";
            this.Load += new System.EventHandler(this.Teknik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamirBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIslem;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSikayet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tamirBinding;
        private tamirDataSet tamirDataSet;
        private tamirDataSetTableAdapters.TAMIR_TABLETableAdapter tAMIR_TABLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn madDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sikayetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTDidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ftipiDataGridViewTextBoxColumn;
    }
}