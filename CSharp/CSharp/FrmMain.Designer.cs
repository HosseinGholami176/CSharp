namespace CSharp
{
    partial class FrmMain
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
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnAddProduct2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Location = new System.Drawing.Point(740, 37);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(82, 23);
            this.BtnAddProduct.TabIndex = 0;
            this.BtnAddProduct.Text = "AddProduct";
            this.BtnAddProduct.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(844, 37);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(82, 23);
            this.BtnCalc.TabIndex = 1;
            this.BtnCalc.Text = "Calc";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnAddProduct2
            // 
            this.BtnAddProduct2.Location = new System.Drawing.Point(747, 85);
            this.BtnAddProduct2.Name = "BtnAddProduct2";
            this.BtnAddProduct2.Size = new System.Drawing.Size(75, 23);
            this.BtnAddProduct2.TabIndex = 2;
            this.BtnAddProduct2.Text = "AddProduct";
            this.BtnAddProduct2.UseVisualStyleBackColor = true;
            this.BtnAddProduct2.Click += new System.EventHandler(this.BtnAddProduct2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 408);
            this.Controls.Add(this.BtnAddProduct2);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.BtnAddProduct);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnAddProduct2;
    }
}