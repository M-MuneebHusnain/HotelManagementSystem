
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            // customer class type object declaration
            Customer customer = new Customer();
            // variable declaration
            int c, p;
            Console.WriteLine("\t\tWELCOME");
            Main:
            Console.WriteLine("\n\t***HOTEL MANAGEMENT SYSTEM***");
            Console.WriteLine("\n\t1-Record Customer Information");
            Console.WriteLine("\n\t2-Room Information");
            Console.WriteLine("\n\t3-Room Selection");
            Console.WriteLine("\n\t4-Booking");
            Console.WriteLine("\n\t5-Room Service/Restaurant");
            Console.WriteLine("\n\t6-Guest Details");
            Console.WriteLine("\n\t7-Checkout");
            Console.WriteLine("\n\t8-Exit");
            Console.WriteLine("\n\t(Select Option 1-8)"); 
            c = Convert.ToInt32(Console.ReadLine());
            // switch statement for menu working
            switch (c)
            {
                case 1:
                    {
                        Console.Clear();
                        customer.Record_Customer();
                        Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                        p = Convert.ToInt32(Console.ReadLine());
                        if (p == 1)
                        {
                            Console.Clear();
                            goto Main;
                        }
                        else
                           break;
                    }
                case 2:
                    {
                        Console.Clear();
                        customer.RoomInfo();
                        Console.WriteLine("\n*\nIf you liked our Room, Proceed to Booking.\n*If you already have booked, Proceed to Room Selection.");
                        Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                        p = Convert.ToInt32(Console.ReadLine());
                        if (p == 1)
                        {
                            Console.Clear();
                            goto Main;
                        }
                        else
                            break;
                    }
                case 3:
                    {
                        Console.Clear();
                        customer.Room();
                        Console.WriteLine("\n*Have some food proceed to Room Service.\n\n");
                        Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                        p = Convert.ToInt32(Console.ReadLine());
                        if (p == 1)
                        {
                            Console.Clear();
                            goto Main;
                        }
                        else
                            break;
                    }
                case 4:
                    {
                        Console.Clear();
                        customer.Booking();
                        Console.WriteLine("\n\nCheck Out Rooms in Room Information.\n");
                        Console.WriteLine("\n*Proceed to Room Selection, If already selected Total Bill will be updated.\n\n");
                        Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                        p = Convert.ToInt32(Console.ReadLine());
                        if (p == 1)
                        {
                            Console.Clear();
                            goto Main;
                        }
                        else
                            break;
                    }

                case 5:
                    {
                        Console.Clear();
                        customer.restaurant();
                        Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                        p = Convert.ToInt32(Console.ReadLine());
                        if (p == 1)
                        {
                            Console.Clear();
                            goto Main;
                        }
                        else
                            break;
                    }
                case 6:
                    {
                        Console.Clear();
                        customer.details();
                        Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                        p = Convert.ToInt32(Console.ReadLine());
                        if (p == 1)
                        {
                            Console.Clear();
                            goto Main;
                        }
                        else
                            break;
                    }
                case 7:
                    {
                        Console.Clear();
                        customer.checkout();
                        Console.WriteLine("\n\nDo you want to return to Main Menu?\n\nPress 1 for Yes\nPress any key to Exit.");
                        p = Convert.ToInt32(Console.ReadLine());
                        if (p == 1)
                        {
                            Console.Clear();
                            goto Main;
                        }
                        else
                            break;
                    }
                case 8:
                    {
                        Console.Clear();
                        Console.WriteLine("\n\nGOOD BYE");
                        break;
                    }

                default:
                    {
                        Console.Clear();
                        Console.WriteLine("\n\nSelect valid option.\nEnter Again");
                        Console.Clear();
                        goto Main;
                    }
            }
            Console.ReadKey();
        }
    }
}
