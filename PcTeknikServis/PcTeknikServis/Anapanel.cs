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
    public partial class Anapanel : Form
    {
        public Teknik teknik;
        public Satis satis;
        public Giris giris;
        public Fatura fatura;
        

        public Anapanel()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";

            txtEmail.Text = "";
            txtAdres.Text = "";
            cbCinsiyet.Text = "";
            txtAplaka.Text = "";
        }
        private void Anapanel_Load(object sender, EventArgs e)
        {
           
            this.mUS_TABLETableAdapter.Fill(this.musDataSet.MUS_TABLE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            if (Giris.flag == 1)
            {
                btnFatura.Visible = true;
                lblFatura.Visible = true;
            }
            
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();  //textboxları temizliyor
        }




        private void txtFiltre_TextChanged(object sender, EventArgs e)
        {
            musteriBinding.Filter = "Mad like '%" + txtFiltre.Text + "%'";   //ad a göre filtreleme için
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
                lblAd.Text = "Ad Boş Geçilemez";
            else if (txtSoyad.Text == "")
                lblSoyad.Text = "Soyad Boş Geçilemez";
           
            else
            {
                SqlConnection con = new SqlConnection("Server=desktop-2knss9k\\sql_2014;Database=oto_teknik_servis_PROJE;Integrated Security=true");
                try
                {
                    con.Open();
                    String str = "insert into MUSTERILER (Mad,Msoyad,MaracPlaka,Mtel,Memail,Madres) values('"+ txtAd.Text + "','"+ txtSoyad.Text + "','"+ txtAplaka.Text + "','" + maskedTextBox1.Text+ "','"+txtEmail.Text+"','"+txtAdres.Text+"')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    //cmd.Parameters.Add(new SqlParameter("@mad", txtAd.Text));
                    //cmd.Parameters.Add(new SqlParameter("@msoyad", txtSoyad.Text));
                    //cmd.Parameters.Add(new SqlParameter("@maracplaka", txtAplaka.Text));
                    //cmd.Parameters.Add(new SqlParameter("@mtel", txtTel.Text));
                    //cmd.Parameters.Add(new SqlParameter("@memail", txtEmail.Text));
                    //cmd.Parameters.Add(new SqlParameter("@madres", txtAdres.Text));
                    

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Müşteri ekleme başarılı..");
                    this.mUS_TABLETableAdapter.Fill(this.musDataSet.MUS_TABLE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)  //L-AB76216
        {
            SqlConnection con = new SqlConnection("Server=desktop-2knss9k\\sql_2014;Database=oto_teknik_servis_PROJE;Integrated Security=true");
            try
            {
                con.Open();
                String str = "delete from MUSTERILER where Mid=@mid";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.Add(new SqlParameter("@mid", int.Parse(txtId.Text)));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("-- Müşteri silindi --");
                this.mUS_TABLETableAdapter.Fill(this.musDataSet.MUS_TABLE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (txtAd.Text == "")
                lblAd.Text = "Ad Boş Geçilemez";
            else if (txtSoyad.Text == "")
                lblSoyad.Text = "Soyad Boş Geçilemez";
            
            else
            {
                SqlConnection con = new SqlConnection("Server=desktop-2knss9k\\sql_2014;Database=oto_teknik_servis_PROJE;Integrated Security=true");
                try
                {
                    con.Open();
                    String str = "update MUSTERILER set Mad=@mad,Msoyad=@msoyad,MaracPlaka=@maracplaka,Mtel=@mtel,(select McinsiyedID from CINSIYET where CinsiyetTanim='" + cbCinsiyet.Text + "'),Memail=@memail,Madres=@madres " + "where Mid=" + int.Parse(txtId.Text);
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.Parameters.Add(new SqlParameter("@mad", txtAd.Text));
                    cmd.Parameters.Add(new SqlParameter("@msoyad", txtSoyad.Text));
                    cmd.Parameters.Add(new SqlParameter("@maracplaka", txtAplaka.Text));
                    
                    cmd.Parameters.Add(new SqlParameter("@memail", txtEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@madres", txtAdres.Text));
                    //cmd.Parameters.Add(new SqlParameter("@mid", txtId.Text));
                    

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("-- Müşteri Güncellendi --");
                    this.mUS_TABLETableAdapter.Fill(this.musDataSet.MUS_TABLE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            satis = new Satis();
            if (txtId.Text != "")
            {
                SqlConnection con = new SqlConnection("Server=desktop-2knss9k\\sql_2014;Database=oto_teknik_servis_PROJE;Integrated Security=true");
                try
                {
                    con.Open();
                    String str = "insert into FATURA (Mid,Tarih,Ftipi) "
                        + "values(@mid,@tarih,@ftipi)";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.Parameters.Add(new SqlParameter("@mid", txtId.Text));
                    cmd.Parameters.Add(new SqlParameter("@tarih", DateTime.Now.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("@ftipi", 1));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Ön fatura oluşturuldu");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                satis.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Müşteri seçin veya yeni kayıt yapın");
        }

        private void btnTeknik_Click(object sender, EventArgs e)
        {
            teknik = new Teknik();
            DialogResult dialogResut = MessageBox.Show("Yeni kayıt için EVET\nGüncellemek için HAYIR","TEKNİK SERVİS",MessageBoxButtons.YesNoCancel);
            if(dialogResut == DialogResult.Yes)
            {
                if (txtId.Text != "" && txtSikayet.Text != "")
                {
                    SqlConnection con = new SqlConnection("Server=desktop-2knss9k\\sql_2014;Database=oto_teknik_servis_PROJE;Integrated Security=true");
                    try
                    {
                        con.Open();
                        String str = "insert into FATURA (Mid,Tarih,Sikayet,Ftipi) "
                            + "values(@mid,@tarih,@sikayet,@ftipi)";
                        SqlCommand cmd = new SqlCommand(str, con);
                        cmd.Parameters.Add(new SqlParameter("@mid", txtId.Text));
                        cmd.Parameters.Add(new SqlParameter("@sikayet", txtSikayet.Text));
                        cmd.Parameters.Add(new SqlParameter("@tarih", DateTime.Now.ToShortDateString()));
                        cmd.Parameters.Add(new SqlParameter("@ftipi", 2));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        String str1 = "insert into FATURA_TAMIR (Fid,Tarih) "
                            + "values((SELECT MAX(Fid) from FATURA),@tarih)";
                        SqlCommand cmd1 = new SqlCommand(str1, con);
                        
                        cmd1.Parameters.Add(new SqlParameter("@tarih", DateTime.Now.ToShortDateString()));
                        
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("fatura hazır..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Müşteri seçin veya yeni kayıt yapın..!");
            }
            else if(dialogResut == DialogResult.No)
            {
                teknik.Show();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=desktop-2knss9k\\sql_2014;Database=oto_teknik_servis_PROJE;Integrated Security=true");
            if (txtYsifre.Text == "")
            {
                try
                {
                    con.Open();
                    String str = "update KULLANICILAR set Ksifre=@ksifre where Kad='" + txtKul.Text + "' and Ksifre='" + txtEsifre.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.Parameters.Add(new SqlParameter("@ksifre", txtYsifre.Text));

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Şifre değiştirildi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Eksik veya yanlış bilgi !!");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            fatura = new Fatura();
            fatura.Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void cbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
