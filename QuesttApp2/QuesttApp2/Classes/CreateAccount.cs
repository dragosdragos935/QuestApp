using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using QuesttApp2.Classes;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Net;


namespace QuesttApp2.Classes
{
    public partial class CreateAccount : Form
    {
        Functions Con;

        public CreateAccount()
        {
            InitializeComponent();
            Con = new Functions();
            ShowUser();

        }
        private void ShowUser()
        {
            string Query = "select * from UserLoginTb";
            
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            int IsAdmin;
            try
            {
                if (FirstNameTbb.Text == "" || LastNameTb.Text == "" || UsernameTb.Text == "" || EmailTb.Text == "" || GenderCb.SelectedIndex == -1||DepartmentTb.Text=="")
                {
                    MessageBox.Show("Please enter all data!");
                }
                else
                {

                    string FirstName = FirstNameTbb.Text;
                    string LastName = LastNameTb.Text;
                    string Username = UsernameTb.Text;
                    string Email = EmailTb.Text;
                    string Department = DepartmentTb.Text;
                    string Gender = GenderCb.SelectedItem.ToString();
                    string Password = Con.RandomPassowrd();
                    if (CheckBoxBtn.Checked == true)
                    {
                        IsAdmin = 1;
                    }else
                    {
                        IsAdmin = 0;
                    }
                    int idValue = Con.RandomNumber(1, 1000);


                    /*string Username = FirstNameTbb.Text;
                    string Password = LastNameTb.Text;
                    string Email = UsernameTb.Text;
                    string Department = EmailTb.Text;
                    string Gender = GenderCb.SelectedItem.ToString();*/




                    /*string[] files = { Path.Combine(Application.StartupPath, Username + ".mdf"),
               Path.Combine(Application.StartupPath, Username + ".ldf") };*/




                    //Console.WriteLine(Application.StartupPath);

                    string ServerName = "MSSQLLocalDB";
                    string ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drago\Documents\DatabaseEmployees.mdf;Integrated Security=True;Connect Timeout=30";

                    using (var conn = new SqlConnection(ConStr))
                    {
                        conn.Open();

                        // Create database for the user
                        /*  string createDatabaseQuery = "CREATE DATABASE " + Username +
                              " ON PRIMARY" +
                              " (NAME = " + Username + "_data," +
                              " FILENAME = '" + files[0] + "'," +
                              " SIZE = 3MB," +
                              " MAXSIZE = 10MB," +
                              " FILEGROWTH = 10%)" +
                              " LOG ON" +
                              " (NAME = " + Username + "_log," +
                              " FILENAME = '" + files[1] + "'," +
                              " SIZE = 1MB," +
                              " MAXSIZE = 5MB," +
                              " FILEGROWTH = 10%);";

                          SqlCommand createDatabaseCommand = new SqlCommand(createDatabaseQuery, conn);
                          createDatabaseCommand.ExecuteNonQuery();

                          // Create user-specific table
                          string createUserTableQuery = "CREATE TABLE [dbo].[" + Username + "Dt" + "] (" +
                              "[UsernameId]     INT IDENTITY(1, 1) NOT NULL," +
                              "[Username]     VARCHAR(50) NOT NULL," +
                              "[Password]   VARCHAR(50) NOT NULL," +
                              "[Email] VARCHAR(50) NOT NULL," +
                              "[Department]           VARCHAR(50) NOT NULL," +
                              "[Gender]       VARCHAR(50) NOT NULL," +
                              "PRIMARY KEY CLUSTERED([UsernameId] ASC));";

                          SqlCommand createUserTableCommand = new SqlCommand(createUserTableQuery, conn);
                          createUserTableCommand.ExecuteNonQuery();

                          // Create user-specific data table
                          string createDataTableQuery = "CREATE TABLE [dbo].[" + Username + "DataDt" + "] (" +
                              "[EmployeeId]     INT IDENTITY(1, 1) NOT NULL," +
                              "[ProviderName]   VARCHAR(50) NOT NULL," +
                              "[DocumentNumber] VARCHAR(50) NOT NULL," +
                              "[Data]           VARCHAR(50) NOT NULL," +
                              "[CostType]       VARCHAR(50) NOT NULL," +
                              "[Amount]         VARCHAR(50) NOT NULL," +
                              "[Currency]       TEXT NOT NULL," +
                              "[ValueInRon] VARCHAR(50) DEFAULT((0)) NULL," +
                              "[DateCurrency] VARCHAR(50) DEFAULT((0)) NOT NULL," +
                              "PRIMARY KEY CLUSTERED([EmployeeId] ASC));";*/



                        /*string createUserData = "CREATE TABLE [dbo].[CreateAccountTb]" +
"("+

   " [Id] INT NOT NULL PRIMARY KEY," +
    "[FirstName] VARCHAR(50) NOT NULL," +

    "[LastName] VARCHAR(50) NOT NULL," +

   " [UserName] VARCHAR(50) NOT NULL," +

    "[Email] VARCHAR(50) NOT NULL," +

   " [Department] VARCHAR(50) NOT NULL," +

   " [IsAdmin] VARCHAR(50) NOT NULL," +

    "[Gender]VARCHAR(50) NOT NULL," +

    "[FirstPassword]VARCHAR(50)NOT NULL," +

    "[NewPassword]VARCHAR(50)NOT NULL," +

   " [Details]VARCHAR(50)NOT NULL" +
");";*/



                        /*[Id] INT NOT NULL PRIMARY KEY,
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[UserName] VARCHAR(50) NOT NULL,
	[Email] VARCHAR(50) NOT NULL,
	[Department] VARCHAR(50) NOT NULL,
	[IsAdmin] VARCHAR(50) NOT NULL,
	[Gender]VARCHAR(50) NOT NULL,
	[FirstPassword]VARCHAR(50)NOT NULL,
	[NewPassword]VARCHAR(50)NOT NULL,
	[Details]VARCHAR(50)NOT NULL*/


                        string insertUserData = "INSERT INTO CreateAccountTb (FirstName, LastName, UserName, Email, Department, IsAdmin, Gender, FirstPassword) " +
                         "VALUES (@FirstName, @LastName, @UserName, @Email, @Department, @IsAdmin, @Gender, @Password)";

                        string verifyUsername = "SELECT COUNT(*) FROM CreateAccountTb WHERE UserName=@Username";

                        


                        int count = 0;
                        string UserData = "INSERT INTO UserLogin (UserName, Password,IsAdmin) " +
                                          "VALUES (@UserName, @Password,@IsAdmin)";
                        try {

                            SqlCommand command = new SqlCommand(verifyUsername, conn);
                            command.Parameters.AddWithValue("@UserName", Username);

                            count = (int)command.ExecuteScalar();

                            if (count == 0)
                            {
                                try
                                {
                            
                                    SqlCommand cmd = conn.CreateCommand();
                                    cmd.CommandText = "CREATE TABLE " + Username + "Details" + " (" +
                              "[EmployeeId]     INT IDENTITY(1, 1) NOT NULL," +
                              "[ProviderName]   VARCHAR(50) NOT NULL," +
                              "[DocumentNumber] VARCHAR(50) NOT NULL," +
                              "[Data]           VARCHAR(50) NOT NULL," +
                              "[CostType]       VARCHAR(50) NOT NULL," +
                              "[Amount]         VARCHAR(50) NOT NULL," +
                              "[Currency]       TEXT NOT NULL," +
                              "[ValueInRon]     FLOAT (53)   DEFAULT ((0)) NULL," +
                              "[DateCurrency] VARCHAR(50) DEFAULT((0)) NOT NULL," +
                              "PRIMARY KEY CLUSTERED([EmployeeId] ASC));";

                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine("DataTable Created!!!");


                                }
                                catch (Exception ex) {
                                    MessageBox.Show(ex.Message);
                                }

                                /*
                                try
                                {
                                    string xmlFilePath = "C:\\Users/drago/Desktop/QuesttApp2/QuesttApp2/" + Username + "Details.xml";
                                    dt.WriteXml(xmlFilePath);
                                }catch(Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }*/


                                Console.WriteLine("DataTable for User Created");









                                //Add values to CreateAcountTb
                                SqlCommand createUser = new SqlCommand(insertUserData, conn);
                                createUser.Parameters.AddWithValue("@FirstName", FirstName);
                                createUser.Parameters.AddWithValue("@LastName", LastName);
                                createUser.Parameters.AddWithValue("@UserName", Username);
                                createUser.Parameters.AddWithValue("@Email", Email);
                                createUser.Parameters.AddWithValue("@Department", Department);
                                createUser.Parameters.AddWithValue("@IsAdmin", IsAdmin);
                                createUser.Parameters.AddWithValue("@Gender", Gender);
                                createUser.Parameters.AddWithValue("@Password", Password);
                                createUser.Parameters.AddWithValue("@Logins", Password);
                                createUser.ExecuteNonQuery();

                                //Get Logins from CreateAcountTb




                                //Add values to UserLogin
                                SqlCommand sqlCommand = new SqlCommand(UserData, conn);
                                sqlCommand.Parameters.AddWithValue("@UserName", Username);
                                sqlCommand.Parameters.AddWithValue("@Password", Password);
                                sqlCommand.Parameters.AddWithValue("@IsAdmin", IsAdmin);
                                sqlCommand.ExecuteNonQuery();

                                Console.WriteLine(FirstName);
                                Console.WriteLine(LastName);
                                Console.WriteLine(Email);
                                Console.WriteLine(Department);
                                Console.WriteLine(Gender);
                                Console.WriteLine(Username);
                                Console.WriteLine(Password);




                                SendMailWithPassword(Password);
                                MessageBox.Show("Account Created!");
                            }
                            else
                            {
                                MessageBox.Show("User exist please introduce different data!");
                            }

                            /* string disableIdentityInsertQuery = $"SET IDENTITY_INSERT CreateAccountTb OFF";
                             SqlCommand disableIdentityInsertCommand = new SqlCommand(disableIdentityInsertQuery, conn);
                             disableIdentityInsertCommand.ExecuteNonQuery();*/





                            /*SqlCommand createDataTableCommand = new SqlCommand(createDataTableQuery, conn);
                            createDataTableCommand.ExecuteNonQuery();

                            MessageBox.Show("Database and tables created successfully.", "QuestApp", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Enable IDENTITY_INSERT
                            string enableIdentityInsertQuery = $"SET IDENTITY_INSERT [dbo].[{Username}Dt] ON";
                            SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, conn);
                            enableIdentityInsertCommand.ExecuteNonQuery();

                            // Insert user data into the user table
                            string insertDataQuery = $"INSERT INTO [dbo].[{Username}Dt] (UsernameId, Username, Password, Email, Department, Gender) " +
                                "VALUES (@UsernameId, @Username, @Password, @Email, @Department, @Gender)";

                            SqlCommand insertDataCommand = new SqlCommand(insertDataQuery, conn);
                            insertDataCommand.Parameters.AddWithValue("@UsernameId", 1); // Specify the identity column value explicitly here
                            insertDataCommand.Parameters.AddWithValue("@Username", Username);
                            insertDataCommand.Parameters.AddWithValue("@Password", Password);
                            insertDataCommand.Parameters.AddWithValue("@Email", Email);
                            insertDataCommand.Parameters.AddWithValue("@Department", Department);
                            insertDataCommand.Parameters.AddWithValue("@Gender", Gender);

                            insertDataCommand.ExecuteNonQuery();

                            // Disable IDENTITY_INSERT
                            string disableIdentityInsertQuery = $"SET IDENTITY_INSERT [dbo].[{Username}Dt] OFF";
                            SqlCommand disableIdentityInsertCommand = new SqlCommand(disableIdentityInsertQuery, conn);
                            disableIdentityInsertCommand.ExecuteNonQuery();*/
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            Console.WriteLine(ex.Message);
                        }
                        }


                   
                  
                    
                    
                    /* FirstNameTbb.Text = "";
                    LastNameTb.Text = "";
                    UsernameTb.Text = "";
                    EmailTb.Text = "";
                    GenderCb.SelectedIndex = -1;*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void SendMailWithPassword(string password)
        {
            try
            {
                string senderEmail = SenderTb.Text;
                string senderPassword = SenderPassTb.Text;
                //lkcffltizpylrpjn
                string recipientEmail = EmailTb.Text;
                string subject = "Hello Employee this is the password for QuestApp";
                string Body = "Username:"+UsernameTb.Text+" Password:"+password;
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail, subject, Body);
                smtpClient.Send(mailMessage);
                Console.WriteLine("Email sent");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }



        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void UsernameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
