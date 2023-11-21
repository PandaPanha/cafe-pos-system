namespace cafe_pos_system.forms
{
    partial class ucMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMenu));
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProduct
            // 
            this.pbProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProduct.Image = ((System.Drawing.Image)(resources.GetObject("pbProduct.Image")));
            this.pbProduct.Location = new System.Drawing.Point(13, 12);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(199, 133);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduct.TabIndex = 0;
            this.pbProduct.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.lbName.Location = new System.Drawing.Point(58, 162);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(111, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Hot Chocolate";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(216)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnAdd.Location = new System.Drawing.Point(13, 199);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(86)))), ((int)(((byte)(60)))));
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(216)))));
            this.lbPrice.Location = new System.Drawing.Point(157, 12);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(66, 26);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "$3.00";
            // 
            // ucMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbProduct);
            this.Name = "ucMenu";
            this.Size = new System.Drawing.Size(223, 259);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbPrice;
    }
}
