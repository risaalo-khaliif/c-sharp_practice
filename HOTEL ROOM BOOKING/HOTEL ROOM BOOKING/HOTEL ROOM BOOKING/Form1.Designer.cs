namespace HOTEL_ROOM_BOOKING
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtguests = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblGuestAge = new System.Windows.Forms.Label();
            this.lblNumberOfNights = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.radHigh = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(629, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(323, 372);
            this.listBox1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(239, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(239, 112);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(228, 22);
            this.txtAge.TabIndex = 2;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(239, 163);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(228, 22);
            this.txtNights.TabIndex = 3;
            // 
            // txtguests
            // 
            this.txtguests.Location = new System.Drawing.Point(239, 209);
            this.txtguests.Name = "txtguests";
            this.txtguests.Size = new System.Drawing.Size(228, 22);
            this.txtguests.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Personal Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(46, 76);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(103, 20);
            this.lblGuestName.TabIndex = 6;
            this.lblGuestName.Text = "Guest Name";
            // 
            // lblGuestAge
            // 
            this.lblGuestAge.AutoSize = true;
            this.lblGuestAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestAge.Location = new System.Drawing.Point(46, 127);
            this.lblGuestAge.Name = "lblGuestAge";
            this.lblGuestAge.Size = new System.Drawing.Size(88, 20);
            this.lblGuestAge.TabIndex = 7;
            this.lblGuestAge.Text = "Guest Age";
            // 
            // lblNumberOfNights
            // 
            this.lblNumberOfNights.AutoSize = true;
            this.lblNumberOfNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfNights.Location = new System.Drawing.Point(46, 169);
            this.lblNumberOfNights.Name = "lblNumberOfNights";
            this.lblNumberOfNights.Size = new System.Drawing.Size(137, 20);
            this.lblNumberOfNights.TabIndex = 8;
            this.lblNumberOfNights.Text = "Number of nights";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(46, 215);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(137, 20);
            this.lblRoomType.TabIndex = 9;
            this.lblRoomType.Text = "Number of Guest";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "room type";
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(15, 346);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(81, 20);
            this.radStandard.TabIndex = 11;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(177, 346);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(69, 20);
            this.radNormal.TabIndex = 12;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "normal";
            this.radNormal.UseVisualStyleBackColor = true;
            // 
            // radHigh
            // 
            this.radHigh.AutoSize = true;
            this.radHigh.Location = new System.Drawing.Point(324, 346);
            this.radHigh.Name = "radHigh";
            this.radHigh.Size = new System.Drawing.Size(56, 20);
            this.radHigh.TabIndex = 13;
            this.radHigh.TabStop = true;
            this.radHigh.Text = "hight";
            this.radHigh.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "addditional options";
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBreakfast.Location = new System.Drawing.Point(30, 448);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(338, 26);
            this.chkBreakfast.TabIndex = 15;
            this.chkBreakfast.Text = "break fast (10 per guest per night)";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Acumin Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(36, 494);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(203, 39);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(254, 494);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(228, 39);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(502, 494);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(213, 39);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 566);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkBreakfast);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radHigh);
            this.Controls.Add(this.radNormal);
            this.Controls.Add(this.radStandard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblNumberOfNights);
            this.Controls.Add(this.lblGuestAge);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtguests);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtguests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblGuestAge;
        private System.Windows.Forms.Label lblNumberOfNights;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radNormal;
        private System.Windows.Forms.RadioButton radHigh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

