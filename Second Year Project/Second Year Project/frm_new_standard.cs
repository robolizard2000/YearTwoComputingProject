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
    public partial class frm_new_standard: Form { 
        public frm_new_standard(){
            InitializeComponent();
        }
        public void DisplayData(){
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT Standard_ID, Model, Date_of_purchase, Date_of_cal FROM Standards";
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
        private void btn_create_Click(object sender, EventArgs e){
            clsDBConnector dbConnector = new clsDBConnector();
            string standard_name = txt_standard_name.Text;
            string cmdStr = $"INSERT INTO Standards (Model, Date_of_purchase, Date_of_cal) " +
                $"VALUES ('{standard_name}' , '{date_DOP.Value.Date}', '{date_DOC.Value.Date}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            DisplayData();
        }

        private void frm_new_standard_Load(object sender, EventArgs e){
            DisplayData();
        }
    }
}
