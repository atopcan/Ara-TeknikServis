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
    public partial class Fatura : Form
    {
        public Fatura()
        {
            InitializeComponent();
        }

        private void Fatura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet1.FATURATAMIR' table. You can move, or remove it, as needed.
            this.fATURATAMIRTableAdapter.Fill(this.dbDataSet1.FATURATAMIR);
            // TODO: This line of code loads data into the 'dbDataSet.FATURASATIS' table. You can move, or remove it, as needed.
            this.fATURASATISTableAdapter.Fill(this.dbDataSet.FATURASATIS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            if(dataGridView1.RowCount>1)
            {
                decimal total = 0;
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    total += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                }
                lblstoplam.Text = Convert.ToString(total) + " TL";
            }
            if (dataGridView2.RowCount > 1)
            {
                decimal total = 0;
                for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                {
                    total += Convert.ToDecimal(dataGridView2.Rows[i].Cells[6].Value);
                }
                lblftoplam.Text = Convert.ToString(total) + " TL";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
