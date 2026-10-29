namespace assigmentfile
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
            this.create_file = new System.Windows.Forms.Button();
            this.btn_delete_item_in_file = new System.Windows.Forms.Button();
            this.btn_remove_file = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_read_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_file
            // 
            this.create_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_file.Location = new System.Drawing.Point(71, 47);
            this.create_file.Name = "create_file";
            this.create_file.Size = new System.Drawing.Size(164, 76);
            this.create_file.TabIndex = 0;
            this.create_file.Text = "create file";
            this.create_file.UseVisualStyleBackColor = true;
            this.create_file.Click += new System.EventHandler(this.create_file_Click);
            // 
            // btn_delete_item_in_file
            // 
            this.btn_delete_item_in_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_item_in_file.Location = new System.Drawing.Point(71, 180);
            this.btn_delete_item_in_file.Name = "btn_delete_item_in_file";
            this.btn_delete_item_in_file.Size = new System.Drawing.Size(164, 76);
            this.btn_delete_item_in_file.TabIndex = 2;
            this.btn_delete_item_in_file.Text = "delete item in file";
            this.btn_delete_item_in_file.UseVisualStyleBackColor = true;
            this.btn_delete_item_in_file.Click += new System.EventHandler(this.btn_delete_item_in_file_Click);
            // 
            // btn_remove_file
            // 
            this.btn_remove_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_file.Location = new System.Drawing.Point(280, 180);
            this.btn_remove_file.Name = "btn_remove_file";
            this.btn_remove_file.Size = new System.Drawing.Size(164, 76);
            this.btn_remove_file.TabIndex = 3;
            this.btn_remove_file.Text = "remove file";
            this.btn_remove_file.UseVisualStyleBackColor = true;
            this.btn_remove_file.Click += new System.EventHandler(this.btn_remove_file_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(525, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 244);
            this.listBox1.TabIndex = 4;
            // 
            // btn_read_file
            // 
            this.btn_read_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read_file.Location = new System.Drawing.Point(293, 47);
            this.btn_read_file.Name = "btn_read_file";
            this.btn_read_file.Size = new System.Drawing.Size(164, 76);
            this.btn_read_file.TabIndex = 5;
            this.btn_read_file.Text = "read file";
            this.btn_read_file.UseVisualStyleBackColor = true;
            this.btn_read_file.Click += new System.EventHandler(this.btn_read_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 496);
            this.Controls.Add(this.btn_read_file);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_remove_file);
            this.Controls.Add(this.btn_delete_item_in_file);
            this.Controls.Add(this.create_file);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button create_file;
        private System.Windows.Forms.Button btn_delete_item_in_file;
        private System.Windows.Forms.Button btn_remove_file;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_read_file;
    }
}

