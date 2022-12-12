namespace StockManagement
{
    partial class SupplyingProduct
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
            this.dataGridViewSupplying = new System.Windows.Forms.DataGridView();
            this.btnDeleteSupplying = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplying)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSupplying
            // 
            this.dataGridViewSupplying.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplying.Location = new System.Drawing.Point(10, 41);
            this.dataGridViewSupplying.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSupplying.Name = "dataGridViewSupplying";
            this.dataGridViewSupplying.RowHeadersWidth = 51;
            this.dataGridViewSupplying.RowTemplate.Height = 24;
            this.dataGridViewSupplying.Size = new System.Drawing.Size(581, 314);
            this.dataGridViewSupplying.TabIndex = 0;
            this.dataGridViewSupplying.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplying_CellClick);
            this.dataGridViewSupplying.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplying_CellContentClick);
            this.dataGridViewSupplying.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplying_CellDoubleClick);
            // 
            // btnDeleteSupplying
            // 
            this.btnDeleteSupplying.Location = new System.Drawing.Point(513, 13);
            this.btnDeleteSupplying.Name = "btnDeleteSupplying";
            this.btnDeleteSupplying.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSupplying.TabIndex = 1;
            this.btnDeleteSupplying.Text = "Delete";
            this.btnDeleteSupplying.UseVisualStyleBackColor = true;
            this.btnDeleteSupplying.Click += new System.EventHandler(this.btnDeleteSupplying_Click);
            // 
            // SupplyingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDeleteSupplying);
            this.Controls.Add(this.dataGridViewSupplying);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SupplyingProduct";
            this.Text = "SupplyingProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SupplyingProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplying)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSupplying;
        private System.Windows.Forms.Button btnDeleteSupplying;
    }
}