using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StockManagement
{
    public partial class SupplyingProduct : Form
    {
        static String connectionString = "Data Source=ANH\\SQLEXPRESS;Initial Catalog=STOCK_MANAGEMENT;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public SupplyingProduct()
        {
            InitializeComponent();
        }

        private void SupplyingProduct_Load(object sender, EventArgs e)
        {
            loadDataGridViewSupplying();

        }
        private void loadDataGridViewSupplying()
        {
            String query = "SELECT * FROM supplying";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSupplying.DataSource = dt;
        }

        private void dataGridViewSupplying_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int supplyingId = Convert.ToInt32(dataGridViewSupplying.Rows[e.RowIndex].Cells[0].Value);
            Form form = new Order(supplyingId);
            this.Hide();
            form.Show();

        }

        private void dataGridViewSupplyingProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSupplying_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSupplying_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int supplyingId = Convert.ToInt32(dataGridViewSupplying.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btnDeleteSupplying_Click(object sender, EventArgs e)
        {
            if (dataGridViewSupplying.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridViewSupplying.SelectedRows.Count; i++)
                    {
                        int id = Convert.ToInt32(dataGridViewSupplying.SelectedRows[i].Cells[0].Value);
                        String query = "DELETE FROM supplying WHERE id = '" + id + "'";
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    loadDataGridViewSupplying();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }
    }
}
