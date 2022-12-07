namespace Second_Year_Project
{
    partial class frm_device_config
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
            this.list_current_standards = new System.Windows.Forms.ListView();
            this.Measurement_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Function = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.function_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_selected_device = new System.Windows.Forms.ComboBox();
            this.lbl_device_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_selected_function = new System.Windows.Forms.ComboBox();
            this.btn_add_function = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(190, 40);
            this.lbl_title.TabIndex = 25;
            this.lbl_title.Text = "Config Device";
            // 
            // list_current_standards
            // 
            this.list_current_standards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Measurement_ID,
            this.Model,
            this.Function,
            this.function_name});
            this.list_current_standards.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_current_standards.HideSelection = false;
            this.list_current_standards.Location = new System.Drawing.Point(12, 52);
            this.list_current_standards.Name = "list_current_standards";
            this.list_current_standards.Size = new System.Drawing.Size(400, 387);
            this.list_current_standards.TabIndex = 23;
            this.list_current_standards.UseCompatibleStateImageBehavior = false;
            this.list_current_standards.View = System.Windows.Forms.View.Details;
            // 
            // Measurement_ID
            // 
            this.Measurement_ID.Text = "ID";
            this.Measurement_ID.Width = 25;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 75;
            // 
            // Function
            // 
            this.Function.Text = "Function";
            this.Function.Width = 142;
            // 
            // function_name
            // 
            this.function_name.Text = "Function Name";
            this.function_name.Width = 153;
            // 
            // cb_selected_device
            // 
            this.cb_selected_device.FormattingEnabled = true;
            this.cb_selected_device.Location = new System.Drawing.Point(526, 52);
            this.cb_selected_device.Name = "cb_selected_device";
            this.cb_selected_device.Size = new System.Drawing.Size(115, 21);
            this.cb_selected_device.TabIndex = 26;
            this.cb_selected_device.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_device_name
            // 
            this.lbl_device_name.AutoSize = true;
            this.lbl_device_name.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_device_name.Location = new System.Drawing.Point(420, 54);
            this.lbl_device_name.Name = "lbl_device_name";
            this.lbl_device_name.Size = new System.Drawing.Size(92, 19);
            this.lbl_device_name.TabIndex = 27;
            this.lbl_device_name.Text = "Device Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Function Name";
            // 
            // cb_selected_function
            // 
            this.cb_selected_function.FormattingEnabled = true;
            this.cb_selected_function.Location = new System.Drawing.Point(526, 85);
            this.cb_selected_function.Name = "cb_selected_function";
            this.cb_selected_function.Size = new System.Drawing.Size(115, 21);
            this.cb_selected_function.TabIndex = 28;
            this.cb_selected_function.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btn_add_function
            // 
            this.btn_add_function.Location = new System.Drawing.Point(424, 121);
            this.btn_add_function.Name = "btn_add_function";
            this.btn_add_function.Size = new System.Drawing.Size(217, 51);
            this.btn_add_function.TabIndex = 30;
            this.btn_add_function.Text = "Add Function";
            this.btn_add_function.UseVisualStyleBackColor = true;
            this.btn_add_function.Click += new System.EventHandler(this.btn_add_function_Click);
            // 
            // frm_device_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 451);
            this.Controls.Add(this.btn_add_function);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_selected_function);
            this.Controls.Add(this.lbl_device_name);
            this.Controls.Add(this.cb_selected_device);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.list_current_standards);
            this.Name = "frm_device_config";
            this.Text = "Device Config";
            this.Load += new System.EventHandler(this.frm_device_config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ListView list_current_standards;
        private System.Windows.Forms.ColumnHeader Measurement_ID;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Function;
        private System.Windows.Forms.ComboBox cb_selected_device;
        private System.Windows.Forms.ColumnHeader function_name;
        private System.Windows.Forms.Label lbl_device_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_selected_function;
        private System.Windows.Forms.Button btn_add_function;
    }
}