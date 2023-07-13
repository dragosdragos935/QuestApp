using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Net.Http;
using System.Globalization;
using System.Net;
using System.Xml.XPath;
using System.Windows.Forms;
using System.Data;




namespace QuesttApp2.Classes
{
    class CurrencyConverter
    {
       

        public CurrencyConverter()
        {
            Console.WriteLine("Currency accesed");

        }

        /*
                public double CurrencyInEuro()
                {
                    string url = "https://www.bnr.ro/nbrfxrates.xml";
                    try
                    {

                    }
                }

                */


        public Double GetCurrencyinEuro(string currencyCode,DateTime date)
        {
            string month;
            string day;
            
            if (date.Month < 10)
            {
                month = "0" + date.Month;
            }
            else
            {
                 month = date.Month.ToString();
            }
            if (date.Day < 10)
            {
                 day = "0" + date.Day;
            }
            else
            {
                 day = date.Day.ToString();
            }


            string format = date.Year + "-" + month + "-" + day;
            string url = "https://www.bnr.ro/files/xml/years/nbrfxrates"+date.Year+".xml";
            Console.WriteLine(url);
            Console.WriteLine(format);



            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(url).Result;
            try
            {
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Response is succesed");
                    string XmlContent = response.Content.ReadAsStringAsync().Result;
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(XmlContent);




                    try
                    {
                        DataSet dataset = new DataSet();
                        dataset.ReadXml(url);
                        DataTable cubeTable = dataset.Tables["Cube"];
                        foreach (DataRow row0 in cubeTable.Rows) {

                            string datecurrency = row0["date"].ToString();

                            DataTable rateTable = dataset.Tables["Rate"];
                            foreach (DataRow row in rateTable.Rows)
                            {
                                string currency1 = row["currency"].ToString();
                                if (currency1 == currencyCode&&datecurrency==format)
                                {
                                    var eurValue = Convert.ToDouble(row["Rate_Text"]);
                                    Console.WriteLine(eurValue);
                                    Console.WriteLine("Found");
                                    return eurValue;
                                }
                            }

                        }

                        MessageBox.Show("Free Day on BNR Site");
                        return 0;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception" + ex);
                        return 0;
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
                return 0;
         
            }
            return 0;
        }
    }
}







