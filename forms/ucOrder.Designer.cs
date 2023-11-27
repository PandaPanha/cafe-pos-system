namespace cafe_pos_system.forms
{
    partial class UCOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOrder));
            this.lblItem = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCupSize = new System.Windows.Forms.Label();
            this.lblSugar = new System.Windows.Forms.Label();
            this.lblIce = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblItem.AutoEllipsis = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(30, 13);
            this.lblItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(150, 17);
            this.lblItem.TabIndex = 25;
            this.lblItem.Text = "Cafe";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(271, 11);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(44, 17);
            this.lblUnitPrice.TabIndex = 27;
            this.lblUnitPrice.Text = "$3.00";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(368, 11);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(44, 17);
            this.lblAmount.TabIndex = 28;
            this.lblAmount.Text = "$3.00";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(45)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(447, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 38);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCupSize
            // 
            this.lblCupSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCupSize.AutoSize = true;
            this.lblCupSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupSize.Location = new System.Drawing.Point(10, 13);
            this.lblCupSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCupSize.Name = "lblCupSize";
            this.lblCupSize.Size = new System.Drawing.Size(19, 17);
            this.lblCupSize.TabIndex = 30;
            this.lblCupSize.Text = "M";
            this.lblCupSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSugar
            // 
            this.lblSugar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSugar.AutoSize = true;
            this.lblSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSugar.Location = new System.Drawing.Point(9, 32);
            this.lblSugar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(44, 17);
            this.lblSugar.TabIndex = 31;
            this.lblSugar.Text = "100%";
            this.lblSugar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIce
            // 
            this.lblIce.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIce.AutoSize = true;
            this.lblIce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIce.Location = new System.Drawing.Point(56, 32);
            this.lblIce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIce.Name = "lblIce";
            this.lblIce.Size = new System.Drawing.Size(75, 17);
            this.lblIce.TabIndex = 32;
            this.lblIce.Text = "Normal Ice";
            this.lblIce.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTopping
            // 
            this.lblTopping.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTopping.AutoSize = true;
            this.lblTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopping.Location = new System.Drawing.Point(10, 50);
            this.lblTopping.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(49, 17);
            this.lblTopping.TabIndex = 33;
            this.lblTopping.Text = "Cream";
            this.lblTopping.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(188, 10);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(40, 20);
            this.txtQty.TabIndex = 34;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // UCOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblTopping);
            this.Controls.Add(this.lblIce);
            this.Controls.Add(this.lblSugar);
            this.Controls.Add(this.lblCupSize);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblItem);
            this.Name = "UCOrder";
            this.Size = new System.Drawing.Size(528, 71);
            this.Load += new System.EventHandler(this.UCOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCupSize;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.Label lblIce;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.TextBox txtQty;
    }
}
