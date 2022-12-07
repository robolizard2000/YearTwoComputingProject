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
    public partial class frm_standard_config : Form{
        #region classes
        class function_thing
        {
            public string function { get; set; }
            public int function_id { get; set; }
        }
        class standard_thing{
            public string standard { get; set; }
            public int standard_id { get; set; }
        }
        #endregion
        public frm_standard_config(){
            InitializeComponent();
        }
        public string selected_model = "SRL-1 1 ohm";
        public int selected_modle_id = 1;
        public int selected_function_id = 1;
        private void cb_selected_standard_SelectedIndexChanged(object sender, EventArgs e){

        }

        private void cb_selected_function_SelectedIndexChanged(object sender, EventArgs e){

        }

        private void txt_persision_TextChanged(object sender, EventArgs e){

        }

        private void txt_actual_value_TextChanged(object sender, EventArgs e){

        }

        private void btn_add_function_Click(object sender, EventArgs e){

        }

        private void frm_standard_config_Load(object sender, EventArgs e){

        }
    }
}
