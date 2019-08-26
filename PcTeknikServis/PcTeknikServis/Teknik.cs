using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PcTeknikServis
{
    public partial class Teknik : Form
    {
        public Anapanel anapanel;
        public Teknik()
        {
            InitializeComponent();
        }

        private void Teknik_Load(object sender, EventArgs e)
        {
            this.tAMIR_TABLETableAdapter.Fill(this.tamirDataSet.TAMIR_TABLE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            anapanel = new Anapanel();
            anapanel.Show();
            this.Hide();
        }

        private void txtUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            anapanel = new Anapanel();
            if (txtIslem.Text != "") //&& txtUcret.Text != "" 
            {
                if (((dataGridView1.SelectedRows[0].Cells[0].Value.ToString())) != "")
                {
                    SqlConnection con = new SqlConnection("Server=desktop-2knss9k\\sql_2014;Database=oto_teknik_servis_PROJE;Integrated Security=true");
                    try
                    {
                        con.Open();
                        String str = "update FATURA_TAMIR set Fid=@fid,Islem=@islem,Ucret=@ucret,TeslimTarih=@tarih where FTid='" + dataGridView1.SelectedRows[0].Cells[6].Value.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(str, con);
                        cmd.Parameters.Add(new SqlParameter("@fid", dataGridView1.SelectedRows[0].Cells[7].Value.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@islem", txtIslem.Text));
                        cmd.Parameters.Add(new SqlParameter("@tarih", DateTime.Now.ToShortDateString()));
                        cmd.Parameters.Add(new SqlParameter("@ucret", txtUcret.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Güncelleme başarılı..");
                        anapanel.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Tablodan seçim yapınız..!");
            }
            else
                MessageBox.Show("Yapılan İşlem Boş Geçilemez..!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
