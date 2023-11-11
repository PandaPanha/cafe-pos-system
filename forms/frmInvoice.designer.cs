namespace cafe_pos_system.forms
{
    partial class frmInvoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ucInvoiceItem1 = new cafe_pos_system.forms.ucInvoiceItem();
            this.ucInvoiceItem2 = new cafe_pos_system.forms.ucInvoiceItem();
            this.ucInvoiceItem5 = new cafe_pos_system.forms.ucInvoiceItem();
            this.ucInvoiceItem6 = new cafe_pos_system.forms.ucInvoiceItem();
            this.ucInvoiceItem7 = new cafe_pos_system.forms.ucInvoiceItem();
            this.ucInvoiceItem8 = new cafe_pos_system.forms.ucInvoiceItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice ID   :\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Staff Name          :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date            :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "SubTotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Change Money";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(371, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "Wating No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(619, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "label11";
            
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(185, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(616, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 37);
            this.label13.TabIndex = 12;
            this.label13.Text = "15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(544, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(544, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(544, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(544, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 20);
            this.label17.TabIndex = 16;
            this.label17.Text = "label17";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(34, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 10);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(34, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 10);
            this.panel3.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 25);
            this.label18.TabIndex = 19;
            this.label18.Text = "Description";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(293, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 25);
            this.label19.TabIndex = 20;
            this.label19.Text = "Qty";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(411, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 25);
            this.label20.TabIndex = 21;
            this.label20.Text = "Price";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(543, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 25);
            this.label22.TabIndex = 23;
            this.label22.Text = "Amount";
            
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(3, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(634, 5);
            this.panel4.TabIndex = 24;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(13, 120);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 25);
            this.label23.TabIndex = 25;
            this.label23.Text = "Receive";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(170, 125);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 20);
            this.label24.TabIndex = 26;
            this.label24.Text = "label24";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ucInvoiceItem8);
            this.flowLayoutPanel1.Controls.Add(this.ucInvoiceItem1);
            this.flowLayoutPanel1.Controls.Add(this.ucInvoiceItem2);
            this.flowLayoutPanel1.Controls.Add(this.ucInvoiceItem5);
            this.flowLayoutPanel1.Controls.Add(this.ucInvoiceItem6);
            this.flowLayoutPanel1.Controls.Add(this.ucInvoiceItem7);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 298);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(645, 318);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Location = new System.Drawing.Point(34, 232);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(645, 60);
            this.panel5.TabIndex = 0;
            // 
            // ucInvoiceItem1
            // 
            this.ucInvoiceItem1.Location = new System.Drawing.Point(3, 53);
            this.ucInvoiceItem1.Name = "ucInvoiceItem1";
            this.ucInvoiceItem1.Size = new System.Drawing.Size(645, 44);
            this.ucInvoiceItem1.TabIndex = 24;
            // 
            // ucInvoiceItem2
            // 
            this.ucInvoiceItem2.Location = new System.Drawing.Point(3, 103);
            this.ucInvoiceItem2.Name = "ucInvoiceItem2";
            this.ucInvoiceItem2.Size = new System.Drawing.Size(645, 44);
            this.ucInvoiceItem2.TabIndex = 28;
            // 
            // ucInvoiceItem5
            // 
            this.ucInvoiceItem5.Location = new System.Drawing.Point(3, 153);
            this.ucInvoiceItem5.Name = "ucInvoiceItem5";
            this.ucInvoiceItem5.Size = new System.Drawing.Size(645, 44);
            this.ucInvoiceItem5.TabIndex = 31;
            // 
            // ucInvoiceItem6
            // 
            this.ucInvoiceItem6.Location = new System.Drawing.Point(3, 203);
            this.ucInvoiceItem6.Name = "ucInvoiceItem6";
            this.ucInvoiceItem6.Size = new System.Drawing.Size(645, 44);
            this.ucInvoiceItem6.TabIndex = 32;
            // 
            // ucInvoiceItem7
            // 
            this.ucInvoiceItem7.Location = new System.Drawing.Point(3, 253);
            this.ucInvoiceItem7.Name = "ucInvoiceItem7";
            this.ucInvoiceItem7.Size = new System.Drawing.Size(645, 44);
            this.ucInvoiceItem7.TabIndex = 33;
            // 
            // ucInvoiceItem8
            // 
            this.ucInvoiceItem8.Location = new System.Drawing.Point(3, 3);
            this.ucInvoiceItem8.Name = "ucInvoiceItem8";
            this.ucInvoiceItem8.Size = new System.Drawing.Size(645, 44);
            this.ucInvoiceItem8.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Location = new System.Drawing.Point(34, 630);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(648, 195);
            this.panel6.TabIndex = 28;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 888);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmInvoice";
            this.Text = "frmInvoice";
            
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private ucInvoiceItem ucInvoiceItem1;
        private ucInvoiceItem ucInvoiceItem2;
        private ucInvoiceItem ucInvoiceItem5;
        private ucInvoiceItem ucInvoiceItem6;
        private ucInvoiceItem ucInvoiceItem7;
        private ucInvoiceItem ucInvoiceItem8;
        private System.Windows.Forms.Panel panel6;
    }
}