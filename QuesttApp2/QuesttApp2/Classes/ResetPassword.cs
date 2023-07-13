using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuesttApp2.Classes
{
    public partial class ResetPassword : Form
    {
        Functions Con;
        
        public ResetPassword()
        {
           
            InitializeComponent();
             Con = new Functions();
           var conn= Con.setconnection();
            


        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTb.Text;
            string newPassword = ResetTb.Text;
            if(newPassword == "")
            {
                MessageBox.Show("Plese introduce a passwpord");

            }
            else
            {
                string ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drago\Documents\DatabaseEmployees.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection con = new SqlConnection(ConStr);
                if(con.State == ConnectionState.Closed)
                {
                    Console.WriteLine("Connection closed reopen");
                    con.Open();
                    Console.WriteLine("Connection opened");
                }
                
                
                
                    string Query = "UPDATE CreateAccountTb " +
                "SET NewPassword = @newPasswords " +
                "WHERE Username=@username";
                SqlCommand createnewPassword = new SqlCommand(Query, con);
                    createnewPassword.Parameters.AddWithValue("@newPasswords", newPassword);
                createnewPassword.Parameters.AddWithValue("@username", username);
                createnewPassword.ExecuteNonQuery();
                    Console.WriteLine(newPassword);
                    MessageBox.Show("Password changed accepted");
                    
                    Con.SetNumberofLogins(UsernameTb.Text, con);
                    Employees employees = new Employees(UsernameTb.Text);
                    employees.Show();
                    this.Hide();
                

            }



        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
