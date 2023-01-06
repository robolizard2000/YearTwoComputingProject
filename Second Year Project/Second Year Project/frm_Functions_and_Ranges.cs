﻿using System;
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
    public partial class frm_Functions_and_Ranges : Form{
        #region classes
            class function_thing{
                public string function { get; set; }
                public int function_id { get; set; }
            }
            class standard_thing{
                public string standard { get; set; }
                public int standard_id { get; set; }
            }
            class selected_data{
                public int ID { get; set; }
                public string Modle { get; set; }
                public string Function { get; set; }
                public double Persision { get; set; }
                public double Actual_Value { get; set; }
                public int Function_ID { get; set; }
            }
            #endregion
        public frm_Functions_and_Ranges(){
            InitializeComponent();
        }
        #region Selected data
        public string selected_model = "SRL-1 1 ohm";
        public int selected_modle_id = 1;
        public int selected_function_id = 1;
        public double selected_persision = 0.0;
        public double selected_actual_value = 0.0;
        public List<string> selected_data_hold = new List<string>();
        List<selected_data> selected_data_list = new List<selected_data>();
        #endregion

        #region Startup, get data form data base
        public void DisplayData_model_list()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = $"SELECT Standard_output.Output_ID, Standards.Model, Functions.Function, Standard_output.[Precision], Standard_output.Actual_Value,  Standard_output.Function_ID " +
                     $"FROM((Functions INNER JOIN " +
                     $"Standard_output ON Functions.Function_ID = Standard_output.Function_ID) INNER JOIN " +
                     $"Standards ON Standard_output.Standard_ID = Standards.Standard_ID) " +
                     $"WHERE       Standards.Model = '{selected_model}'";
            dr = dbConnector.DoSQL(sqlStr);
            list_current_standards.Items.Clear();
            selected_data_list = new List<selected_data>();
            while (dr.Read())
            {
                #region Add data to the deplay and list of classes 
                selected_data_hold.Clear();
                list_current_standards.Items.Add(dr[0].ToString());
                selected_data_hold.Add(dr[0].ToString());
                list_current_standards.Items[list_current_standards.Items.Count - 1].SubItems.Add(dr[1].ToString());
                selected_data_hold.Add(dr[1].ToString());
                list_current_standards.Items[list_current_standards.Items.Count - 1].SubItems.Add(dr[2].ToString());
                selected_data_hold.Add(dr[2].ToString());
                list_current_standards.Items[list_current_standards.Items.Count - 1].SubItems.Add(dr[3].ToString());
                selected_data_hold.Add(dr[3].ToString());
                list_current_standards.Items[list_current_standards.Items.Count - 1].SubItems.Add(dr[4].ToString());
                selected_data_hold.Add(dr[4].ToString());
                selected_data_hold.Add(dr[5].ToString());
                selected_data hold = new selected_data();
                hold.ID = Convert.ToInt32(selected_data_hold[0]);
                hold.Modle = selected_data_hold[1];
                hold.Function = selected_data_hold[2];
                hold.Persision = Convert.ToDouble(selected_data_hold[3]);
                hold.Actual_Value = Convert.ToDouble(selected_data_hold[4]);
                hold.Function_ID = Convert.ToInt32(selected_data_hold[5]);
                selected_data_list.Add(hold);
                #endregion
            }
            dbConnector.Close();
        }

        private void frm_standard_config_Load(object sender, EventArgs e)
        {
            DisplayData_model_list();
            #region Get ComboBox For Device Name
            List<standard_thing> device_list = new List<standard_thing>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = " SELECT        Model, Standard_ID FROM Standards";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                device_list.Add(new standard_thing { standard = dr[0].ToString(), standard_id = Convert.ToInt32(dr[1]) });
            }
            cb_selected_standard.DisplayMember = "standard";
            cb_selected_standard.ValueMember = "standard_id";
            cb_selected_standard.DataSource = device_list;
            #endregion

            #region Get ComboBox For Function Name
            List<function_thing> function_list = new List<function_thing>();
            sqlStr = " SELECT Function_name, Function_ID FROM Functions";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                function_list.Add(new function_thing { function = dr[0].ToString(), function_id = Convert.ToInt32(dr[1]) });
            }
            cb_selected_function.DisplayMember = "function";
            cb_selected_function.ValueMember = "function_id";
            cb_selected_function.DataSource = function_list;
            dbConnector.Close();
            #endregion
        }
        #endregion

    }
}
