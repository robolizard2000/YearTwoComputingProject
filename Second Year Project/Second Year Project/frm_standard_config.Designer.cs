namespace Second_Year_Project
{
    partial class frm_standard_config
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
            this.btn_add_function = new System.Windows.Forms.Button();
            this.lbl_function_name = new System.Windows.Forms.Label();
            this.cb_selected_function = new System.Windows.Forms.ComboBox();
            this.lbl_standard_name = new System.Windows.Forms.Label();
            this.cb_selected_standard = new System.Windows.Forms.ComboBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.list_current_standards = new System.Windows.Forms.ListView();
            this.Measurement_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Function = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.persision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actual_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_persision = new System.Windows.Forms.Label();
            this.txt_persision = new System.Windows.Forms.TextBox();
            this.txt_actual_value = new System.Windows.Forms.TextBox();
            this.lbl_actual_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add_function
            // 
            this.btn_add_function.Location = new System.Drawing.Point(425, 197);
            this.btn_add_function.Name = "btn_add_function";
            this.btn_add_function.Size = new System.Drawing.Size(217, 51);
            this.btn_add_function.TabIndex = 37;
            this.btn_add_function.Text = "Add Function";
            this.btn_add_function.UseVisualStyleBackColor = true;
            this.btn_add_function.Click += new System.EventHandler(this.btn_add_function_Click);
            // 
            // lbl_function_name
            // 
            this.lbl_function_name.AutoSize = true;
            this.lbl_function_name.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_function_name.Location = new System.Drawing.Point(421, 88);
            this.lbl_function_name.Name = "lbl_function_name";
            this.lbl_function_name.Size = new System.Drawing.Size(104, 19);
            this.lbl_function_name.TabIndex = 36;
            this.lbl_function_name.Text = "Function Name";
            // 
            // cb_selected_function
            // 
            this.cb_selected_function.FormattingEnabled = true;
            this.cb_selected_function.Location = new System.Drawing.Point(527, 86);
            this.cb_selected_function.Name = "cb_selected_function";
            this.cb_selected_function.Size = new System.Drawing.Size(115, 21);
            this.cb_selected_function.TabIndex = 35;
            this.cb_selected_function.SelectedIndexChanged += new System.EventHandler(this.cb_selected_function_SelectedIndexChanged);
            // 
            // lbl_standard_name
            // 
            this.lbl_standard_name.AutoSize = true;
            this.lbl_standard_name.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_standard_name.Location = new System.Drawing.Point(421, 55);
            this.lbl_standard_name.Name = "lbl_standard_name";
            this.lbl_standard_name.Size = new System.Drawing.Size(106, 19);
            this.lbl_standard_name.TabIndex = 34;
            this.lbl_standard_name.Text = "Standard Name";
            // 
            // cb_selected_standard
            // 
            this.cb_selected_standard.FormattingEnabled = true;
            this.cb_selected_standard.Location = new System.Drawing.Point(527, 53);
            this.cb_selected_standard.Name = "cb_selected_standard";
            this.cb_selected_standard.Size = new System.Drawing.Size(115, 21);
            this.cb_selected_standard.TabIndex = 33;
            this.cb_selected_standard.SelectedIndexChanged += new System.EventHandler(this.cb_selected_standard_SelectedIndexChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(13, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(224, 40);
            this.lbl_title.TabIndex = 32;
            this.lbl_title.Text = "Config Standard";
            // 
            // list_current_standards
            // 
            this.list_current_standards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Measurement_ID,
            this.Model,
            this.Function,
            this.persision,
            this.actual_value});
            this.list_current_standards.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_current_standards.HideSelection = false;
            this.list_current_standards.Location = new System.Drawing.Point(13, 53);
            this.list_current_standards.Name = "list_current_standards";
            this.list_current_standards.Size = new System.Drawing.Size(400, 387);
            this.list_current_standards.TabIndex = 31;
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
            this.Function.Width = 75;
            // 
            // persision
            // 
            this.persision.Text = "Persision";
            this.persision.Width = 114;
            // 
            // actual_value
            // 
            this.actual_value.Text = "Actual Value";
            this.actual_value.Width = 107;
            // 
            // lbl_persision
            // 
            this.lbl_persision.AutoSize = true;
            this.lbl_persision.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_persision.Location = new System.Drawing.Point(421, 121);
            this.lbl_persision.Name = "lbl_persision";
            this.lbl_persision.Size = new System.Drawing.Size(65, 19);
            this.lbl_persision.TabIndex = 38;
            this.lbl_persision.Text = "Persision";
            // 
            // txt_persision
            // 
            this.txt_persision.Location = new System.Drawing.Point(527, 121);
            this.txt_persision.Name = "txt_persision";
            this.txt_persision.Size = new System.Drawing.Size(115, 20);
            this.txt_persision.TabIndex = 39;
            this.txt_persision.TextChanged += new System.EventHandler(this.txt_persision_TextChanged);
            // 
            // txt_actual_value
            // 
            this.txt_actual_value.Location = new System.Drawing.Point(527, 154);
            this.txt_actual_value.Name = "txt_actual_value";
            this.txt_actual_value.Size = new System.Drawing.Size(115, 20);
            this.txt_actual_value.TabIndex = 41;
            this.txt_actual_value.TextChanged += new System.EventHandler(this.txt_actual_value_TextChanged);
            // 
            // lbl_actual_value
            // 
            this.lbl_actual_value.AutoSize = true;
            this.lbl_actual_value.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actual_value.Location = new System.Drawing.Point(421, 154);
            this.lbl_actual_value.Name = "lbl_actual_value";
            this.lbl_actual_value.Size = new System.Drawing.Size(87, 19);
            this.lbl_actual_value.TabIndex = 40;
            this.lbl_actual_value.Text = "Actual Value";
            // 
            // frm_standard_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 451);
            this.Controls.Add(this.txt_actual_value);
            this.Controls.Add(this.lbl_actual_value);
            this.Controls.Add(this.txt_persision);
            this.Controls.Add(this.lbl_persision);
            this.Controls.Add(this.btn_add_function);
            this.Controls.Add(this.lbl_function_name);
            this.Controls.Add(this.cb_selected_function);
            this.Controls.Add(this.lbl_standard_name);
            this.Controls.Add(this.cb_selected_standard);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.list_current_standards);
            this.Name = "frm_standard_config";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frm_standard_config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_function;
        private System.Windows.Forms.Label lbl_function_name;
        private System.Windows.Forms.ComboBox cb_selected_function;
        private System.Windows.Forms.Label lbl_standard_name;
        private System.Windows.Forms.ComboBox cb_selected_standard;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ListView list_current_standards;
        private System.Windows.Forms.ColumnHeader Measurement_ID;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Function;
        private System.Windows.Forms.ColumnHeader persision;
        private System.Windows.Forms.Label lbl_persision;
        private System.Windows.Forms.TextBox txt_persision;
        private System.Windows.Forms.TextBox txt_actual_value;
        private System.Windows.Forms.Label lbl_actual_value;
        private System.Windows.Forms.ColumnHeader actual_value;
    }
}