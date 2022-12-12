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
    public partial class Export : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public Export()
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

        private void Export_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM  Customer ", conn);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "INSERT INTO Customer (CID, CName, PName, Number) VALUES (@CID, @CName, @PName, @Number)";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@CID", txtCID.Text));
            cmd.Parameters.Add(new SqlParameter("@CName", txtCName.Text));
            cmd.Parameters.Add(new SqlParameter("@PName", txtPName.Text));
            cmd.Parameters.Add(new SqlParameter("@Number", txtNum.Text));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                throw new Exception("Error:" + ex.Message);
            
            }
            MessageBox.Show("Save successfully!");
            dataGridView1.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "UPDATE Customer SET CName = @CName, PName = @PName, Number = @Number WHERE CID = @CID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@CID", txtCID.Text));
            cmd.Parameters.Add(new SqlParameter("@CName", txtCName.Text));
            cmd.Parameters.Add(new SqlParameter("@PName", txtPName.Text));
            cmd.Parameters.Add(new SqlParameter("@Number", txtNum.Text));

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);

            }
            MessageBox.Show("Edit successfully!");
            dataGridView1.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "DELETE FROM Customer WHERE CID = @CID";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.Add(new SqlParameter("@CID", txtCID.Text));

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);

            }
            MessageBox.Show("Delete successfully!");
            dataGridView1.Refresh();
        }
    }
}
