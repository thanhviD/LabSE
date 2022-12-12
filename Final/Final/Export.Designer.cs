namespace Final
{
    partial class Export
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
            this.lblExport = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblCID = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblEPName = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(464, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExport.Location = new System.Drawing.Point(491, 38);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(146, 16);
            this.lblExport.TabIndex = 1;
            this.lblExport.Text = "EXPORT PRODUCT";
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(121, 86);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(162, 22);
            this.txtCID.TabIndex = 2;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(121, 153);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(162, 22);
            this.txtCName.TabIndex = 3;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(121, 221);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(162, 22);
            this.txtPName.TabIndex = 4;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(121, 288);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(162, 22);
            this.txtNum.TabIndex = 5;
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Location = new System.Drawing.Point(14, 89);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(77, 16);
            this.lblCID.TabIndex = 6;
            this.lblCID.Text = "CustomerID";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(14, 156);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(101, 16);
            this.lblCName.TabIndex = 7;
            this.lblCName.Text = "Customer name";
            // 
            // lblEPName
            // 
            this.lblEPName.AutoSize = true;
            this.lblEPName.Location = new System.Drawing.Point(14, 224);
            this.lblEPName.Name = "lblEPName";
            this.lblEPName.Size = new System.Drawing.Size(90, 16);
            this.lblEPName.TabIndex = 8;
            this.lblEPName.Text = "Product name";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(14, 294);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(55, 16);
            this.lblNum.TabIndex = 9;
            this.lblNum.Text = "Number";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(121, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(369, 383);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(607, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblEPName);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.lblCID);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.lblExport);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Export";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblEPName;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}