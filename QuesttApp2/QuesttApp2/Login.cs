using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuesttApp2.Classes;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuesttApp2
{
    public partial class Login : Form
    {
        
        Functions Connection;
        string Username { get; set; }
        string Password;
        string ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drago\Documents\DatabaseEmployees.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        public Login()
        {
            InitializeComponent();
            Connection = new Functions();
            conn = Connection.setconnection();

        }
        

        private void label3_Click(object sender, EventArgs e)
        {
             
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            AdminAcces Obj = new AdminAcces();
            Obj.Show();
            this.Hide();
        }

        



        public void LoginBtn_Click(object sender, EventArgs e)
        {
         
            try
            {

                if (UsernameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Plese introduce the data!");
                    Login obj = new Login();
                    obj.Show();
                    this.Hide();

                }
                else
                {
                     Username = UsernameTb.Text;
                     Password = PasswordTb.Text;
                    var response = Connection.Verify(Username, Password);
                    if (response == -1)
                    {
                        MessageBox.Show("Login failed!");
                    }
                    else
                    {
                        MessageBox.Show("Login succesful!");
                        
                        var conn = new SqlConnection(ConStr);
                        conn = new SqlConnection(ConStr);
                        conn.Open();
                        if (Connection.NumberofLogins(Username, conn)==0)
                        {


                            MessageBox.Show("Please reset your default password");
                            ResetPassword obj = new ResetPassword();
                            obj.Show();
                            this.Hide();




                           
                        }
                        else
                        {
                            Employees obj = new Employees(UsernameTb.Text);
                            Console.WriteLine(Username);
                            Connection.SetNumberofLogins(Username, conn);
                            obj.Show();
                            this.Hide();
                           
                        }
                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }


        

        private void UsernameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


    }
}
