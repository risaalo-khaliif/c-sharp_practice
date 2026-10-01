namespace room
{
    partial class Form1
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
            this.txtguestnumber = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtPriceNight = new System.Windows.Forms.TextBox();
            this.lblServiceTax = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.TextBox();
            this.lblTotalAmoun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.ComboBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtguestnumber
            // 
            this.txtguestnumber.Location = new System.Drawing.Point(465, 73);
            this.txtguestnumber.Name = "txtguestnumber";
            this.txtguestnumber.Size = new System.Drawing.Size(223, 26);
            this.txtguestnumber.TabIndex = 0;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(465, 174);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(223, 26);
            this.txtNights.TabIndex = 2;
            // 
            // txtPriceNight
            // 
            this.txtPriceNight.Location = new System.Drawing.Point(465, 234);
            this.txtPriceNight.Name = "txtPriceNight";
            this.txtPriceNight.Size = new System.Drawing.Size(223, 26);
            this.txtPriceNight.TabIndex = 3;
            // 
            // lblServiceTax
            // 
            this.lblServiceTax.Location = new System.Drawing.Point(465, 420);
            this.lblServiceTax.Name = "lblServiceTax";
            this.lblServiceTax.Size = new System.Drawing.Size(223, 26);
            this.lblServiceTax.TabIndex = 4;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Location = new System.Drawing.Point(465, 477);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(223, 26);
            this.lblDiscount.TabIndex = 5;
            // 
            // lblTotalAmoun
            // 
            this.lblTotalAmoun.Location = new System.Drawing.Point(465, 525);
            this.lblTotalAmoun.Name = "lblTotalAmoun";
            this.lblTotalAmoun.Size = new System.Drawing.Size(223, 26);
            this.lblTotalAmoun.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ENTER ROOM TYPE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ENTER GUEST ROOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ENTER NUMBER OF nights";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ENTER PRICE PER NIGHT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "SERVICE TAX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Discount amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "TotalAmount";
            // 
            // txtRoomType
            // 
            this.txtRoomType.FormattingEnabled = true;
            this.txtRoomType.Items.AddRange(new object[] {
            "deluxe",
            "standard",
            "suite"});
            this.txtRoomType.Location = new System.Drawing.Point(465, 129);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(223, 28);
            this.txtRoomType.TabIndex = 14;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(283, 292);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(300, 64);
            this.btncalculate.TabIndex = 15;
            this.btncalculate.Text = "calculate booking";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 563);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalAmoun);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblServiceTax);
            this.Controls.Add(this.txtPriceNight);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtguestnumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtguestnumber;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtPriceNight;
        private System.Windows.Forms.TextBox lblServiceTax;
        private System.Windows.Forms.TextBox lblDiscount;
        private System.Windows.Forms.TextBox lblTotalAmoun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtRoomType;
        private System.Windows.Forms.Button btncalculate;
    }
}

