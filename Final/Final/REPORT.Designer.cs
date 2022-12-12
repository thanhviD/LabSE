namespace Final
{
    partial class Report
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblEPName = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblCID = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.lblTop5 = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(414, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(27, 292);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(55, 16);
            this.lblNum.TabIndex = 17;
            this.lblNum.Text = "Number";
            // 
            // lblEPName
            // 
            this.lblEPName.AutoSize = true;
            this.lblEPName.Location = new System.Drawing.Point(27, 222);
            this.lblEPName.Name = "lblEPName";
            this.lblEPName.Size = new System.Drawing.Size(90, 16);
            this.lblEPName.TabIndex = 16;
            this.lblEPName.Text = "Product name";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(27, 154);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(101, 16);
            this.lblCName.TabIndex = 15;
            this.lblCName.Text = "Customer name";
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Location = new System.Drawing.Point(27, 87);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(77, 16);
            this.lblCID.TabIndex = 14;
            this.lblCID.Text = "CustomerID";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(134, 286);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(162, 22);
            this.txtNum.TabIndex = 13;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(134, 219);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(162, 22);
            this.txtPName.TabIndex = 12;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(134, 151);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(162, 22);
            this.txtCName.TabIndex = 11;
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(134, 84);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(162, 22);
            this.txtCID.TabIndex = 10;
            // 
            // lblTop5
            // 
            this.lblTop5.AutoSize = true;
            this.lblTop5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop5.Location = new System.Drawing.Point(404, 39);
            this.lblTop5.Name = "lblTop5";
            this.lblTop5.Size = new System.Drawing.Size(248, 16);
            this.lblTop5.TabIndex = 18;
            this.lblTop5.Text = "TOP 5 BEST SELLING PRODUCTS";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(23, 381);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(108, 16);
            this.lblSales.TabIndex = 19;
            this.lblSales.Text = "Monthly revenue:";
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(144, 378);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(152, 22);
            this.txtRevenue.TabIndex = 20;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lblTop5);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblEPName);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.lblCID);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblEPName;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label lblTop5;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.TextBox txtRevenue;
    }
}