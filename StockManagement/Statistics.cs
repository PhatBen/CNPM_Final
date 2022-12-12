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
    public partial class Statistics : Form
    {
        static String connectionString = "Data Source=ANH\\SQLEXPRESS;Initial Catalog=STOCK_MANAGEMENT;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        bool isMonthsLoaded = false;
        public Statistics()
        {
            InitializeComponent();
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMonthsLoaded)
            {
                int selectedMonth = Convert.ToInt32(comboBoxMonth.SelectedValue);

                String query = "select sum(product.price * supplying_product.quantity) as total_revenue from product, supplying_product, supplying where product.id = supplying_product.product_id and supplying.id = supplying_product.supplying_id and month(supplying.order_at) = " + selectedMonth;
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                int totalRevenueByMonth = 0;
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        totalRevenueByMonth = 0;
                    }
                    else
                    {
                        totalRevenueByMonth = reader.GetInt32(0);
                    }

                }
                labelTotalRevenueByMonth.Text = totalRevenueByMonth.ToString();
                connection.Close();
            }

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // join table supplying_product and product to get total price
            String query = "select sum(product.price * supplying_product.quantity) as total_revenue from product, supplying_product, supplying where product.id = supplying_product.product_id and supplying.id = supplying_product.supplying_id";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int totalRevenue = 0;
            while (reader.Read())
            {
                totalRevenue = reader.GetInt32(0);
            }
            connection.Close();
            labelTotalRevenue.Text = totalRevenue.ToString();

            loadComboBoxMonth();

        }

        private void loadComboBoxMonth()
        {
            Dictionary<int, String> month = new Dictionary<int, String>();
            month.Add(1, "January");
            month.Add(2, "February");
            month.Add(3, "March");
            month.Add(4, "April");
            month.Add(5, "May");
            month.Add(6, "June");
            month.Add(7, "July");
            month.Add(8, "August");
            month.Add(9, "September");
            month.Add(10, "October");
            month.Add(11, "November");
            month.Add(12, "December");
            comboBoxMonth.DataSource = new BindingSource(month, null);
            comboBoxMonth.DisplayMember = "Value";
            comboBoxMonth.ValueMember = "Key";
            isMonthsLoaded = true;
        }
    }
}
    