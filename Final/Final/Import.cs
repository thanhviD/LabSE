using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Import : Form
    {

        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public Import()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
                return;
            try
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                String Pcode = Convert.ToString(row.Cells[0].Value);
                String PName = Convert.ToString(row.Cells[1].Value);
                String Price = Convert.ToString(row.Cells[2].Value);
                String CompName = Convert.ToString(row.Cells[3].Value);
                String Origin = Convert.ToString(row.Cells[4].Value);

                txtPCode.Text = Pcode;
                txtPName.Text = PName;
                txtPrice.Text = Price;
                txtCompName.Text = CompName;
                txtOrigin.Text = Origin;

            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }


        }

        private void Import_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM  Product_info ", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
            else {
                MessageBox.Show("No data");
            }
            adapter.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
