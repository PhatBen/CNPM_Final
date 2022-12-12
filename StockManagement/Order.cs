using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace StockManagement
{
    public partial class Order : Form
    {
        static String connectionString = "Data Source=ANH\\SQLEXPRESS;Initial Catalog=STOCK_MANAGEMENT;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        int supplyingId = -1;
        bool isProductsLoaded = false;
        int supplyingProductId;
        public Order()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public Order(int supplyingId)
        {
            this.supplyingId = supplyingId;
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // check if supplyingId update, else insert
            if (supplyingId == -1)
            {
                String query = "INSERT INTO Supplying(order_at) VALUES(GETDATE())";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                // get lastest supplying id
                query = "SELECT TOP 1 id FROM Supplying ORDER BY id DESC";
                command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    supplyingId = reader.GetInt32(0);
                }
                connection.Close();
            }            
            loadDataGridViewSupplyingOrder();
            loadComboBoxProduct();
        }


        private void loadComboBoxProduct()
        {
            String query = "SELECT * FROM Product";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            connection.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            comboBoxProduct.DataSource = dt;
            comboBoxProduct.DisplayMember = "name";
            comboBoxProduct.ValueMember = "id";
            isProductsLoaded = true;
            loadLabelPrice();
            loadLabelTotalPrice();
        }

        private int getPrice(int productId)
        {
            String query = "SELECT price FROM Product WHERE id = " + productId;
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int price = 0;
            while (reader.Read())
            {
                price = reader.GetInt32(0);
            }
            connection.Close();
            return price;
        }

        private void loadLabelPrice()
        {
            int productId = Convert.ToInt32(comboBoxProduct.SelectedValue);
            int price = getPrice(productId);
            labelPrice.Text = price.ToString();
        }

        private void loadDataGridViewSupplyingOrder()
        {
            String query = "SELECT * FROM supplying_product WHERE supplying_id = " + supplyingId;
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSupplyingOrder.DataSource = dt;
            dataGridViewSupplyingOrder.Columns[0].Visible = false;
            dataGridViewSupplyingOrder.Columns[1].HeaderCell.Value = "Product";
            dataGridViewSupplyingOrder.Columns[2].HeaderCell.Value = "Quantity";

        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isProductsLoaded)
            {
                loadLabelPrice();
                loadLabelTotalPrice();
            }
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            loadLabelTotalPrice();
        }
        
        private void loadLabelTotalPrice()
        {
            // get total price and set label
            int quantity = (int)numericUpDownQuantity.Value;
            float price = getPrice(Convert.ToInt32(comboBoxProduct.SelectedValue));
            float totalPrice = quantity * price;
            labelTotalPrice.Text = "Total Price: " + totalPrice;
        }

        private void buttonCreateSupplyingProduct_Click(object sender, EventArgs e)
        {
            // if product is not in database then insert, else update
            if (isProductInDatabase(Convert.ToInt32(comboBoxProduct.SelectedValue)))
            {
                updateSupplyingProduct();
            }
            else
            {
                insertSupplyingProduct();
            }
            loadDataGridViewSupplyingOrder();
        }

        private bool isProductInDatabase(int productId)
        {
            String query = "SELECT * FROM Supplying_Product WHERE supplying_id = " + supplyingId + " AND product_id = " + productId;
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            bool isInDatabase = false;
            while (reader.Read())
            {
                isInDatabase = true;
            }
            connection.Close();
            return isInDatabase;
        }

        private void insertSupplyingProduct()
        {
            String query = "INSERT INTO Supplying_Product(supplying_id, product_id, quantity) VALUES(" + supplyingId + ", " + comboBoxProduct.SelectedValue + ", " + numericUpDownQuantity.Value + ")";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void updateSupplyingProduct()
        {
            String query = "UPDATE Supplying_Product SET quantity = " + numericUpDownQuantity.Value + " WHERE supplying_id = " + supplyingId + " AND product_id = " + comboBoxProduct.SelectedValue;
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void dataGridViewSupplyingOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonDeleteSupplyingProduct_Click(object sender, EventArgs e)
        {

            String query = "DELETE FROM supplying_product WHERE supplying_id = " + supplyingId + " AND product_id = " + supplyingProductId;
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            loadDataGridViewSupplyingOrder();
        }

        private void dataGridViewSupplyingOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supplyingProductId = Convert.ToInt32(dataGridViewSupplyingOrder.Rows[e.RowIndex].Cells[1].Value);
            labelPrice.Text = supplyingProductId.ToString();
        }
    }
}
