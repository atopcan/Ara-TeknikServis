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
    public partial class Satis : Form
    {

        public Anapanel anapanel;
        SqlConnection con = new SqlConnection();
        public Satis()
        {
            InitializeComponent();
        }

        private void Satis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'urunDataSet.URUN_TABLE' table. You can move, or remove it, as needed.
            this.uRUN_TABLETableAdapter.Fill(this.urunDataSet.URUN_TABLE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            cbUrunDoldur();
            cbMarkaDoldur();
            cbModelDoldur();
            
        }

        private void cbUrunTip_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbMarka.Text == "" && cbModel.Text == "")
                urunlerBinding.Filter = "UrunAdi like '%" + cbUrunTip.Text + "%'";
            else if (cbMarka.Text != "" && cbModel.Text == "")
                urunlerBinding.Filter = "UrunAdi like '%" + cbUrunTip.Text + "%' and MarkaAdi like '%" + cbMarka.Text + "%'";
            else if (cbMarka.Text == "" && cbModel.Text != "")
                urunlerBinding.Filter = "UrunAdi like '%" + cbUrunTip.Text + "%' and Uaciklama like '%" + cbModel.Text + "%'";
            else
                urunlerBinding.Filter = "UrunAdi like '%" + cbUrunTip.Text + "%' and MarkaAdi like '%" + cbMarka.Text + "%' and Uaciklama like '%" + cbModel.Text + "%'";

        }
        public void cbUrunDoldur()
        {
            con.ConnectionString = "Server=desktop-2knss9k\\sql_2014;Database=oto_teknik_servis_PROJE;Integrated Security=true";
            try
            {
                con.Open();

                string sql = "select UrunAdi from URUN_TIPLERI";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    cbUrunTip.Items.Add(dr[0]);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cbMarkaDoldur()
        {
            con.ConnectionString = "Server=desktop-2knss9k\\sql_2014;Database=oto_teknik_servis_PROJE;Integrated Security=true";
            try
            {
                con.Open();

                string sql = "select MarkaAdi from MARKALAR";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    cbMarka.Items.Add(dr[0]);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbMarka_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbUrunTip.Text == "" && cbModel.Text == "")
                urunlerBinding.Filter = "MarkaAdi like '%" + cbMarka.Text + "%'";
            else if (cbUrunTip.Text != "" && cbModel.Text == "")
                urunlerBinding.Filter = "UrunAdi like '%" + cbUrunTip.Text + "%' and MarkaAdi like '%" + cbMarka.Text + "%'";
            else if (cbUrunTip.Text == "" && cbModel.Text != "")
                urunlerBinding.Filter = "MarkaAdi like '%" + cbMarka.Text + "%' and Uaciklama like '%" + cbModel.Text + "%'";
            else
                urunlerBinding.Filter = "UrunAdi like '%" + cbUrunTip.Text + "%' and MarkaAdi like '%" + cbMarka.Text + "%' and Uaciklama like '%" + cbModel.Text + "%'";

        }
        public void cbModelDoldur()
        {
            con.ConnectionString = "Server=desktop-2knss9k\\sql_2014;Database=oto_teknik_servis_PROJE;Integrated Security=true";
            try
            {
                con.Open();

                string sql = "select Uaciklama from URUNLER";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    cbModel.Items.Add(dr[0]);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbModel_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbUrunTip.Text == "" && cbMarka.Text == "")
                urunlerBinding.Filter = "Uaciklama like '%" + cbModel.Text + "%'";
            else if (cbUrunTip.Text != "" && cbMarka.Text == "")
                urunlerBinding.Filter = "UrunAdi like '%" + cbUrunTip.Text + "%' and Uaciklama like '%" + cbModel.Text + "%'";
            else if (cbUrunTip.Text == "" && cbMarka.Text != "")
                urunlerBinding.Filter = "MarkaAdi like '%" + cbMarka.Text + "%' and Uaciklama like '%" + cbModel.Text + "%'";
            else
                urunlerBinding.Filter = "UrunAdi like '%" + cbUrunTip.Text + "%' and MarkaAdi like '%" + cbMarka.Text + "%' and Uaciklama like '%" + cbModel.Text + "%'";
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMiktar.Text = "";
            cbUrunTip.Text = "";
            cbMarka.Text = "";
            cbMarka.Text = "";
            this.uRUN_TABLETableAdapter.Fill(this.urunDataSet.URUN_TABLE);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=desktop-2knss9k\\sql_2014;Database=oto_teknik_servis_PROJE;Integrated Security=true");
            try
            {
                con.Open();
                String str = "delete from FATURA where Fid=(select MAX(Fid) from FATURA)";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Satış İptal Edildi..!");
                anapanel = new Anapanel();
                anapanel.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            anapanel = new Anapanel();
            if (txtMiktar.Text != "" && cbUrunTip.Text != "" && cbMarka.Text != "" && cbModel.Text != "" && dataGridView1.RowCount == 2)
            {
                if ((int.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString())) >= (int.Parse(txtMiktar.Text)))
                {
                    SqlConnection con = new SqlConnection("Server=desktop-2knss9k\\sql_2014;Database=oto_teknik_servis_PROJE;Integrated Security=true");
                    try
                    {
                        con.Open();
                        String str = "insert into FATURA_SATIS (Fid,Uid,FSmiktar,FSfiyat,Tarih) "
                            + "values((select MAX(Fid) from FATURA),@uid,@fsdmiktar,@fsdfiyat,@tarih)";
                        SqlCommand cmd = new SqlCommand(str, con);
                        cmd.Parameters.Add(new SqlParameter("@fsdfiyat", lblTutar.Text));
                        cmd.Parameters.Add(new SqlParameter("@fsdmiktar", txtMiktar.Text));
                        cmd.Parameters.Add(new SqlParameter("@tarih", DateTime.Now.ToShortDateString()));
                        cmd.Parameters.Add(new SqlParameter("@uid", dataGridView1.Rows[0].Cells[0].Value.ToString()));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Satış başarılı..");
                        anapanel.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Stok miktarı yeterli değil..!");
            }
            else
                MessageBox.Show("Ürün seçimini eksik ya da hatalı yaptınız..!");
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            
            if (txtMiktar.Text !="" && int.Parse(txtMiktar.Text) >= 0 && dataGridView1.RowCount == 2)
            {
                lblTutar.Text = Convert.ToString(
                    (int.Parse(dataGridView1.Rows[0].Cells[5].Value.ToString())) *
                    (int.Parse(txtMiktar.Text))
                    );
            }
            else
                MessageBox.Show("Ürün seçimini eksik ya da hatalı yaptınız..!");
        }

        private void cbUrunTip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
