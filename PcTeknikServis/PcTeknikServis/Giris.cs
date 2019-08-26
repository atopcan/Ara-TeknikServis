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

    public partial class Giris : Form
    {
        SqlConnection con = new SqlConnection();
        public Giris giris;
        public static int flag;
        public Anapanel anapanel;
        public Giris()
        {
            InitializeComponent();

        }
        private void SifreOlustur()
        {
            lblGuvenlik.Text = "";
            Random rnd = new Random();
            lblGuvenlik.Text += rnd.Next(0, 10);
            lblGuvenlik.Text += rnd.Next(0, 10);
            lblGuvenlik.Text += rnd.Next(0, 10);
            lblGuvenlik.Text += rnd.Next(0, 10);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            SifreOlustur();
            con.ConnectionString = "Server=desktop-2knss9k\\sql_2014;Database=oto_teknik_servis_PROJE;Integrated Security=true";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SifreOlustur();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtSifre.PasswordChar = '\0';
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            anapanel = new Anapanel();
            if (Convert.ToInt32(lblDeneme.Text) > 0)
            {
                try
                {
                    con.Open();
                    SqlParameter prm1 = new SqlParameter("@kadi", txtKadi.Text);
                    SqlParameter prm2 = new SqlParameter("@sifre", txtSifre.Text);
                    string sql = "select * from KULLANICILAR where Kad=@kadi and Ksifre=@sifre";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(prm1);
                    cmd.Parameters.Add(prm2);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0 && txtGuvenlik.Text == lblGuvenlik.Text)
                    {
                        if (txtKadi.Text == "admin")
                        {
                            flag = 1;
                        }

                        MessageBox.Show("Giriş Yapıldı!");
                        this.Hide();
                        anapanel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Malesef, birşeyler yolunda gitmedi!");
                        lblDeneme.Text = (Convert.ToInt32(lblDeneme.Text) - 1).ToString();
                        SifreOlustur();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (Convert.ToInt32(lblDeneme.Text) == 0)
            {
                MessageBox.Show("Giriş yapma hakkınız kalmamıştır, Program kapanıyor!");
                Application.Exit();
            }
          
        }
    }
}
