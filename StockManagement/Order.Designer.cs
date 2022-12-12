namespace StockManagement
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewSupplyingOrder = new System.Windows.Forms.DataGridView();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateSupplyingProduct = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonDeleteSupplyingProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplyingOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSupplyingOrder
            // 
            this.dataGridViewSupplyingOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplyingOrder.Location = new System.Drawing.Point(9, 151);
            this.dataGridViewSupplyingOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSupplyingOrder.Name = "dataGridViewSupplyingOrder";
            this.dataGridViewSupplyingOrder.RowHeadersWidth = 51;
            this.dataGridViewSupplyingOrder.RowTemplate.Height = 24;
            this.dataGridViewSupplyingOrder.Size = new System.Drawing.Size(582, 205);
            this.dataGridViewSupplyingOrder.TabIndex = 0;
            this.dataGridViewSupplyingOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplyingOrder_CellClick);
            this.dataGridViewSupplyingOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplyingOrder_CellContentClick);
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(10, 11);
            this.comboBoxProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(92, 21);
            this.comboBoxProduct.TabIndex = 1;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(10, 36);
            this.numericUpDownQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownQuantity.TabIndex = 2;
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            // 
            // buttonCreateSupplyingProduct
            // 
            this.buttonCreateSupplyingProduct.Location = new System.Drawing.Point(10, 59);
            this.buttonCreateSupplyingProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateSupplyingProduct.Name = "buttonCreateSupplyingProduct";
            this.buttonCreateSupplyingProduct.Size = new System.Drawing.Size(91, 19);
            this.buttonCreateSupplyingProduct.TabIndex = 3;
            this.buttonCreateSupplyingProduct.Text = "Add";
            this.buttonCreateSupplyingProduct.UseVisualStyleBackColor = true;
            this.buttonCreateSupplyingProduct.Click += new System.EventHandler(this.buttonCreateSupplyingProduct_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(106, 11);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(37, 13);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price: ";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(105, 36);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(61, 13);
            this.labelTotalPrice.TabIndex = 5;
            this.labelTotalPrice.Text = "Total Price:";
            // 
            // buttonDeleteSupplyingProduct
            // 
            this.buttonDeleteSupplyingProduct.Location = new System.Drawing.Point(534, 11);
            this.buttonDeleteSupplyingProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteSupplyingProduct.Name = "buttonDeleteSupplyingProduct";
            this.buttonDeleteSupplyingProduct.Size = new System.Drawing.Size(56, 19);
            this.buttonDeleteSupplyingProduct.TabIndex = 6;
            this.buttonDeleteSupplyingProduct.Text = "Delete";
            this.buttonDeleteSupplyingProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteSupplyingProduct.Click += new System.EventHandler(this.buttonDeleteSupplyingProduct_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonDeleteSupplyingProduct);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonCreateSupplyingProduct);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.dataGridViewSupplyingOrder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplyingOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSupplyingOrder;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buttonCreateSupplyingProduct;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button buttonDeleteSupplyingProduct;
    }
}