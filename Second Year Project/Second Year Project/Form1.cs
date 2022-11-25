using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Year_Project{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        #region Buttons to forms
        private void btn_new_device_Click(object sender, EventArgs e){frm_new_device frm = new frm_new_device();frm.Show();}

        private void btn_new_standard_Click(object sender, EventArgs e){ frm_new_standard frm = new frm_new_standard(); frm.Show(); }

        private void btn_edit_functions_Click(object sender, EventArgs e){}

        private void btn_test_device_Click(object sender, EventArgs e){}

        private void btn_test_standard_Click(object sender, EventArgs e){ }
        #endregion

        private void btn_config_device_Click(object sender, EventArgs e){frm_device_config frm = new frm_device_config(); frm.Show();}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
