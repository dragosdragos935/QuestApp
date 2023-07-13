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
using Microsoft.Office.Interop.Excel;



namespace QuesttApp2.Classes
{
    public partial class Employees : Form
    {





        Functions Con;
        CurrencyConverter Converter;
        public string username { get; set; }
        
        public Employees(string Username)
        {

            
            InitializeComponent();
            Con = new Functions();
            Converter = new CurrencyConverter();
         
            ShowEmployee(Username);
            username = Username;
            Console.WriteLine("Userul este:" + username);

        }


        private void ShowEmployee(string Username)
        {

            username = Username;
            string Query = "select * from " + username + "Details";
            EmployeeListerTb.DataSource = Con.GetData(Query);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProviderNameTb.Text == "" || DocumentNumberTb.Text == "" || DataTb.Text == "" || CostTypeTb.Text == "" || AmountTb.Text == "" || CurrencyCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Provider = ProviderNameTb.Text;
                    string Document = DocumentNumberTb.Text;
                    string Data = DataTb.Text;
                    string CostType = CostTypeTb.Text;
                    Double Amount = Convert.ToDouble(AmountTb.Text);
                    string Currency = CurrencyCb.SelectedItem.ToString();
                    DateTime CurrentDate = DateTime.Now;
                    DateTime DateCurrency = Convert.ToDateTime(DateTb.Value);
                    Console.WriteLine(Currency);
                    Console.WriteLine(DateCurrency);
                    double ValueInRon;

                    if (Currency != "LEU")
                    {
                        ValueInRon = Converter.GetCurrencyinEuro(Currency, DateCurrency) * Amount;
                    }
                    else
                    {
                        ValueInRon = Convert.ToDouble(AmountTb.Text);
                    }
                    if (ValueInRon > 0)
                    {

                        string Query = "INSERT INTO "+username+"Details (ProviderName, DocumentNumber, Data, CostType, Amount, Currency,DateCurrency,ValueInRon)" +
                                       "VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}','{6}','{7}')";

                        Query = string.Format(Query, Provider, Document, Data, CostType, Amount, Currency, DateCurrency, ValueInRon);

                        Con.SetData(Query);
                        ShowEmployee(username);

                        MessageBox.Show("Employee added!");
                        ProviderNameTb.Text = "";
                        DocumentNumberTb.Text = "";
                        DataTb.Text = "";
                        CostTypeTb.Text = "";
                        AmountTb.Text = "";
                        CurrencyCb.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Choose another day");
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (IdTbl.Text == "")
                {
                    MessageBox.Show("Please enter the id of the provider to be deleted!");
                }
                else
                {



                    string Query = "DELETE from "+username+"Details where EmployeeId=" + IdTbl.Text;



                    Con.SetData(Query);
                    ShowEmployee(username);

                    MessageBox.Show("Employee deleted!");
                    ProviderNameTb.Text = "";
                    DocumentNumberTb.Text = "";
                    DataTb.Text = "";
                    CostTypeTb.Text = "";
                    AmountTb.Text = "";
                    CurrencyCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        public void filltheExcel()
        {

            /*
             ExcelExporter excelExporter = new ExcelExporter();
             excelSheet.Cells[1, 1] = "ProviderName";
             excelSheet.Cells[1, 2] = "DocumentNumber";
             excelSheet.Cells[1, 3] = "Data";
             excelSheet.Cells[1, 4] = "CostType";
             excelSheet.Cells[1, 5] = "Amount";
             excelSheet.Cells[1, 6] = "Currency";
             excelSheet.Cells[1, 7] = "ValueInRon";
             excelSheet.Cells[1, 8] = "DateCurrency";*/




            



           




        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void EmployeeListerTb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void ExcelFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelExporter exp = new ExcelExporter();
                string Query = "select * from "+username+"Details";
                System.Data.DataTable dt1 = Con.GetData(Query);
                exp.filltheExcel(dt1);
                Console.WriteLine("Excel succesful made");
                MessageBox.Show("Excel succesful made");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TotalSumBtn_Click(object sender, EventArgs e)
        {
            double sum = Con.SumInRon(username);
            MessageBox.Show("Total sum is:" + sum+" RON");
            
        }
    }
}
