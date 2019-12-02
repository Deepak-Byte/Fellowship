using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NEW_OPPS_PROJECT.Stockaccount
{
    public class UserStockAccount
    {
        JavaScriptSerializer jscript = new JavaScriptSerializer();
        public void Stockaccountinput()
        {
            List<Customars> list = new List<Customars>();
            Customars stocks = new Customars();
            Stockvaluelist stockvaluelist = new Stockvaluelist();
            try
            {
                Console.WriteLine("-------------------------WELCOME TO SHARE MARKET----------------------------");

                Console.WriteLine("+++++++++++++++++++ WE HAVE TWO COMPANY SHARE AVAILABLE ++++++++++++++++++++");

                Console.WriteLine("                         TCS MUTUAL FUND SERNICE                            ");
                Console.WriteLine("TOTAL NUMBER OF SHARE AVAILABLE IS : " + 500 + "                    ");
                Console.WriteLine("VALUE OF EACH SHARE : " + 1500);

                Console.WriteLine("                         RBI SIP CURRENT MODE                               ");
                Console.WriteLine("TOTAL NUMBER OF SHARE AVAILABLE IS : " + 200 + "                  ");
                Console.WriteLine("VALUE OF EACH SHARE : " + 1000);
                Console.WriteLine();
                Console.WriteLine("IN WHICH COMPANY YOU WANT TO INVEST MONEY ");

                Console.WriteLine("DO YOU WANT TO BUY A SHARE THAN PRESS [1] :");
                Console.WriteLine("DO YOU WANT TO SHELL YOUR SHARE THAN PRESS [2] :");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("ENTER YOUR NAME");
                    string nameofholder = Console.ReadLine();
                    Console.WriteLine("ENTER THE AMOUNT AVAILABLE IN YOUR BANK ");
                    int amount = int.Parse(Console.ReadLine());
                    Console.WriteLine("*********CONGRATULATION********");
                    Console.WriteLine("YOUR ACCOUNT IS SUCCESFULY CREATED");

                    Console.WriteLine("WHICH COMPANY SHARE YOU WANT TO PURCHES \nPRESS [1] FOR TCS \nPRESS [2] FOR RBI");
                    int company = int.Parse(Console.ReadLine());
                    if (company == 1)
                    {
                        Console.WriteLine("HOW MANY SHARE YOU WANT TO BUY");
                        int numberofshare = int.Parse(Console.ReadLine());
                        bool b= Checkstatus(1 , numberofshare);
                        if (b == true)
                        {
                            int amountdeducted = numberofshare * 1500;
                            string jsondata = System.IO.File.ReadAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Tcscustomar.json");
                            list = jscript.Deserialize<List<Customars>>(jsondata);

                            list.Add(new Customars() { Nameofcompany1 = "TCS", Numberofshare = 500, Valueofeachshare = 1500, Nameofcustomor1 = nameofholder, Accountbalancesofcustomar1 = amount, Numbersharebuy = numberofshare, Amountdeducted = amountdeducted, Valueofshare = (1500 * numberofshare), Shareremainig = (500- numberofshare) });
                            jsondata = JsonConvert.SerializeObject(list);
                            System.IO.File.WriteAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Tcscustomar.json", jsondata);
                            Console.WriteLine("iNVENTORY AADED SUCCESFULLY");

                            Console.WriteLine("Do you want to see the data you entered than pres 'Y' ");
                            char check = char.Parse(Console.ReadLine());
                            if (check == 'Y' || check == 'y')
                            {
                                using (StreamReader read = new StreamReader(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Tcscustomar.json"))
                                {
                                    Console.WriteLine();
                                    string json = read.ReadToEnd();
                                    List<Customars> items = JsonConvert.DeserializeObject<List<Customars>>(json);
                                    dynamic array = JsonConvert.DeserializeObject(json);
                                    foreach (var item in array)
                                    {
                                        Console.WriteLine("NAME OF COMPANY: {0}\nNUMBER OF SHARE : {1}\nVALUE OF SHARE : {2}\nNAME OF CUSTOMAR : {3}\nACCUONT BALANCED OF CUSTOMAR : {4}\nNUMBER OF SHARE BUY (OF CUSTOMAR) : {5}\nAMOUNT DEDUCTED : {6}\nVALUE OF SHARE : {7}\nREMAINING SHARE OF COMPANY : {8}\n", item.Nameofcompany1, item.Numberofshare, item.Valueofeachshare,item.Nameofcustomor1, item.Accountbalancesofcustomar1, item.Numbersharebuy, item.Amountdeducted, item.Valueofshare, item.Shareremainig);
                                        Console.WriteLine();
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT ELIGIBLE TO THIS SHARE");
                        }
                    }
                    else
                    {
                        Console.WriteLine("HOW MANY SHARE YOU WANT TO BUY");
                        int numberofshare = int.Parse(Console.ReadLine());
                        bool b = Checkstatus(2, numberofshare);
                        if (b == true)
                        {

                            int amountdeducted = numberofshare * 1500;
                            string jsondata = System.IO.File.ReadAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Rbiustomar.json");
                            list = jscript.Deserialize<List<Customars>>(jsondata);

                            list.Add(new Customars() { Nameofcompany1 = "RBI SIP", Numberofshare = 200, Valueofeachshare = 1000, Nameofcustomor1 = nameofholder, Accountbalancesofcustomar1 = amount, Numbersharebuy = numberofshare, Amountdeducted = amountdeducted, Valueofshare = (1000 * numberofshare), Shareremainig = (200 - numberofshare) });
                            jsondata = JsonConvert.SerializeObject(list);
                            System.IO.File.WriteAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Rbiustomar.json", jsondata);
                            Console.WriteLine("iNVENTORY AADED SUCCESFULLY");

                            Console.WriteLine("Do you want to see the data you entered than pres 'Y' ");
                            char check = char.Parse(Console.ReadLine());
                            if (check == 'Y' || check == 'y')
                            {
                                using (StreamReader read = new StreamReader(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Rbiustomar.json"))
                                {
                                    Console.WriteLine();
                                    string json = read.ReadToEnd();
                                    List<Customars> items = JsonConvert.DeserializeObject<List<Customars>>(json);
                                    dynamic array = JsonConvert.DeserializeObject(json);
                                    foreach (var item in array)
                                    {
                                        Console.WriteLine("NAME OF COMPANY: {0}\nNUMBER OF SHARE : {1}\nVALUE OF SHARE : {2}\nNAME OF CUSTOMAR : {3}\nACCUONT BALANCED OF CUSTOMAR : {4}\nNUMBER OF SHARE BUY (OF CUSTOMAR) : {5}\nAMOUNT DEDUCTED : {6}\nVALUE OF SHARE : {7}\nREMAINING SHARE OF COMPANY : {8}\n", item.Nameofcompany1, item.Numberofshare, item.Valueofeachshare, item.Nameofcustomor1, item.Accountbalancesofcustomar1, item.Numbersharebuy, item.Amountdeducted, item.Valueofshare, item.Shareremainig);
                                        Console.WriteLine();
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT ELIGIBLE TO THIS SHARE");
                        }
                    }
                }
            }
            catch (FormatException FormatException)
            {
                Console.WriteLine(FormatException.Message);
            }
            catch (Exception Exception)
            {
                Console.WriteLine(Exception.Message);
            }
        }

        public bool Checkstatus(int type , int number)
        {
            int available = 0;
            if (type == 1)
            {

                using (StreamReader read = new StreamReader(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Tcscustomar.json"))
                {

                    string json = read.ReadToEnd();
                    List<Customars> items = JsonConvert.DeserializeObject<List<Customars>>(json);
                    dynamic array = JsonConvert.DeserializeObject(json);
                    foreach (var item in array)
                    {
                        Console.WriteLine(item.Shareremainig);

                        available = item.Shareremainig;
                    }
                }
            }
            else
            {
                using (StreamReader read = new StreamReader(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\Stockaccount\Rbiustomar.json"))
                {

                    string json = read.ReadToEnd();
                    List<Customars> items = JsonConvert.DeserializeObject<List<Customars>>(json);
                    dynamic array = JsonConvert.DeserializeObject(json);
                    foreach (var item in array)
                    {
                        Console.WriteLine(item.Shareremainig);

                        available = item.Shareremainig;
                    }
                }
            }
            if (number < available)
                return true;
            else
                return false;
        }
    }
}
