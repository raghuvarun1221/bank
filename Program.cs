using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class Program
    {
        int Acc;
        int Amm;




        public void AccountOpening()

        {
            int a1 = 0;
            do
            {

                Console.WriteLine("________________________________________");
                Console.WriteLine("Enter \n1--> Create Account\n0 --> exit");

                int Ac = Convert.ToInt32(Console.ReadLine());
                if (Ac == 1)
                {

                    Console.WriteLine("Enter Account opening details");
                    Console.WriteLine("________________________________________");
                    Console.WriteLine("Enter 1 For Savings Account ");
                    Console.WriteLine("Enter 2 For Current Account ");
                    Console.WriteLine("Enter 3 For Child Care Account ");
                    Console.WriteLine("Enter 4 to Exit ");

                    Acc = Convert.ToInt32(Console.ReadLine());

                    if (Acc == 1)
                    {

                        Console.WriteLine("User Selected Savings account ");

                        Console.WriteLine("name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Acc no");
                        int Acc = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter Amount details");

                        Amm = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            if (Amm <= 100000)
                            {

                                Console.WriteLine("Your Amount is Deposited");

                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exeeded Limit" + e);

                        }
                        finally
                        {
                            Console.WriteLine("Entered Amount is " + Amm);
                        }
                    }


                    else if (Acc == 2)
                    {
                        Console.WriteLine("User Selected Curent account");
                        Console.WriteLine("name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Acc no");
                        int Acc = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter Amount details");
                        Console.WriteLine("________________________________________");
                        Amm = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            if (Amm <= 200000)
                            {
                                Console.WriteLine("Your Amount is Deposited");
                            }
                            else
                            {
                                throw new Exception();
                            }


                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exeeded Limit" + e);

                        }
                        finally
                        {
                            Console.WriteLine("Entered Amount is " + Amm);
                        }
                    }
                    else if (Acc == 3)
                    {
                        Console.WriteLine("User Selected Child care account");
                        Console.WriteLine("name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Acc no");
                        int Acc = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter Amount details");
                        Console.WriteLine("________________________________________");
                        Amm = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            if (Amm <= 50000)
                            {

                                Console.WriteLine("Your Amount is Deposited");
                            }
                            else
                            {
                                throw new Exception();
                            }


                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Your Amount is Exeeded Limit " + e);

                        }
                        finally
                        {
                            Console.Write("Entered Amount is " + Amm);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
                a1++;
            }
            while (a1 <= 10);
        }



        public void Atm()
        {
            Console.WriteLine("Enter 1 to get ATM Service");
            Console.WriteLine("Enter 2 For No Service");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            int ATM1 = Convert.ToInt32(Console.ReadLine());
            if (ATM1 == 1)
            {
                Console.WriteLine(" ATM Service Enabled");
                Console.WriteLine(" ---ThanK you for Selecting ATM Facility---  ");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");
                int x;
                do
                {
                    Console.WriteLine("Enter 1--->Deposit");
                    Console.WriteLine("Enter 2-->Withdraw");
                    Console.WriteLine("Enter 3--->Exit");
                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");
                    x = Convert.ToInt32(Console.ReadLine());
                    int Money, Balance = 10000;


                    switch (x)
                    {

                        case 1:

                            int t = 0;
                            while (t < 20)
                            {
                                if (t < 3)
                                {
                                    Console.WriteLine("1---> Continue\n 2--->Exit");
                                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");
                                    int f = Convert.ToInt32(Console.ReadLine());
                                    if (f == 1)
                                    {
                                        Console.WriteLine("enter Amount ");
                                        Money = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("________________________________________");
                                        Console.WriteLine("Deposited Amount is: " + Money);
                                        Balance = Balance + Money;
                                        Console.WriteLine("________________________________________");
                                        Console.WriteLine("Balance:" + Balance);
                                    }
                                    else
                                    { break; }
                                }
                                else
                                {
                                    Console.WriteLine("Sorry to inform\n from This Transaction 500 rs will be detected ");
                                    Console.WriteLine("1---> Continue\n 2--->Exit");
                                    int f = Convert.ToInt32(Console.ReadLine());
                                    if (f == 1)
                                    {
                                        Console.WriteLine("enter Amount ");
                                        Money = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("________________________________________");
                                        Console.WriteLine("Deposited Amount is: " + Money);

                                        Balance = Balance + Money - 500;
                                        Console.WriteLine("________________________________________");
                                        Console.WriteLine("Balance:" + Balance);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                t++;
                            }

                            break;

                        case 2:


                            int t1 = 0;
                            while (t1 < 20)
                            {
                                if (t1 < 3)
                                {
                                    Console.WriteLine("1---> Continue\n 2--->Exit");
                                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");
                                    int f = Convert.ToInt32(Console.ReadLine());
                                    if (f == 1)
                                    {
                                        Console.WriteLine("enter Amount ");
                                        Money = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("________________________________________");
                                        Console.WriteLine("Deposited Amount is: " + Money);
                                        Balance = Balance - Money;
                                        Console.WriteLine("________________________________________");
                                        Console.WriteLine("Balance:" + Balance);
                                    }
                                    else
                                    { break; }
                                }
                                else
                                {
                                    Console.WriteLine("Sorry to inform\nFrom This Transaction 500 rs will be detected ");
                                    Console.WriteLine("1---> Continue\n 2--->Exit");
                                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");
                                    int f = Convert.ToInt32(Console.ReadLine());
                                    if (f == 1)
                                    {
                                        Console.WriteLine("enter Amount ");
                                        Money = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("________________________________________");
                                        Console.WriteLine("Deposited Amount is: " + Money);

                                        Balance = Balance - Money - 500;
                                        Console.WriteLine("________________________________________");
                                        Console.WriteLine("Balance:" + Balance);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                t1++;
                            }
                            break;

                        default:
                            break;

                    }
                    x++;
                } while (x < 4);
            }
            else
            {
                Console.WriteLine("Sorry your ATM Service Will be Disabled ");
                Console.WriteLine(" ---ThanK you,Visit Agian");

                return;
            }


        }


    }


        public class Customer
        {


            //public int id
            //{
            //    get;
            //    set;

            //}
            public string Name
            {
                get;
                set;
            }
            public int AccNo
            {
                get;
                set;

            }
            public int Amount
            {
                get;
                set;

            }

        }
    
        public class Class1
        {
             static void Main(string[] args)
            {
                Program p = new Program();
                
                p.AccountOpening();



                p.Atm();

                Customer c1 = new Customer() { Name = "Raghu", AccNo = 123, Amount = 10000 };
                Customer c2 = new Customer() { Name = "Ravan", AccNo = 124, Amount = 8000 };
                Customer c3 = new Customer() { Name = "Rohan", AccNo = 125, Amount = 7000 };
                Customer c4 = new Customer() { Name = "Rajiv", AccNo = 126, Amount = 6000 };
                Customer c5 = new Customer() { Name = "Rahil", AccNo = 127, Amount = 5500 };
                List<Customer> customerls = new List<Customer>();
                customerls.Add(c1);
                customerls.Add(c2);
                customerls.Add(c3);
                customerls.Add(c4);
                customerls.Add(c5); 

                string filepath = "C:\\Raghuvarun.txt";
                StreamWriter sw = new StreamWriter(filepath);
                sw.WriteLine("-------------------------------------------------------");
                sw.WriteLine("Name       ||        Account No       ||     Balance  |");
                sw.WriteLine("-------------------------------------------------------");

                foreach (Customer Cust in customerls)
                {
                    sw.WriteLine($"   { Cust.Name}   ||         {Cust.AccNo}             ||    {Cust.Amount}      |");
                    sw.WriteLine("-------------------------------------------------------");
                }

                sw.Close();


                //  public static void CustomerDetails(List<Customer> customerls)

                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Name       ||        Account No       ||     Balance  |");
                Console.WriteLine("-------------------------------------------------------");
                foreach (Customer Cust in customerls)
                {

                    Console.WriteLine($"   { Cust.Name}   ||         {Cust.AccNo}             ||    {Cust.Amount}      |");
                    Console.WriteLine("-------------------------------------------------------");
                }




            }
        }
    }














