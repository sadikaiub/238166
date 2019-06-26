namespace Exam2
{
    partial class Save
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
            this.Index = new System.Windows.Forms.GroupBox();
            this.modelName = new System.Windows.Forms.Label();
            this.Imei = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelNameTextBox = new System.Windows.Forms.TextBox();
            this.imeiTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Index.SuspendLayout();
            this.SuspendLayout();
            // 
            // Index
            // 
            this.Index.Controls.Add(this.SaveButton);
            this.Index.Controls.Add(this.priceTextBox);
            this.Index.Controls.Add(this.imeiTextBox);
            this.Index.Controls.Add(this.modelNameTextBox);
            this.Index.Controls.Add(this.label2);
            this.Index.Controls.Add(this.Imei);
            this.Index.Controls.Add(this.modelName);
            this.Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Index.Location = new System.Drawing.Point(108, 82);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(585, 286);
            this.Index.TabIndex = 1;
            this.Index.TabStop = false;
            this.Index.Text = "Save";
            // 
            // modelName
            // 
            this.modelName.AutoSize = true;
            this.modelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelName.Location = new System.Drawing.Point(87, 71);
            this.modelName.Name = "modelName";
            this.modelName.Size = new System.Drawing.Size(86, 16);
            this.modelName.TabIndex = 0;
            this.modelName.Text = "Model Name";
            // 
            // Imei
            // 
            this.Imei.AutoSize = true;
            this.Imei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imei.Location = new System.Drawing.Point(87, 116);
            this.Imei.Name = "Imei";
            this.Imei.Size = new System.Drawing.Size(34, 16);
            this.Imei.TabIndex = 1;
            this.Imei.Text = "IMEI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // modelNameTextBox
            // 
            this.modelNameTextBox.Location = new System.Drawing.Point(192, 71);
            this.modelNameTextBox.Name = "modelNameTextBox";
            this.modelNameTextBox.Size = new System.Drawing.Size(191, 26);
            this.modelNameTextBox.TabIndex = 3;
            // 
            // imeiTextBox
            // 
            this.imeiTextBox.Location = new System.Drawing.Point(192, 110);
            this.imeiTextBox.Name = "imeiTextBox";
            this.imeiTextBox.Size = new System.Drawing.Size(191, 26);
            this.imeiTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(192, 154);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(191, 26);
            this.priceTextBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(308, 218);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 33);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Index);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Index.ResumeLayout(false);
            this.Index.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Index;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox imeiTextBox;
        private System.Windows.Forms.TextBox modelNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Imei;
        private System.Windows.Forms.Label modelName;
    }
}