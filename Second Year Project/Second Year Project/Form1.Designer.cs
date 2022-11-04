namespace Second_Year_Project
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_new_device = new System.Windows.Forms.Button();
            this.btn_update_device = new System.Windows.Forms.Button();
            this.btn_update_standard = new System.Windows.Forms.Button();
            this.btn_new_standard = new System.Windows.Forms.Button();
            this.btn_test_device = new System.Windows.Forms.Button();
            this.btn_edit_functions = new System.Windows.Forms.Button();
            this.btn_test_standard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(100, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(300, 40);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Test Equipement Hub";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_new_device
            // 
            this.btn_new_device.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_device.Location = new System.Drawing.Point(100, 70);
            this.btn_new_device.Name = "btn_new_device";
            this.btn_new_device.Size = new System.Drawing.Size(300, 40);
            this.btn_new_device.TabIndex = 1;
            this.btn_new_device.Text = "Add New Measurement Device";
            this.btn_new_device.UseVisualStyleBackColor = true;
            this.btn_new_device.Click += new System.EventHandler(this.btn_new_device_Click);
            // 
            // btn_update_device
            // 
            this.btn_update_device.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_device.Location = new System.Drawing.Point(100, 116);
            this.btn_update_device.Name = "btn_update_device";
            this.btn_update_device.Size = new System.Drawing.Size(300, 40);
            this.btn_update_device.TabIndex = 2;
            this.btn_update_device.Text = "Update Measurement Device";
            this.btn_update_device.UseVisualStyleBackColor = true;
            this.btn_update_device.Click += new System.EventHandler(this.btn_update_device_Click);
            // 
            // btn_update_standard
            // 
            this.btn_update_standard.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_standard.Location = new System.Drawing.Point(100, 208);
            this.btn_update_standard.Name = "btn_update_standard";
            this.btn_update_standard.Size = new System.Drawing.Size(300, 40);
            this.btn_update_standard.TabIndex = 4;
            this.btn_update_standard.Text = "Update Standard";
            this.btn_update_standard.UseVisualStyleBackColor = true;
            this.btn_update_standard.Click += new System.EventHandler(this.btn_update_standard_Click);
            // 
            // btn_new_standard
            // 
            this.btn_new_standard.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_standard.Location = new System.Drawing.Point(100, 162);
            this.btn_new_standard.Name = "btn_new_standard";
            this.btn_new_standard.Size = new System.Drawing.Size(300, 40);
            this.btn_new_standard.TabIndex = 3;
            this.btn_new_standard.Text = "Add New Standard";
            this.btn_new_standard.UseVisualStyleBackColor = true;
            this.btn_new_standard.Click += new System.EventHandler(this.btn_new_standard_Click);
            // 
            // btn_test_device
            // 
            this.btn_test_device.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_test_device.Location = new System.Drawing.Point(100, 300);
            this.btn_test_device.Name = "btn_test_device";
            this.btn_test_device.Size = new System.Drawing.Size(300, 40);
            this.btn_test_device.TabIndex = 6;
            this.btn_test_device.Text = "Test Measurement Device";
            this.btn_test_device.UseVisualStyleBackColor = true;
            this.btn_test_device.Click += new System.EventHandler(this.btn_test_device_Click);
            // 
            // btn_edit_functions
            // 
            this.btn_edit_functions.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_functions.Location = new System.Drawing.Point(100, 254);
            this.btn_edit_functions.Name = "btn_edit_functions";
            this.btn_edit_functions.Size = new System.Drawing.Size(300, 40);
            this.btn_edit_functions.TabIndex = 5;
            this.btn_edit_functions.Text = "Edit Functions And Ranges";
            this.btn_edit_functions.UseVisualStyleBackColor = true;
            this.btn_edit_functions.Click += new System.EventHandler(this.btn_edit_functions_Click);
            // 
            // btn_test_standard
            // 
            this.btn_test_standard.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_test_standard.Location = new System.Drawing.Point(100, 346);
            this.btn_test_standard.Name = "btn_test_standard";
            this.btn_test_standard.Size = new System.Drawing.Size(300, 40);
            this.btn_test_standard.TabIndex = 7;
            this.btn_test_standard.Text = "Test Standard";
            this.btn_test_standard.UseVisualStyleBackColor = true;
            this.btn_test_standard.Click += new System.EventHandler(this.btn_test_standard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.btn_test_standard);
            this.Controls.Add(this.btn_test_device);
            this.Controls.Add(this.btn_edit_functions);
            this.Controls.Add(this.btn_update_standard);
            this.Controls.Add(this.btn_new_standard);
            this.Controls.Add(this.btn_update_device);
            this.Controls.Add(this.btn_new_device);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_new_device;
        private System.Windows.Forms.Button btn_update_device;
        private System.Windows.Forms.Button btn_update_standard;
        private System.Windows.Forms.Button btn_new_standard;
        private System.Windows.Forms.Button btn_test_device;
        private System.Windows.Forms.Button btn_edit_functions;
        private System.Windows.Forms.Button btn_test_standard;
    }
}

