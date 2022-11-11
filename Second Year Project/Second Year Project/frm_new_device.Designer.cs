namespace Second_Year_Project
{
    partial class frm_new_device
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
            this.list_current_devices = new System.Windows.Forms.ListView();
            this.txt_device_name = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_device_name = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.lbl_date_of_purchase = new System.Windows.Forms.Label();
            this.date_DOP = new System.Windows.Forms.DateTimePicker();
            this.date_DOC = new System.Windows.Forms.DateTimePicker();
            this.lbl_date_of_cal = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_current_devices
            // 
            this.list_current_devices.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_current_devices.HideSelection = false;
            this.list_current_devices.Location = new System.Drawing.Point(10, 10);
            this.list_current_devices.Name = "list_current_devices";
            this.list_current_devices.Size = new System.Drawing.Size(300, 430);
            this.list_current_devices.TabIndex = 1;
            this.list_current_devices.UseCompatibleStateImageBehavior = false;
            // 
            // txt_device_name
            // 
            this.txt_device_name.Location = new System.Drawing.Point(470, 60);
            this.txt_device_name.Name = "txt_device_name";
            this.txt_device_name.Size = new System.Drawing.Size(200, 20);
            this.txt_device_name.TabIndex = 2;
            this.txt_device_name.Text = "           ";
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(330, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(160, 40);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "New Device";
            // 
            // lbl_device_name
            // 
            this.lbl_device_name.AutoSize = true;
            this.lbl_device_name.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_device_name.Location = new System.Drawing.Point(330, 60);
            this.lbl_device_name.Name = "lbl_device_name";
            this.lbl_device_name.Size = new System.Drawing.Size(92, 19);
            this.lbl_device_name.TabIndex = 4;
            this.lbl_device_name.Text = "Device Name";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(330, 100);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(47, 19);
            this.lbl_count.TabIndex = 6;
            this.lbl_count.Text = "Count";
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(470, 100);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(200, 20);
            this.txt_count.TabIndex = 5;
            this.txt_count.Text = " ";
            // 
            // lbl_date_of_purchase
            // 
            this.lbl_date_of_purchase.AutoSize = true;
            this.lbl_date_of_purchase.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_of_purchase.Location = new System.Drawing.Point(330, 140);
            this.lbl_date_of_purchase.Name = "lbl_date_of_purchase";
            this.lbl_date_of_purchase.Size = new System.Drawing.Size(118, 19);
            this.lbl_date_of_purchase.TabIndex = 7;
            this.lbl_date_of_purchase.Text = "Date Of Purchase";
            // 
            // date_DOP
            // 
            this.date_DOP.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_DOP.Location = new System.Drawing.Point(470, 140);
            this.date_DOP.Name = "date_DOP";
            this.date_DOP.Size = new System.Drawing.Size(200, 25);
            this.date_DOP.TabIndex = 8;
            // 
            // date_DOC
            // 
            this.date_DOC.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_DOC.Location = new System.Drawing.Point(470, 180);
            this.date_DOC.Name = "date_DOC";
            this.date_DOC.Size = new System.Drawing.Size(200, 25);
            this.date_DOC.TabIndex = 10;
            // 
            // lbl_date_of_cal
            // 
            this.lbl_date_of_cal.AutoSize = true;
            this.lbl_date_of_cal.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_of_cal.Location = new System.Drawing.Point(330, 180);
            this.lbl_date_of_cal.Name = "lbl_date_of_cal";
            this.lbl_date_of_cal.Size = new System.Drawing.Size(82, 19);
            this.lbl_date_of_cal.TabIndex = 9;
            this.lbl_date_of_cal.Text = "Date Of Cal";
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(334, 219);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(336, 35);
            this.btn_create.TabIndex = 11;
            this.btn_create.Text = "Create New Device";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // frm_new_device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 451);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.date_DOC);
            this.Controls.Add(this.lbl_date_of_cal);
            this.Controls.Add(this.date_DOP);
            this.Controls.Add(this.lbl_date_of_purchase);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.lbl_device_name);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_device_name);
            this.Controls.Add(this.list_current_devices);
            this.Name = "frm_new_device";
            this.Text = "frm_new_device";
            this.Load += new System.EventHandler(this.frm_new_device_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_current_devices;
        private System.Windows.Forms.TextBox txt_device_name;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_device_name;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label lbl_date_of_purchase;
        private System.Windows.Forms.DateTimePicker date_DOP;
        private System.Windows.Forms.DateTimePicker date_DOC;
        private System.Windows.Forms.Label lbl_date_of_cal;
        private System.Windows.Forms.Button btn_create;
    }
}