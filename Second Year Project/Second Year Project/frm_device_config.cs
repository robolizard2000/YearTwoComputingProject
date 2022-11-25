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
        public frm_device_config(){
            InitializeComponent();
        }
        public string selected_model = "UT61E";
        public void DisplayData(){
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
            DisplayData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){
            selected_model = cb_selected_device.GetItemText(cb_selected_device.SelectedIndex);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
