namespace Exam2
{
    partial class Home
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
            this.ImeiButton = new System.Windows.Forms.Button();
            this.PriceButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Index.SuspendLayout();
            this.SuspendLayout();
            // 
            // Index
            // 
            this.Index.Controls.Add(this.ImeiButton);
            this.Index.Controls.Add(this.PriceButton);
            this.Index.Controls.Add(this.SaveButton);
            this.Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Index.Location = new System.Drawing.Point(105, 80);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(585, 286);
            this.Index.TabIndex = 0;
            this.Index.TabStop = false;
            this.Index.Text = "Index";
            // 
            // ImeiButton
            // 
            this.ImeiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeiButton.Location = new System.Drawing.Point(103, 196);
            this.ImeiButton.Name = "ImeiButton";
            this.ImeiButton.Size = new System.Drawing.Size(311, 40);
            this.ImeiButton.TabIndex = 2;
            this.ImeiButton.Text = "Search Mobile Handset by IMEI";
            this.ImeiButton.UseVisualStyleBackColor = true;
            // 
            // PriceButton
            // 
            this.PriceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceButton.Location = new System.Drawing.Point(103, 125);
            this.PriceButton.Name = "PriceButton";
            this.PriceButton.Size = new System.Drawing.Size(311, 40);
            this.PriceButton.TabIndex = 1;
            this.PriceButton.Text = "Search Mobile Handset by Price Range";
            this.PriceButton.UseVisualStyleBackColor = true;
            this.PriceButton.Click += new System.EventHandler(this.PriceButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(103, 59);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(311, 40);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save Mobile Handset Information";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Index);
            this.Name = "Form1";
            this.Text = "Mobile Handset Information";
            this.Index.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Index;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ImeiButton;
        private System.Windows.Forms.Button PriceButton;
        private System.Windows.Forms.Button SaveButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

