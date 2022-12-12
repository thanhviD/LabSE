using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final
{
    public partial class Report : Form
    {
        public Report()
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
                String CID = Convert.ToString(row.Cells[0].Value);
                String CName = Convert.ToString(row.Cells[1].Value);
                String PName = Convert.ToString(row.Cells[2].Value);
                String Number = Convert.ToString(row.Cells[3].Value);

                txtCID.Text = CID;
                txtCName.Text = CName;
                txtPName.Text = PName;
                txtNum.Text = Number;
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }



        }

        private void Report_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 5 * FROM  Customer ORDER BY Number DESC", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
            else
            {
                MessageBox.Show("No data");
            }
            adapter.Dispose();
        }
    }
}
