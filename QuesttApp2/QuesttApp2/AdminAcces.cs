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

namespace QuesttApp2
{
    public partial class AdminAcces : Form
    {
        int tries;
        public AdminAcces()
        {
            InitializeComponent();
            tries = 3;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string Acces_code = "Quest123";
            
            try
            {
                if(AccesTb.Text == Acces_code)
                {
                    CreateAccount obj = new CreateAccount();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    if(tries > 0)
                    {
                        tries--;
                        MessageBox.Show("You have " + tries + " attempts");
                    }
                    else
                    {
                        Login obj1 = new Login();
                        obj1.Show();
                        this.Hide();
                        tries = 3;
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
