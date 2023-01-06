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
                public int Function_ID { get; set; }
                public string Function { get; set; }
                public int Exponent { get; set; }
                public string Function_name { get; set; }
            }
            #endregion
        public frm_Functions_and_Ranges(){
            InitializeComponent();
        }
        #region Selected data
        public string selected_function_name = "";
        public string selected_function_symblo = "";
        public int selected_exponent = 0;
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
            sqlStr = $"SELECT Function_ID, Function, Exponent, Function_name " +
                     $"FROM (Functions) ";
            dr = dbConnector.DoSQL(sqlStr);
            list_current_functions.Items.Clear();
            selected_data_list = new List<selected_data>();
            while (dr.Read())
            {
                #region Add data to the deplay and list of classes 
                selected_data_hold.Clear();
                list_current_functions.Items.Add(dr[0].ToString());
                selected_data_hold.Add(dr[0].ToString());
                list_current_functions.Items[list_current_functions.Items.Count - 1].SubItems.Add(dr[1].ToString());
                selected_data_hold.Add(dr[1].ToString());
                list_current_functions.Items[list_current_functions.Items.Count - 1].SubItems.Add(dr[2].ToString());
                selected_data_hold.Add(dr[2].ToString());
                list_current_functions.Items[list_current_functions.Items.Count - 1].SubItems.Add(dr[3].ToString());
                selected_data_hold.Add(dr[3].ToString());
                selected_data hold = new selected_data();
                hold.Function_ID = Convert.ToInt32(selected_data_hold[0]);
                hold.Function = selected_data_hold[1];
                hold.Exponent = Convert.ToInt32(selected_data_hold[2]);
                hold.Function_name = selected_data_hold[3];
                
                selected_data_list.Add(hold);
                #endregion
            }
            dbConnector.Close();
        }

        private void frm_Functions_and_Ranges_Load(object sender, EventArgs e)
        {
            DisplayData_model_list();
        }

        #endregion

        private void txt_function_name_TextChanged(object sender, EventArgs e){
            selected_function_name = txt_function_name.Text;
            int i = test_edit_avalible();
            if (i != -1){
                txt_function_symbol.Text = selected_data_list[i].Function.ToString();
                txt_exponent.Text = selected_data_list[i].Exponent.ToString();
            }
        }

        private void txt_function_symbol_TextChanged(object sender, EventArgs e){
            selected_function_symblo = txt_function_symbol.Text;
        }

        private void txt_exponent_TextChanged(object sender, EventArgs e){
            if (txt_exponent.Text != "" && txt_exponent.Text != "-"){
                try { selected_exponent = Convert.ToInt32(txt_exponent.Text); }
                catch (System.FormatException) { MessageBox.Show("The value you entered was not a number"); }
            }
        }

        private void btn_add_function_Click(object sender, EventArgs e){
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = ($"INSERT INTO Functions (Function, Exponent, Function_name) " +
                            $"VALUES ('{selected_function_symblo}',{selected_exponent},'{selected_function_name}')");
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            DisplayData_model_list();
        }

        private int test_edit_avalible(){
            for (int i = 0; i < selected_data_list.Count; i++){
                if (selected_data_list[i].Function_name.ToString() == selected_function_name.ToString()){
                    return i;
                }
            }
            return -1;
        }

        private void btn_edit_function_Click(object sender, EventArgs e){
            if (test_edit_avalible() != -1){
                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr = "UPDATE Standard_output " +
                                $"SET [Precision] ={selected_persision}, Actual_Value ={selected_actual_value} " +
                                $"WHERE Standard_ID ={selected_modle_id} AND Function_ID ={selected_function_id}";
                dbConnector.Connect();
                dbConnector.DoDML(cmdStr);
                dbConnector.Close();
                DisplayData_model_list();
            }
            else { MessageBox.Show("There was not enought data :["); }
        }
    }
}
