namespace Exam2
{
    partial class SearchPrice
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
            this.components = new System.ComponentModel.Container();
            this.Index = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.p2TextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.p1TextBox = new System.Windows.Forms.TextBox();
            this.Imei = new System.Windows.Forms.Label();
            this.modelName = new System.Windows.Forms.Label();
            this.mobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Index
            // 
            this.Index.Controls.Add(this.dataGridView1);
            this.Index.Controls.Add(this.p2TextBox);
            this.Index.Controls.Add(this.SearchButton);
            this.Index.Controls.Add(this.p1TextBox);
            this.Index.Controls.Add(this.Imei);
            this.Index.Controls.Add(this.modelName);
            this.Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Index.Location = new System.Drawing.Point(108, 82);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(611, 356);
            this.Index.TabIndex = 2;
            this.Index.TabStop = false;
            this.Index.Text = "Search by Price Range";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.modelNameDataGridViewTextBoxColumn,
            this.imeiDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mobileBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(81, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 219);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // p2TextBox
            // 
            this.p2TextBox.Location = new System.Drawing.Point(342, 33);
            this.p2TextBox.Name = "p2TextBox";
            this.p2TextBox.Size = new System.Drawing.Size(114, 26);
            this.p2TextBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(486, 30);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 33);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // p1TextBox
            // 
            this.p1TextBox.Location = new System.Drawing.Point(160, 33);
            this.p1TextBox.Name = "p1TextBox";
            this.p1TextBox.Size = new System.Drawing.Size(114, 26);
            this.p1TextBox.TabIndex = 3;
            // 
            // Imei
            // 
            this.Imei.AutoSize = true;
            this.Imei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imei.Location = new System.Drawing.Point(290, 39);
            this.Imei.Name = "Imei";
            this.Imei.Size = new System.Drawing.Size(31, 16);
            this.Imei.TabIndex = 1;
            this.Imei.Text = "and";
            // 
            // modelName
            // 
            this.modelName.AutoSize = true;
            this.modelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelName.Location = new System.Drawing.Point(49, 39);
            this.modelName.Name = "modelName";
            this.modelName.Size = new System.Drawing.Size(93, 16);
            this.modelName.TabIndex = 0;
            this.modelName.Text = "Price between";
            // 
            // mobileBindingSource
            // 
            this.mobileBindingSource.DataSource = typeof(Exam2.Model.Mobile);
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // imeiDataGridViewTextBoxColumn
            // 
            this.imeiDataGridViewTextBoxColumn.DataPropertyName = "Imei";
            this.imeiDataGridViewTextBoxColumn.HeaderText = "Imei";
            this.imeiDataGridViewTextBoxColumn.Name = "imeiDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // SearchPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Index);
            this.Name = "SearchPrice";
            this.Text = "Form3";
            this.Index.ResumeLayout(false);
            this.Index.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Index;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox p1TextBox;
        private System.Windows.Forms.Label Imei;
        private System.Windows.Forms.Label modelName;
        private System.Windows.Forms.TextBox p2TextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mobileBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}