using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Order();
            form.MdiParent = this;
            form.Show();
        }

        private void supplyingProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new SupplyingProduct();
            form.MdiParent = this;
            form.Show();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Statistics();
            form.MdiParent = this;
            form.Show();    
        }
    }
}
