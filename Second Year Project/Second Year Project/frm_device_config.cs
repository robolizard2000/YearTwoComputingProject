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
        public void DisplayData(){
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT Measurement_ID, Model, Function FROM Measurement_output, Measurement_device, Functions WHERE Model_ID.Measurement_output = Model.Measurement_device";
            dr = dbConnector.DoSQL(sqlStr);
            list_current_standards.Items.Clear();
            while (dr.Read()){
                list_current_standards.Items.Add(dr[0].ToString());
                list_current_standards.Items[list_current_standards.Items.Count - 1].SubItems.Add(dr[1].ToString());
                list_current_standards.Items[list_current_standards.Items.Count - 1].SubItems.Add(dr[2].ToString());
                list_current_standards.Items[list_current_standards.Items.Count - 1].SubItems.Add(dr[3].ToString());
            }
            dbConnector.Close();
        }

        private void frm_device_config_Load(object sender, EventArgs e){
            DisplayData();
        }
    }
}
