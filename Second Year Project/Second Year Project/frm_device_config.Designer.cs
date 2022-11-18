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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.Function});
            this.list_current_standards.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(515, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // frm_device_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 451);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.list_current_standards);
            this.Name = "frm_device_config";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frm_device_config_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ListView list_current_standards;
        private System.Windows.Forms.ColumnHeader Measurement_ID;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Function;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}