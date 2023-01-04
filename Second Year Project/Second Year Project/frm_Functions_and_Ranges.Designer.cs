
namespace Second_Year_Project
{
    partial class frm_Functions_and_Ranges
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
            this.btn_edit_function = new System.Windows.Forms.Button();
            this.txt_exponent = new System.Windows.Forms.TextBox();
            this.lbl_exponent = new System.Windows.Forms.Label();
            this.btn_add_function = new System.Windows.Forms.Button();
            this.lbl_function_symbol = new System.Windows.Forms.Label();
            this.lbl_function_name = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.list_current_standards = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Function_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Function_symbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Exponent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_function_name = new System.Windows.Forms.TextBox();
            this.txt_function_symbol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_edit_function
            // 
            this.btn_edit_function.Location = new System.Drawing.Point(425, 207);
            this.btn_edit_function.Name = "btn_edit_function";
            this.btn_edit_function.Size = new System.Drawing.Size(222, 51);
            this.btn_edit_function.TabIndex = 54;
            this.btn_edit_function.Text = "Edit Function";
            this.btn_edit_function.UseVisualStyleBackColor = true;
            // 
            // txt_exponent
            // 
            this.txt_exponent.Location = new System.Drawing.Point(532, 121);
            this.txt_exponent.Name = "txt_exponent";
            this.txt_exponent.Size = new System.Drawing.Size(115, 20);
            this.txt_exponent.TabIndex = 51;
            // 
            // lbl_exponent
            // 
            this.lbl_exponent.AutoSize = true;
            this.lbl_exponent.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exponent.Location = new System.Drawing.Point(421, 121);
            this.lbl_exponent.Name = "lbl_exponent";
            this.lbl_exponent.Size = new System.Drawing.Size(67, 19);
            this.lbl_exponent.TabIndex = 50;
            this.lbl_exponent.Text = "Exponent";
            // 
            // btn_add_function
            // 
            this.btn_add_function.Location = new System.Drawing.Point(425, 150);
            this.btn_add_function.Name = "btn_add_function";
            this.btn_add_function.Size = new System.Drawing.Size(222, 51);
            this.btn_add_function.TabIndex = 49;
            this.btn_add_function.Text = "Add Function";
            this.btn_add_function.UseVisualStyleBackColor = true;
            // 
            // lbl_function_symbol
            // 
            this.lbl_function_symbol.AutoSize = true;
            this.lbl_function_symbol.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_function_symbol.Location = new System.Drawing.Point(421, 88);
            this.lbl_function_symbol.Name = "lbl_function_symbol";
            this.lbl_function_symbol.Size = new System.Drawing.Size(112, 19);
            this.lbl_function_symbol.TabIndex = 48;
            this.lbl_function_symbol.Text = "Function symbol";
            // 
            // lbl_function_name
            // 
            this.lbl_function_name.AutoSize = true;
            this.lbl_function_name.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_function_name.Location = new System.Drawing.Point(421, 55);
            this.lbl_function_name.Name = "lbl_function_name";
            this.lbl_function_name.Size = new System.Drawing.Size(104, 19);
            this.lbl_function_name.TabIndex = 46;
            this.lbl_function_name.Text = "Function Name";
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(13, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(286, 40);
            this.lbl_title.TabIndex = 44;
            this.lbl_title.Text = "Functions and Ranges";
            // 
            // list_current_standards
            // 
            this.list_current_standards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Function_name,
            this.Function_symbol,
            this.Exponent});
            this.list_current_standards.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_current_standards.HideSelection = false;
            this.list_current_standards.Location = new System.Drawing.Point(19, 52);
            this.list_current_standards.Name = "list_current_standards";
            this.list_current_standards.Size = new System.Drawing.Size(400, 387);
            this.list_current_standards.TabIndex = 43;
            this.list_current_standards.UseCompatibleStateImageBehavior = false;
            this.list_current_standards.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 31;
            // 
            // Function_name
            // 
            this.Function_name.Text = "Function Name";
            this.Function_name.Width = 148;
            // 
            // Function_symbol
            // 
            this.Function_symbol.Text = "Function Symbol";
            this.Function_symbol.Width = 103;
            // 
            // Exponent
            // 
            this.Exponent.Text = "Exponent";
            this.Exponent.Width = 114;
            // 
            // txt_function_name
            // 
            this.txt_function_name.Location = new System.Drawing.Point(532, 55);
            this.txt_function_name.Name = "txt_function_name";
            this.txt_function_name.Size = new System.Drawing.Size(115, 20);
            this.txt_function_name.TabIndex = 55;
            // 
            // txt_function_symbol
            // 
            this.txt_function_symbol.Location = new System.Drawing.Point(532, 88);
            this.txt_function_symbol.Name = "txt_function_symbol";
            this.txt_function_symbol.Size = new System.Drawing.Size(115, 20);
            this.txt_function_symbol.TabIndex = 56;
            // 
            // frm_Functions_and_Ranges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 451);
            this.Controls.Add(this.txt_function_symbol);
            this.Controls.Add(this.txt_function_name);
            this.Controls.Add(this.btn_edit_function);
            this.Controls.Add(this.txt_exponent);
            this.Controls.Add(this.lbl_exponent);
            this.Controls.Add(this.btn_add_function);
            this.Controls.Add(this.lbl_function_symbol);
            this.Controls.Add(this.lbl_function_name);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.list_current_standards);
            this.Name = "frm_Functions_and_Ranges";
            this.Text = "frm_Functions_and_Ranges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit_function;
        private System.Windows.Forms.TextBox txt_exponent;
        private System.Windows.Forms.Label lbl_exponent;
        private System.Windows.Forms.Button btn_add_function;
        private System.Windows.Forms.Label lbl_function_symbol;
        private System.Windows.Forms.Label lbl_function_name;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ListView list_current_standards;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Function_name;
        private System.Windows.Forms.ColumnHeader Function_symbol;
        private System.Windows.Forms.ColumnHeader Exponent;
        private System.Windows.Forms.TextBox txt_function_name;
        private System.Windows.Forms.TextBox txt_function_symbol;
    }
}