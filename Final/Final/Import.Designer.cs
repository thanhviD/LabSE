namespace Final
{
    partial class Import
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPCode = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.lblPCode = new System.Windows.Forms.Label();
            this.lblPName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCompName = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(462, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Supplement Facts Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(457, 307);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtPCode
            // 
            this.txtPCode.Location = new System.Drawing.Point(111, 75);
            this.txtPCode.Name = "txtPCode";
            this.txtPCode.Size = new System.Drawing.Size(174, 22);
            this.txtPCode.TabIndex = 2;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(111, 141);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(174, 22);
            this.txtPName.TabIndex = 3;
            this.txtPName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(111, 208);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(174, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(111, 273);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(174, 22);
            this.txtCompName.TabIndex = 5;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(111, 345);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(174, 22);
            this.txtOrigin.TabIndex = 6;
            // 
            // lblPCode
            // 
            this.lblPCode.AutoSize = true;
            this.lblPCode.Location = new System.Drawing.Point(25, 81);
            this.lblPCode.Name = "lblPCode";
            this.lblPCode.Size = new System.Drawing.Size(49, 16);
            this.lblPCode.TabIndex = 7;
            this.lblPCode.Text = "PCode";
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Location = new System.Drawing.Point(25, 141);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(53, 16);
            this.lblPName.TabIndex = 8;
            this.lblPName.Text = "PName";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(25, 208);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Location = new System.Drawing.Point(25, 273);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(80, 16);
            this.lblCompName.TabIndex = 10;
            this.lblCompName.Text = "CompName";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(25, 345);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(42, 16);
            this.lblOrigin.TabIndex = 11;
            this.lblOrigin.Text = "Origin";
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblCompName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.lblPCode);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.txtCompName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtPCode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Import";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPCode;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label lblPCode;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.Label lblOrigin;
    }
}

