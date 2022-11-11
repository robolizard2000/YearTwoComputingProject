using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Second_Year_Project{
    public partial class frm_new_device : Form{
        public frm_new_device(){
            InitializeComponent();
        }
        public void DisplayData()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT Device_ID, Model, Count, Date_of_purchase, Date_of_cal FROM Measurement_device";
            dr = dbConnector.DoSQL(sqlStr);
            list_current_devices.Items.Clear();
            while (dr.Read())
            {
                list_current_devices.Items.Add(dr[0].ToString());
                list_current_devices.Items[list_current_devices.Items.Count - 1].SubItems.Add(dr[1].ToString());
                list_current_devices.Items[list_current_devices.Items.Count - 1].SubItems.Add(dr[2].ToString());
                list_current_devices.Items[list_current_devices.Items.Count - 1].SubItems.Add(dr[3].ToString());
                list_current_devices.Items[list_current_devices.Items.Count - 1].SubItems.Add(dr[4].ToString());
            }
            dbConnector.Close();
        }
        private void btn_create_Click(object sender, EventArgs e){
            
        }

        private void frm_new_device_Load(object sender, EventArgs e){
            DisplayData();
        }
    }
}
