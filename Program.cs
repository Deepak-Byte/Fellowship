using System;
using NEW_OPPS_PROJECT.Inventorymanagement;
using NEW_OPPS_PROJECT.Inventorymanager;
using NEW_OPPS_PROJECT.Stockaccount;
using NEW_OPPS_PROJECT.StockAccount;


namespace NEW_OPPS_PROJECT
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("--------------HERE IS OPPS PROJECT----------------");
                    Console.WriteLine("1: INVENTORY MANAGAMENT");
                    Console.WriteLine("2: INVENTORY MANAGARr CACULATOR");
                    Console.WriteLine("3: STOCK ACCOUNT MANAGAR");
                    Console.WriteLine("4: FOR PRINT THE ITEM IN LIST");
                    Console.WriteLine("5: TO EXIT THE PROGRAM");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Inputoutput inputoutput = new Inputoutput();
                            inputoutput.Print();
                            break;
                        case 2:
                            Inputoutputmanager inputoutputmanager = new Inputoutputmanager();
                            inputoutputmanager.Printcalculatvalue();
                            break;
                        case 3:
                            Inputstock Inputstock = new Inputstock();
                            Inputstock.Addnewshare();
                            break;
                        case 4:
                            UserStockAccount obj = new UserStockAccount();
                            obj.Stockaccountinput();
                            break;
                        case 5:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("wrong input intered");
                            break;

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
    }
}
