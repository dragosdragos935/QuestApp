using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;








namespace QuesttApp2.Classes
{
    internal class Functions
    {

        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;
        CreateAccount Person;
        

        



        public Functions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drago\Documents\DatabaseEmployees.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        //random string generator for password generator
        public string RandomString(int size,bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for(int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(random.NextDouble() + RandomNumber(65+i, 128-i)+i))); 
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }//random number generator for password generator
        public int RandomNumber(int min,int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        //random password generator
        public string RandomPassowrd(int size = 7)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(5, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            Console.WriteLine(builder.ToString());
            return builder.ToString();
        }
        public void GridToExcel()
        {

        }


        

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, ConStr);
            sda.Fill(dt);
            return dt;

        }

        public SqlConnection setconnection()
        {
            string ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\drago\Documents\DatabaseEmployees.mdf;Integrated Security=True;Connect Timeout=30";
            var conn = new SqlConnection(ConStr);
            return conn;
        }
        public int SetData(string Query)
        {
            int cnt = 0;
            if(Con.State == ConnectionState.Closed)
            {
                Console.WriteLine("Connection closed!");
                Con.Open();

            }
            Cmd.CommandText = Query;
            cnt = Cmd.ExecuteNonQuery();
            Console.WriteLine(cnt);
            return cnt;
        }

        
        
            public int Verify(string username, string password)
            {
            Con.Close();
                if (Con.State == ConnectionState.Closed)
                {
                    Console.WriteLine("Connection closed!");
                    Con.Open();

                }
                Console.WriteLine("Connection open!");
                Con = new SqlConnection(ConStr);
                Con.Open();
            if (NumberofLogins(username, Con) != 0)
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT Username,NewPassword" +
                " FROM [dbo].[CreateAccountTb] WHERE ([Username] COLLATE SQL_Latin1_General_CP1_CS_AS = '" +
                username + "' AND [NewPassword] COLLATE SQL_Latin1_General_CP1_CS_AS='" + password + "')", Con);
                Console.WriteLine("Username:" + username);
                Console.WriteLine("Password:" + password);


                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("User exists");
                    reader.Close();
                    return 1;
                }
                else
                {
                    MessageBox.Show("Please create an account!");
                    reader.Close();
                    return -1;
                }
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT Username,FirstPassword" +
                                " FROM [dbo].[CreateAccountTb] WHERE ([Username] COLLATE SQL_Latin1_General_CP1_CS_AS = '" +
                                username + "' AND [FirstPassword] COLLATE SQL_Latin1_General_CP1_CS_AS='" + password + "')", Con);
                Console.WriteLine("Username:" + username);
                Console.WriteLine("Password:" + password);
                sqlCommand.ExecuteNonQuery();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("User exists");
                    reader.Close();
                    return 1;
                }
                else
                {
                    MessageBox.Show("Please create an account!");
                    reader.Close();
                    return -1;
                }
            }
                
              
                
            }

        public double SumInRon(string username)
        {
            double TotalSum=0;
             string Query = "SELECT SUM(ValueInRon) AS TotalSum FROM "+username+"Details";
            SqlConnection connection = new SqlConnection(ConStr);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(Query, connection);
            using(SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        TotalSum =reader.GetDouble(0);
                    }
                }
                return TotalSum;
            }

            return TotalSum;
        }

     
        public int NumberofLogins(string Username,SqlConnection conn)
        {
            string getlogins = "SELECT Logins FROM CreateAccountTb WHERE UserName =@Username";
            int numberoflogins = 0;
            SqlCommand getalllogins = new SqlCommand(getlogins, conn);
            getalllogins.Parameters.AddWithValue("@UserName", Username);
            if(Con.State != ConnectionState.Closed)
            {
                Console.WriteLine("Connection closed");
                
            }
            SqlDataReader reader = getalllogins.ExecuteReader();//Problem
            if (reader.Read())
            {
                string loginsString = reader.GetString(0);
                if (int.TryParse(loginsString, out int loginsValue))
                {
                    numberoflogins = loginsValue;
                    reader.Close();
                    Console.WriteLine("Number of logins:" + numberoflogins);
                    return numberoflogins;
                    
                }

            }
           
            return 0;
        }


        public void SetNumberofLogins(string Username, SqlConnection conn)
        {

            int numberoflogins = NumberofLogins(Username, conn);
            numberoflogins++;
            string setLogins = "UPDATE CreateAccountTb " +
                "SET Logins = @newlogins " +
                "WHERE Username=@username";
                       
            SqlCommand createLogins = new SqlCommand(setLogins, conn);
            createLogins.Parameters.AddWithValue("@newlogins", numberoflogins);
            createLogins.Parameters.AddWithValue("@username",Username);
            int rowsaffected =createLogins.ExecuteNonQuery();
            Console.WriteLine(rowsaffected);
            
        }







    }
}
