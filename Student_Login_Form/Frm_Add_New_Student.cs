using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Login_Form
{
    public partial class Frm_Add_New_Student : Form
    {
        public Frm_Add_New_Student()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Login_Form_DB;Integrated Security=True");
        
           void Con_Open()
           {
                if(Con.State !=ConnectionState.Open)
                {
                    Con.Open();
                }
           }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }


        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;

            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (Char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
         void Clear_Controls()
        {
            tb_Roll_No.Text ="";
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cb_Course.SelectedIndex = -1;
             dtp_DOB.Text ="01/06/2002";
        }
        private void btn_Log_out_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
           Con_Open();

            if(tb_Roll_No.Text != "" && tb_Name.Text != " " && tb_Mobile_No.Text != " " && cb_Course.Text != " ")
            {
                 SqlCommand Cmd = new SqlCommand();
                 Cmd.Connection = Con;
                 Cmd.CommandText = "Insert Into Student_details(Roll_No,Name,Mobile_No,DOB,Course)Values(@RNo,@Name,@MobNo,@DOB,@Course)";

                Cmd.Parameters.Add("RNo",SqlDbType.Int).Value=tb_Roll_No.Text;
                Cmd.Parameters.Add("Name",SqlDbType.VarChar).Value=tb_Name.Text;
                Cmd.Parameters.Add("MobNo",SqlDbType.Decimal).Value=tb_Mobile_No.Text;
                Cmd.Parameters.Add("DOB",SqlDbType.Date).Value=dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Course",SqlDbType.NVarChar).Value=cb_Course.Text;

                Cmd.ExecuteNonQuery();
                 
                 MessageBox.Show("Record Saved");
                
                Clear_Controls();
            
            }
            else
            {
                 MessageBox.Show("Fill All Fields");
            }
             Con_Close();

        }

        private void btn_View_All_Students_List_Click(object sender, EventArgs e)
        {
           frm_View_All_Student_List obj = new frm_View_All_Student_List();
             obj.Show();
            this.Hide();
        }

        private void lbl_Roll_No_Click(object sender, EventArgs e)
        {

        }

       

       

      

      


       
        }

        
        }

       
       

        

        

