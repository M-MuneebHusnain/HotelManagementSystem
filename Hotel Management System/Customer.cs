using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    class Customer
    {
        //Variable and array declaration
        string[] Name = new string[50];
        string[] Phone = new string[50];
        string[] Address = new string[50];
        string[] Roomtype = new string[50];
        string[] Stay = new string[50];
        int[] Days = new int[50];
        int[] RoomNo = new int[50];
        int[] Rprice = new int[50];
        int[] Resprice = new int[50];
        int[] Total = new int[50];
        int ch, payment, newcust;
        string custlist;


        // function to check checkin customer

        public void CustomerLimit()
        {
        CustRep:
            
            //exception handling
            try
            {
                Console.WriteLine("\n\nHow many Customers want to book room? (Max 50) ");
                custlist = Console.ReadLine();
                newcust = Convert.ToInt32(custlist);

            }
            catch
            {
                if (string.IsNullOrEmpty(custlist) || (!custlist.All(char.IsDigit)) || newcust == 0)
                {
                    Console.WriteLine("\nNo Alphabets & Null Spaces Allowed.");
                    Console.WriteLine("\nEnter Customer in Positive Number(s) Only.");
                    goto CustRep;
                }
            }
            
            if (newcust > 50)
            {
                Console.WriteLine("\n\nMaximum 50 Customers Allowed\n\nEnter Again");
                goto CustRep;
            }

        }
    
        //function for getting customer details
        public void Record_Customer()
        {
            CustomerLimit();
        repeats:
            for (int i = 0; i < newcust; i++)
            {
                Console.WriteLine("\nDetails of Customer: "+  (i+1));
                Console.WriteLine("\nCustomer Name ");
                Name[i] = Console.ReadLine();
                if (Name[i].All(char.IsDigit) || string.IsNullOrEmpty(Name[i]))
                {
                    Console.WriteLine("\nEnter Valid Name, No Number & Null Spaces");
                    goto repeats;
                }
        repeat:
                Console.WriteLine("\nCustomer Phone Number");
                Phone[i] = Console.ReadLine();
                if (!Phone[i].All(char.IsDigit) || string.IsNullOrEmpty(Phone[i]))
                {
                    Console.WriteLine("\nEnter Number Only, No Alphabets & Null Spaces");
                    goto repeat;
                }
        repeat0:
                Console.WriteLine("\nCustomer Address");
                Address[i] = Console.ReadLine();
                if (Address[i].All(char.IsDigit) || string.IsNullOrEmpty(Address[i]))
                {
                    Console.WriteLine("\nEnter Valid Address & Null Spaces");
                    goto repeat0;
                }
            }
            Console.WriteLine("\nInformation Recorded.");
        }


        //function for getting basic room information & rate
        public void RoomInfo()
        {
            Console.WriteLine("\n\n\tRooms Available");

            Console.WriteLine("\n1-King Room @ RS 3000 Per Night");

            Console.WriteLine("\n\n2-Queen Room @ RS 5000 Per Night");

            Console.WriteLine("\n\n3-Presedential Suite @ RS 7000 Per Night");

        }

        //function to select room
        public void Room()
        {
        repeat2:
            for (int p = 0; p < newcust; p++)
            {
                Console.WriteLine("\nBook Room for Customer No. " + (p + 1) + "  Name: " + Name[p]);
                RoomInfo();
                Console.WriteLine("\n\n4-Exit");
                Console.WriteLine("\n\n\tSelect Room");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Roomtype[p] = "\nKing Room";
                            Console.WriteLine("---------------------------------------------------------------");
                            Console.WriteLine("Room amenities include: 1 King Bed, LED,");
                            Console.WriteLine("Free Telephone, Triple-Door Cupboard, 1 Coffee table with 2 sofa, ");
                            Console.WriteLine("2 Side tables, Hill side window");
                            Console.WriteLine("attached washroom with hot/cold water + AC and free Wifi.\n\n");
                            Console.WriteLine("\nRoom No. " + RoomNo[p]);
                            Console.WriteLine("\n" + Roomtype[p] + " Booked\n\n");
                            Rprice[p] = 3000;
                            break;
                        }
                    case 2:
                        {
                            Roomtype[p] = "\nQueen Room";
                            Console.WriteLine("---------------------------------------------------------------");
                            Console.WriteLine("Room amenities include: 1 Queen Bed, LED,");
                            Console.WriteLine("Free Telephone, Triple-Door Cupboard, 1 Coffee table with 2 sofa, ");
                            Console.WriteLine("2 Side tables, Balcony with Chair");
                            Console.WriteLine("attached washroom with hot/cold water + AC and free Wifi.\n\n");
                            Console.WriteLine("\nRoom No. " + RoomNo[p]);
                            Console.WriteLine("\n" + Roomtype[p] + " Booked\n\n");
                            Rprice[p] = 5000;
                            break;
                        }
                    case 3:
                        { 
                            Roomtype[p] = "\nPresedential Suite";
                            Console.WriteLine("---------------------------------------------------------------");
                            Console.WriteLine("Room amenities include: 1 President Bed, LED,");
                            Console.WriteLine("Free Telephone, Triple-Door Cupboard, 1 Coffee table with 2 sofa, ");
                            Console.WriteLine("2 Side tables, Balcony with an Accent table with 2 Chair and an");
                            Console.WriteLine("attached washroom with hot/cold water + AC, Wifi & free Breakfast.\n\n");
                            Console.WriteLine("\nRoom No. " + RoomNo[p]);
                            Console.WriteLine("\n" + Roomtype[p] + " Booked\n\n");
                            Rprice[p] = 7000;
                            break;
                        }
                    case 4:
                        {   
                            Console.WriteLine("\nGOOD BYE");
                            Rprice[p] = 0;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nEnter Valid choice only.(1-4)");
                            goto repeat2;
                        }
                }
            }

        }

        // function for booking 
        public void Booking()
        {
        bookrepeat:
            string y;
            int y1;
            Console.WriteLine("\nHave you already entered Customer Details?\n\t1- For New Entry\n\t2- If Already Filled");
            Console.WriteLine("\nSelect Option (1-2)");
            y = Console.ReadLine();
            y1 = Convert.ToInt32(y);
            if (!y.All(char.IsDigit) || string.IsNullOrEmpty(y) || (y1 < 1||y1 > 2 ))
            {
                Console.WriteLine("\nEnter Number Only, No Alphabets & Null Spaces");
                Console.WriteLine("\nSelect Valid Option ");
                goto bookrepeat;
            }

            if (y1 == 1)
            {
                Record_Customer();
            repeat1:
                for (int i = 0; i < newcust; i++)
                {
                    Console.WriteLine("\n\nStay Duration for Customer No. " + (i + 1) + "  Name:" + Name[i] + " in days " + " in Room No."+RoomNo[i]);
                    Stay[i] = Console.ReadLine();
                    if (!Stay[i].All(char.IsDigit) && string.IsNullOrEmpty(Stay[i]))
                    {
                        Console.WriteLine("\nEnter Number Only");
                        goto repeat1;
                    }
                    Days[i] = Convert.ToInt32(Stay[i]);
                }
                Console.WriteLine("\n\nInformation Recorded.");
            }
            else if  (y1 == 2)
            {
                repeat1:
                for (int i = 0; i < newcust; i++)
                {
                    Console.WriteLine("\n\nStay Duration for Customer No. " + (i + 1) + "  " + Name[i] + " in days " + " in Room No. "+ RoomNo[i]);
                    Stay[i] = Console.ReadLine();
                    if (!Stay[i].All(char.IsDigit) && string.IsNullOrEmpty(Stay[i]))
                    {
                        Console.WriteLine("\nEnter Number Only");
                        goto repeat1;
                    }
                    Days[i] = Convert.ToInt32(Stay[i]);
                }
                Console.WriteLine("\n\nInformation Recorded.");
            }
            else
            {
                Console.WriteLine("\nSelect Valid Option");
                goto bookrepeat;
            }
        }

        // function for fetching payment details
        public void Payment_Mode()
        {
            pay1:
            Console.WriteLine("\nPlease Select Payment Method");
            Console.WriteLine("\n\n1-Card\n\n2-Cash");
            payment = Convert.ToInt32(Console.ReadLine());
            if (payment == 1)
            {
                Console.WriteLine("Enter your Card Number");
                int card = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your Expiry Year (MM/YY)");
                string expiry = Console.ReadLine();

                Console.WriteLine("Enter your CVV");
                int cvv = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPayment Type: Credit Card/ Debit Card\n");
            }
            else if (payment == 2)
            {
                Console.WriteLine("\nPayment Type: Cash\n");
                Console.WriteLine("\nPlease Pay Bill at counter");
            }
            else
            {
                Console.WriteLine("\nSelect Valid Option");
                goto pay1;
            }
        }


        // function for room service
        public void restaurant()
        {
        repeat3:
            for (int p = 0; p < newcust; p++)
            {
                Console.WriteLine("\nOrder food for Customer No. " + (p + 1) + "  Name:" + Name[p] +" in Room No. " + RoomNo[p]);
                Console.WriteLine("\n\nWelcome to Restaurant");
                Console.WriteLine("\n\n\t\tMENU");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("\n\n1-Chicken Karahi @ 700"); Console.WriteLine("\n\n2-Chicken Biryani @ 200");
                Console.WriteLine("\n\n3-Chicken Tikka @ 220"); Console.WriteLine("\n\n4-Chicken Qorma @ 600");
                Console.WriteLine("\n\n5-Exit");
                Console.WriteLine("\n");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Resprice[p] = 700;                           
                            Payment_Mode();
                            Console.WriteLine("\nFood Ordered Successfully\n\n");
                            break;
                        }
                    case 2:
                        {
                            Resprice[p] = 200;                            
                            Payment_Mode();
                            Console.WriteLine("\nFood Ordered Successfully\n\n");
                            break;
                        }
                    case 3:
                        { 
                            Resprice[p] = 220;
                            Payment_Mode();
                            Console.WriteLine("\nFood Ordered Successfully\n\n");
                            break;
                        }
                    case 4:
                        {
                            Resprice[p] = 600;
                            Payment_Mode();
                            Console.WriteLine("\nFood Ordered Successfully\n\n");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("\nGOOD BYE");
                            Resprice[p] = 0;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nEnter Valid choice only.(1-5)");
                            goto repeat3;
                        }

                }
            }

        }

        // record database for customers staying
        public void details()
        {
            Console.WriteLine("\n\n\t\tCustomer Details");
            for (int i = 0; i < newcust; i++)
            {
                Console.WriteLine("\n\tDetails of Customer No. " + (i + 1));
                Console.WriteLine("\nRoom No. " + RoomNo[i]);
                Console.WriteLine("\nCustomer Name: " + Name[i]);
                Console.WriteLine("\nCustomer Phone No. " + Phone[i]);
                Console.WriteLine("\nCustomer Address: " + Address[i]);
                Console.WriteLine("\nCustomer Stay Duration " + Stay[i] + (" Days"));
                Console.WriteLine("\nCustomer Room Type " + Roomtype[i]);
            }
        }

        //function for creating invoice
        public void checkout()
        {
            Console.WriteLine("\n\nWelcome to Checkout");
            Console.WriteLine("-----------------INVOICE-----------------");
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < newcust; i++)
            {
                Console.WriteLine("\n\tDetails of Customer No. " + (i + 1));
                Console.WriteLine("\nRoom No. " + RoomNo[i]);
                Console.WriteLine("\nCustomer Name: " + Name[i]);
                Console.WriteLine("\nCustomer Phone No. " + Phone[i]);
                Console.WriteLine("\nCustomer Address: " + Address[i]);
                Console.WriteLine("\nCustomer Stay Duration " + Stay[i] + (" Days"));
                Console.WriteLine("\nCustomer Room Type " + Roomtype[i]);
                Console.WriteLine("\nRoom Charges: " + (Days[i] * Rprice[i]));
                Console.WriteLine("\nRestaurant Charges: " + Resprice[i]);
                Total[i] = Resprice[i] + (Days[i] * Rprice[i]);
                Console.WriteLine("\n\n\t\tTotal Bill: " + Total[i]);
                Payment_Mode();
                
            }
            Console.WriteLine("\nTHANK YOU\nVisit Again");
        }
    }
}