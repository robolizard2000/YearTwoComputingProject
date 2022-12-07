using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Year_Project{
    public partial class frm_device_config : Form{

        class function_thing{
            public string function { get; set; }
            public int function_id { get; set; }
        }
        class device_thing{
            public string device { get; set; }
            public int device_id { get; set; }
        }


        public frm_device_config(){
            InitializeComponent();
        }
        public string selected_model = "UT61E";
        public int selected_modle_id = 0;
        public int selected_function_id = 0;
        public void DisplayData_model_list(){
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = $"SELECT        Measurement_device.Model, Functions.Function, Measurement_output.Measurement_ID, Functions.Function_name FROM((Measurement_device INNER JOIN Measurement_output ON Measurement_device.Device_ID = Measurement_output.Device_ID) INNER JOIN Functions ON Measurement_output.Fuction_ID = Functions.Function_ID) WHERE(Measurement_device.Model = '{selected_model}')";
            dr = dbConnector.DoSQL(sqlStr);
            list_current_standards.Items.Clear();
            while (dr.Read()){
                list_current_standards.Items.Add(dr[2].ToString());
                list_current_standards.Items[list_current_standards.Items.Count - 1].SubItems.Add(dr[0].ToString());
                list_current_standards.Items[list_current_standards.Items.Count - 1].SubItems.Add(dr[1].ToString());
                list_current_standards.Items[list_current_standards.Items.Count - 1].SubItems.Add(dr[3].ToString());
            }
            dbConnector.Close();
        }

        private void frm_device_config_Load(object sender, EventArgs e){
            DisplayData_model_list();

            #region Get ComboBox For Device Name
            List<device_thing> device_list = new List<device_thing>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = " SELECT Model, Device_ID FROM Measurement_device";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                device_list.Add(new device_thing { device = dr[0].ToString(), device_id = Convert.ToInt32(dr[1]) });
            }
            cb_selected_device.DisplayMember = "device";
            cb_selected_device.ValueMember = "device_id";
            cb_selected_device.DataSource = device_list;
            #endregion

            #region Get ComboBox For Function Name
            List<function_thing> function_list = new List<function_thing>();
            sqlStr = " SELECT Function_name, Function_ID FROM Functions";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read()){
                function_list.Add(new function_thing { function = dr[0].ToString(), function_id = Convert.ToInt32(dr[1]) });
            }
            cb_selected_function.DisplayMember = "function";
            cb_selected_function.ValueMember = "function_id";
            cb_selected_function.DataSource = function_list;
            dbConnector.Close();
            #endregion
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){
            selected_model = cb_selected_device.GetItemText(cb_selected_device.SelectedItem);
            selected_modle_id = Convert.ToInt32(cb_selected_device.SelectedIndex) + 1;
            
            DisplayData_model_list();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e){
            selected_function_id = 1 + Convert.ToInt32(cb_selected_function.SelectedIndex);
            label2.Text = selected_function_id.ToString();
        }

        private void btn_add_function_Click(object sender, EventArgs e){
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = ($"INSERT INTO Measurement_output (Device_ID, Fuction_ID) " + 
                            $"VALUES({selected_modle_id},{selected_function_id})");
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            DisplayData_model_list();
        }
    }
}
