namespace Second_Year_Project
{
    partial class frm_new_standard
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
            this.btn_create = new System.Windows.Forms.Button();
            this.date_DOC = new System.Windows.Forms.DateTimePicker();
            this.lbl_date_of_cal = new System.Windows.Forms.Label();
            this.date_DOP = new System.Windows.Forms.DateTimePicker();
            this.lbl_date_of_purchase = new System.Windows.Forms.Label();
            this.lbl_standard_name = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_standard_name = new System.Windows.Forms.TextBox();
            this.list_current_standards = new System.Windows.Forms.ListView();
            this.Standard_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_of_purchase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_of_cal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(419, 180);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(336, 35);
            this.btn_create.TabIndex = 22;
            this.btn_create.Text = "Create New Device";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // date_DOC
            // 
            this.date_DOC.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_DOC.Location = new System.Drawing.Point(554, 140);
            this.date_DOC.Name = "date_DOC";
            this.date_DOC.Size = new System.Drawing.Size(200, 25);
            this.date_DOC.TabIndex = 21;
            // 
            // lbl_date_of_cal
            // 
            this.lbl_date_of_cal.AutoSize = true;
            this.lbl_date_of_cal.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_of_cal.Location = new System.Drawing.Point(419, 140);
            this.lbl_date_of_cal.Name = "lbl_date_of_cal";
            this.lbl_date_of_cal.Size = new System.Drawing.Size(82, 19);
            this.lbl_date_of_cal.TabIndex = 20;
            this.lbl_date_of_cal.Text = "Date Of Cal";
            // 
            // date_DOP
            // 
            this.date_DOP.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_DOP.Location = new System.Drawing.Point(554, 100);
            this.date_DOP.Name = "date_DOP";
            this.date_DOP.Size = new System.Drawing.Size(200, 25);
            this.date_DOP.TabIndex = 19;
            // 
            // lbl_date_of_purchase
            // 
            this.lbl_date_of_purchase.AutoSize = true;
            this.lbl_date_of_purchase.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_of_purchase.Location = new System.Drawing.Point(419, 100);
            this.lbl_date_of_purchase.Name = "lbl_date_of_purchase";
            this.lbl_date_of_purchase.Size = new System.Drawing.Size(118, 19);
            this.lbl_date_of_purchase.TabIndex = 18;
            this.lbl_date_of_purchase.Text = "Date Of Purchase";
            // 
            // lbl_standard_name
            // 
            this.lbl_standard_name.AutoSize = true;
            this.lbl_standard_name.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_standard_name.Location = new System.Drawing.Point(419, 60);
            this.lbl_standard_name.Name = "lbl_standard_name";
            this.lbl_standard_name.Size = new System.Drawing.Size(106, 19);
            this.lbl_standard_name.TabIndex = 15;
            this.lbl_standard_name.Text = "Standard Name";
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(419, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(190, 40);
            this.lbl_title.TabIndex = 14;
            this.lbl_title.Text = "New Standard";
            // 
            // txt_standard_name
            // 
            this.txt_standard_name.Location = new System.Drawing.Point(554, 60);
            this.txt_standard_name.Name = "txt_standard_name";
            this.txt_standard_name.Size = new System.Drawing.Size(200, 20);
            this.txt_standard_name.TabIndex = 13;
            // 
            // list_current_standards
            // 
            this.list_current_standards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Standard_ID,
            this.Model,
            this.Date_of_purchase,
            this.Date_of_cal});
            this.list_current_standards.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_current_standards.HideSelection = false;
            this.list_current_standards.Location = new System.Drawing.Point(9, 10);
            this.list_current_standards.Name = "list_current_standards";
            this.list_current_standards.Size = new System.Drawing.Size(400, 430);
            this.list_current_standards.TabIndex = 12;
            this.list_current_standards.UseCompatibleStateImageBehavior = false;
            this.list_current_standards.View = System.Windows.Forms.View.Details;
            // 
            // Standard_ID
            // 
            this.Standard_ID.Text = "ID";
            this.Standard_ID.Width = 25;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 75;
            // 
            // Date_of_purchase
            // 
            this.Date_of_purchase.Text = "Date Of Purchase";
            this.Date_of_purchase.Width = 142;
            // 
            // Date_of_cal
            // 
            this.Date_of_cal.Text = "Date Of Cal";
            this.Date_of_cal.Width = 148;
            // 
            // frm_new_standard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 451);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.date_DOC);
            this.Controls.Add(this.lbl_date_of_cal);
            this.Controls.Add(this.date_DOP);
            this.Controls.Add(this.lbl_date_of_purchase);
            this.Controls.Add(this.lbl_standard_name);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_standard_name);
            this.Controls.Add(this.list_current_standards);
            this.Name = "frm_new_standard";
            this.Text = "New Standard";
            this.Load += new System.EventHandler(this.frm_new_standard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.DateTimePicker date_DOC;
        private System.Windows.Forms.Label lbl_date_of_cal;
        private System.Windows.Forms.DateTimePicker date_DOP;
        private System.Windows.Forms.Label lbl_date_of_purchase;
        private System.Windows.Forms.Label lbl_standard_name;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_standard_name;
        private System.Windows.Forms.ListView list_current_standards;
        private System.Windows.Forms.ColumnHeader Standard_ID;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Date_of_purchase;
        private System.Windows.Forms.ColumnHeader Date_of_cal;
    }
}