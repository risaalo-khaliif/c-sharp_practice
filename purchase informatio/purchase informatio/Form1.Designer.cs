namespace purchase_informatio
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
            this.txtnumberofpackage = new System.Windows.Forms.TextBox();
            this.txtpriceperpackage = new System.Windows.Forms.TextBox();
            this.lblNumberofpackages = new System.Windows.Forms.Label();
            this.lblPriceperpackage = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtnumberofpackage
            // 
            this.txtnumberofpackage.Location = new System.Drawing.Point(361, 72);
            this.txtnumberofpackage.Name = "txtnumberofpackage";
            this.txtnumberofpackage.Size = new System.Drawing.Size(226, 26);
            this.txtnumberofpackage.TabIndex = 0;
            // 
            // txtpriceperpackage
            // 
            this.txtpriceperpackage.Location = new System.Drawing.Point(361, 119);
            this.txtpriceperpackage.Name = "txtpriceperpackage";
            this.txtpriceperpackage.Size = new System.Drawing.Size(226, 26);
            this.txtpriceperpackage.TabIndex = 1;
            // 
            // lblNumberofpackages
            // 
            this.lblNumberofpackages.AutoSize = true;
            this.lblNumberofpackages.Location = new System.Drawing.Point(209, 78);
            this.lblNumberofpackages.Name = "lblNumberofpackages";
            this.lblNumberofpackages.Size = new System.Drawing.Size(148, 20);
            this.lblNumberofpackages.TabIndex = 2;
            this.lblNumberofpackages.Text = "Numberofpackages";
            // 
            // lblPriceperpackage
            // 
            this.lblPriceperpackage.AutoSize = true;
            this.lblPriceperpackage.Location = new System.Drawing.Point(209, 125);
            this.lblPriceperpackage.Name = "lblPriceperpackage";
            this.lblPriceperpackage.Size = new System.Drawing.Size(128, 20);
            this.lblPriceperpackage.TabIndex = 3;
            this.lblPriceperpackage.Text = "Priceperpackage";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(66, 176);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(158, 115);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(243, 193);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(130, 60);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(391, 201);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(104, 65);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 20;
            this.lstResults.Location = new System.Drawing.Point(629, 72);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(301, 364);
            this.lstResults.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 475);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblPriceperpackage);
            this.Controls.Add(this.lblNumberofpackages);
            this.Controls.Add(this.txtpriceperpackage);
            this.Controls.Add(this.txtnumberofpackage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumberofpackage;
        private System.Windows.Forms.TextBox txtpriceperpackage;
        private System.Windows.Forms.Label lblNumberofpackages;
        private System.Windows.Forms.Label lblPriceperpackage;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox lstResults;
    }
}

