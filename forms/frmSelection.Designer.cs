namespace cafe_pos_system
{
    partial class frmSelection
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAddIce = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCupSize = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmbSugar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTopping = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.chkAddIce);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbCupSize);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.cmbSugar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbTopping);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 349);
            this.panel1.TabIndex = 0;
            // 
            // chkAddIce
            // 
            this.chkAddIce.AutoSize = true;
            this.chkAddIce.Checked = true;
            this.chkAddIce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddIce.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddIce.Location = new System.Drawing.Point(204, 233);
            this.chkAddIce.Name = "chkAddIce";
            this.chkAddIce.Size = new System.Drawing.Size(112, 30);
            this.chkAddIce.TabIndex = 3;
            this.chkAddIce.Text = "Add Ice";
            this.chkAddIce.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cup Size:";
            // 
            // cmbCupSize
            // 
            this.cmbCupSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCupSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmbCupSize.FormattingEnabled = true;
            this.cmbCupSize.IntegralHeight = false;
            this.cmbCupSize.ItemHeight = 24;
            this.cmbCupSize.Items.AddRange(new object[] {
            "Small\t\t+$0.00",
            "Medium\t\t+$0.30",
            "Large\t\t+$0.50"});
            this.cmbCupSize.Location = new System.Drawing.Point(164, 183);
            this.cmbCupSize.Name = "cmbCupSize";
            this.cmbCupSize.Size = new System.Drawing.Size(337, 32);
            this.cmbCupSize.TabIndex = 2;
            this.cmbCupSize.Tag = "Cup Size";
            this.cmbCupSize.Text = "Select Suger Level";
            this.cmbCupSize.DropDown += new System.EventHandler(this.cbCup_DropDown);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(216)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnCancel.Location = new System.Drawing.Point(302, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(199, 38);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(216)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnConfirm.Location = new System.Drawing.Point(35, 287);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(199, 38);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmbSugar
            // 
            this.cmbSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmbSugar.FormattingEnabled = true;
            this.cmbSugar.IntegralHeight = false;
            this.cmbSugar.ItemHeight = 24;
            this.cmbSugar.Items.AddRange(new object[] {
            "25%",
            "50%",
            "75%",
            "100%"});
            this.cmbSugar.Location = new System.Drawing.Point(164, 123);
            this.cmbSugar.Name = "cmbSugar";
            this.cmbSugar.Size = new System.Drawing.Size(337, 32);
            this.cmbSugar.TabIndex = 1;
            this.cmbSugar.Tag = "Sugar Level";
            this.cmbSugar.Text = "Select Suger Level";
            this.cmbSugar.DropDown += new System.EventHandler(this.cbSuger_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selection";
            // 
            // cmbTopping
            // 
            this.cmbTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTopping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmbTopping.FormattingEnabled = true;
            this.cmbTopping.IntegralHeight = false;
            this.cmbTopping.ItemHeight = 24;
            this.cmbTopping.Items.AddRange(new object[] {
            "None\t\t+$0.00",
            "Bobba\t\t+$0.5\t",
            "Coconut\t\t+$0.5",
            "Cream\t\t+$0.5",
            "Ice Cream\t\t+$0.5",
            "Jelly\t\t+$0.5"});
            this.cmbTopping.Location = new System.Drawing.Point(164, 61);
            this.cmbTopping.Name = "cmbTopping";
            this.cmbTopping.Size = new System.Drawing.Size(337, 32);
            this.cmbTopping.TabIndex = 0;
            this.cmbTopping.Tag = "Topping";
            this.cmbTopping.Text = "Select a Topping";
            this.cmbTopping.DropDown += new System.EventHandler(this.cbTopping_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sugar Level:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Topping:";
            // 
            // frmSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 349);
            this.Controls.Add(this.panel1);
            this.Name = "frmSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSugar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmbTopping;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCupSize;
        private System.Windows.Forms.CheckBox chkAddIce;
    }
}