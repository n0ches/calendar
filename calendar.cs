using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Zeller1, Z1, Z2, Z3, Z4, Z5, Z6;                            // I defined some variables to use at the Zeller's 
            int Zeller2, R1, R2, R3, R4, R5, R6;                           // algorithms implementation.
            int day1, day2, year2, year1;             
            int m1 = 0, m2 = 0, ayy1 = 0, ayy2 = 0,ayy3 = 0; ;           //m1 and m2 is the number of the months         
            int day_of_the_week = 0;                                    //March=3.................February=14 I deemed like that to can use 
            int same_year = 0;                                         //Zeller's algorithm. ayy1,ayy2 is the day count of the months.
            int y, s;                                                 //same_year is a variable that I used for explain to the computer to year equality.
            string month1, month2;
            string season="";                           // month1 and month2 to store months names as string
            string month = "";

            //First date
            //I use do-while loop to loop the game if user enter wrong inputs
            do
            {
                Console.WriteLine("Enter the first date");
                Console.Write("Day: ");
                day1 = Convert.ToInt32(Console.ReadLine());        //I received data from the user here.
                Console.Write("Month: ");
                string mixed1;                                       
                mixed1 = Console.ReadLine();                      // I used the "ToLower" to prevent to letter's cases sensivity.
                month1 = mixed1.ToLower();
                Console.Write("Year: ");
                year1 = Convert.ToInt32(Console.ReadLine());
                if (month1 == "March" || month1 == "march")
                {

                    m1 = 3; ayy1 = 31;
                    season = "Spring";
                }

                else if (month1 == "April" || month1 == "april")
                {
                    m1 = 4; ayy1 = 30;
                    season = "Spring";
                }

                else if (month1 == "May" || month1 == "may")
                {
                    m1 = 5; ayy1 = 31;
                    season = "Spring";
                }

                else if (month1 == "June" || month1 == "june")
                {
                    m1 = 6; ayy1 = 30;
                    season = "Summer";
                }

                else if (month1 == "July" || month1 == "july")
                {
                    m1 = 7; ayy1 = 31;
                    season = "Summer";
                }

                else if (month1 == "August" || month1 == "august")
                {
                    m1 = 8; ayy1 = 31;
                    season = "Summer";
                }

                else if (month1 == "September" || month1 == "september")
                {
                    m1 = 9; ayy1 = 30;
                    season = "Fall";
                }

                else if (month1 == "October" || month1 == "october")
                {
                    m1 = 10; ayy1 = 31;
                    season = "Fall";
                }

                else if (month1 == "November" || month1 == "november")
                {
                    m1 = 11; ayy1 = 30;
                    season = "Fall";
                }

                else if (month1 == "December" || month1 == "december")
                {
                    m1 = 12; ayy1 = 31;
                    season = "Winter";
                }

                else if (month1 == "January" || month1 == "january")
                {
                    m1 = 13; ayy1 = 31;
                    season = "Winter";
                }

                else if (month1 == "February" || month1 == "february")
                {
                    season = "Winter";
                    m1 = 14;
                    if (year1 % 4 == 0)
                    {
                        ayy1 = 29;
                    }
                    else
                    {
                        ayy1 = 28;
                    }
                }
                else
                {
                    m1 = 15;
                }

                //Error messages
                if (year1 >= 0)
                {


                    if (m1 != 15)
                    {
                        if (ayy1 == 30)
                        {
                            if ((day1 > 30) || (day1 < 1))
                            {
                                Console.WriteLine("Day is wrong.");             
                            }
                            else { }
                        }
                        else if (ayy1 == 31)
                        {
                            if ((day1 > 31) || (day1 < 1))
                            {
                                Console.WriteLine("Day is wrong.");
                            }
                            else { }
                        }
                        else if (ayy1 == 28)
                        {
                            if ((day1 > 28) || (day1 < 1))
                            {
                                Console.WriteLine("Day is wrong.");
                            }
                            else { }
                        }
                        else if (ayy1 == 29)
                        {
                            if ((day1 > 29) || (day1 < 1))
                            {
                                Console.WriteLine("Day is wrong.");
                            }
                            else { }
                        }
                    }


                    if ((m1 == 15 && ((day1 > 30) || (day1 < 1))))
                    {
                        Console.WriteLine("Day and Month are wrong.");
                    }
                    else if (m1 == 15)
                    {
                        Console.WriteLine("Month is wrong");
                    }
                }
                else if (year1 < 0)
                {
                    if (m1 != 15)
                    {
                        if (ayy1 == 30)
                        {
                            if ((day1 > 30) || (day1 < 1))
                            {
                                Console.WriteLine("Day and Year are wrong.");
                            }
                            else { }
                        }
                        else if (ayy1 == 31)
                        {
                            if ((day1 > 31) || (day1 < 1))
                            {
                                Console.WriteLine("Day and Year are wrong.");
                            }
                            else { }
                        }
                        else if (ayy1 == 28)
                        {
                            if ((day1 > 28) || (day1 < 1))
                            {
                                Console.WriteLine("Day and Year are wrong.");
                            }
                            else { }
                        }
                        else if (ayy1 == 29)
                        {
                            if ((day1 > 29) || (day1 < 1))
                            {
                                Console.WriteLine("Day and Year are wrong.");
                            }
                            else { }
                        }
                    }


                    if ((m1 == 15 && ((day1 > 30) || (day1 < 1))))
                    {
                        Console.WriteLine("Day, Month and Year are wrong.");
                    }
                    else if (m1 == 15)
                    {
                        Console.WriteLine("Month and Year are wrong");
                    }
                }
                //Error messages

            } while ((m1 == 15) || (m1 == 14 && year1 % 4 != 0 && day1 > 28) || (day1 < 1) || (ayy1 == 30 && day1 > 30) || (ayy1 == 31 && day1 > 31));
            //I use do-while loop to loop the game if user enter wrong inputs
            //First date

            //Second date
            //I use do-while loop to loop the game if user enter wrong inputs
            do
            {
                Console.WriteLine("Enter the second date");
                Console.Write("Day: ");
                day2 = Convert.ToInt32(Console.ReadLine());                     //I received data from the user here.                
                Console.Write("Month: ");
                string mixed2;                                                 // I used the "ToLower" to prevent to letter's cases sensivity.
                mixed2 = Console.ReadLine();
                month2 = mixed2.ToLower();                                      
                Console.Write("Year: ");
                year2 = Convert.ToInt32(Console.ReadLine());
                if (month2 == "March" || month2 == "march")
                {

                    m2 = 3; ayy2 = 31;
                }
                else if (month2 == "April" || month2 == "april")
                {

                    m2 = 4; ayy2 = 30;
                }
                else if (month2 == "May" || month2 == "may")
                {

                    m2 = 5; ayy2 = 31;
                }
                else if (month2 == "June" || month2 == "june")
                {

                    m2 = 6; ayy2 = 30;
                }
                else if (month2 == "July" || month2 == "july")
                {

                    m2 = 7; ayy2 = 31;
                }
                else if (month2 == "August" || month2 == "august")
                {

                    m2 = 8; ayy2 = 31;
                }
                else if (month2 == "September" || month2 == "september")
                {

                    m2 = 9; ayy2 = 30;
                }
                else if (month2 == "October" || month2 == "october")
                {

                    m2 = 10; ayy2 = 31;
                }
                else if (month2 == "November" || month2 == "november")
                {

                    m2 = 11; ayy2 = 30;
                }
                else if (month2 == "December" || month2 == "december")
                {

                    m2 = 12; ayy2 = 31;
                }
                else if (month2 == "January" || month2 == "january")
                {

                    m2 = 13; ayy2 = 31;
                }
                else if (month2 == "February" || month2 == "february")
                {
                    m2 = 14;
                    if (year2 % 4 == 0)
                    {
                        ayy2 = 29;
                    }
                    else
                    {
                        ayy2 = 28;
                    }
                }
                else
                {
                    m2 = 15;
                }

                //Error messages
                if (year2 >= 0)
                {


                    if (m2 != 15)
                    {
                        if (ayy2 == 30)
                        {
                            if ((day2 > 30) || (day2 < 1))
                            {
                                Console.WriteLine("Day is wrong.");
                            }
                            else { }
                        }
                        else if (ayy2 == 31)
                        {
                            if ((day2 > 31) || (day2 < 1))
                            {
                                Console.WriteLine("Day is wrong.");
                            }
                            else { }
                        }
                        else if (ayy2 == 28)
                        {
                            if ((day2 > 28) || (day2 < 1))
                            {
                                Console.WriteLine("Day is wrong.");
                            }
                            else { }
                        }
                        else if (ayy2 == 29)
                        {
                            if ((day2 > 29) || (day2 < 1))
                            {
                                Console.WriteLine("Day is wrong.");
                            }
                            else { }
                        }
                    }


                    if ((m2 == 15 && ((day2 > 30) || (day2 < 1))))
                    {
                        Console.WriteLine("Day and Month are wrong.");
                    }
                    else if (m2 == 15)
                    {
                        Console.WriteLine("Month is wrong");
                    }
                }
                else if (year2 < 0)
                {
                    if (m2 != 15)
                    {
                        if (ayy2 == 30)
                        {
                            if ((day2 > 30) || (day2 < 1))
                            {
                                Console.WriteLine("Day and Year are wrong.");
                            }
                            else { }
                        }
                        else if (ayy2 == 31)
                        {
                            if ((day2 > 31) || (day2 < 1))
                            {
                                Console.WriteLine("Day and Year are wrong.");
                            }
                            else { }
                        }
                        else if (ayy2 == 28)
                        {
                            if ((day2 > 28) || (day2 < 1))
                            {
                                Console.WriteLine("Day and Year are wrong.");
                            }
                            else { }
                        }
                        else if (ayy2 == 29)
                        {
                            if ((day2 > 29) || (day2 < 1))
                            {
                                Console.WriteLine("Day and Year are wrong.");
                            }
                            else { }
                        }
                    }


                    if ((m2 == 15 && ((day2 > 30) || (day2 < 1))))
                    {
                        Console.WriteLine("Day, Month and Year are wrong.");
                    }
                    else if (m2 == 15)
                    {
                        Console.WriteLine("Month and Year are wrong");
                    }
                }
                //Error messages

            } while ((m2 == 15) || (m2 == 14 && year2 % 4 != 0 && day2 > 28) || (day2 < 1) || (ayy2 == 30 && day2 > 30) || (ayy2 == 31 && day2 > 31));
            //I use do-while loop to loop the game if user enter wrong inputs
            //Second date


            
            Z1 = day1;
            Z2 = ((13 * (m1 + 1)) / 5);
            Z3 = (year1);Z4 = (year1 / 4);                                  //Zeller's algorithms implementation for the first date
            Z5 = (year1 / 100);                                            //Zeller1 = 0 ------> Saturday
            Z6 = (year1 / 400);                                           //Zeller1 = 1 ------> Sunday
            Zeller1 = (Z1 + Z2 + Z3 + Z4 - Z5 + Z6) % 7;                 //Zeller1 = 2 ------> Monday
                                                                        //Zeller1 = 3 ------> Tuesday
                                                                       //Zeller1 = 4 ------> Wednesday
            if (month1 == "february")                                 //Zeller1 = 5 ------> Thursday
            {                                                        //Zeller1 = 6 ------> Friday
                if (year1 % 4 == 0)
                {
                    Zeller1 = Zeller1 - 2;
                }
                else
                {
                    Zeller1 = Zeller1 - 1;                       // Zeller's algorithms implementation for the leap years
                }                                               //and the first month of the year.
            }
            else if (month1 == "january")
            {
                if (year1 % 4 == 0)
                {
                    Zeller1 = Zeller1 - 2;
                }
                else
                {
                    Zeller1 = Zeller1 - 1;
                }
            }

            R1 = day2;
            R2 = ((13 * (m2 + 1)) / 5);
            R3 = (year2);
            R4 = (year2 / 4);                               //Zeller's algorithms implementation for the second date.
            R5 = (year2 / 100);     
            R6 = (year2 / 400);
            Zeller2 = (R1 + R2 + R3 + R4 - R5 + R6) % 7;

            if (month1 == "february")
            {
                if (year1 % 4 == 0)
                {
                    Zeller2 = Zeller2 - 2;
                }
                else
                {
                    Zeller2 = Zeller2 - 1;                             // Zeller's algorithms implementation for the leap years            
                }                                                     //and the first month of the year.
            }
            else if (month1 == "january")
            {
                if (year1 % 4 == 0)
                {                                                                               
                    Zeller2 = Zeller2 - 2;
                }
                else
                {
                    Zeller2 = Zeller2 - 1;
                }
            }

            if (ayy1 == 30)
            {
                if ((day1 > 30) || (day1 < 1))
                {
                    Console.WriteLine("Day is wrong.");
                }
                else { }
            }
            else if (ayy1 == 31)
            {
                if ((day1 > 31) || (day1 < 1))
                {
                    Console.WriteLine("Day is wrong.");
                }
                else { }
            }
            int y1 = year1, y2=year2;  //-------> This is for using at the same years algorithm

            //Schedule algorithm
           //I used do-while loops to print schedule that between two different dates consecutively
            do
            {
                //Between two dates in different years
                if (year2 > year1)
                {
                    Console.Clear();
                    Console.WriteLine(month1 + " " + year1);
                    Console.WriteLine("Mo Tu We Th Fr Sa Su");                     //Firstly, I printed first month that I took from the user to the screen 
                    schedule2_first_month();  //This is the method that print schedule to the screen. I explain this algorithm in itself.
                    if ((ayy1 == 31 && Zeller1 == 4) || (ayy1 == 30 && Zeller1 == 5)) 
                    {


                        Zeller2 = ((Zeller1 + ((ayy1 - day1) % 7)) + 1) % 7;          // This is the algorithm that used for determine 
                                                                                     //start day for next month.
                    }
                    else
                    {
                        Zeller2 = (Zeller1 + ((ayy1 - day1) % 7)) % 7;
                        Zeller2 = Zeller2 + 1;
                    }
                    
                    
                    if (m1 > 12)
                    {
                        s = m1 % 12;
                    }                                     // I defined some variables. Because I encountered some issues in the for loops.
                    else                                 //those issues are based on December,January,and February because their m1 or m2 values are
                    {                                   //12,13,14. This making a fuss in the loop. Thus, ı defined some variables again and use them
                        s = m1;                        //in the loops.
                    }

                    if (m2 > 12)
                    {
                        y = m2 % 12;
                    }
                    else
                    {
                        y = m2;
                    }
                    
                    int u = s;
                    //Printed schedule algorithm
                    //This loop for from the first month the user enters to the end of that year
                    do
                    {
                        
                        for (int i = s+1; i <= 12; i++)
                        {
                            Console.WriteLine("\n");
                            switch (m1)
                            {                                               
                                case 14:
                                    month = "March"; ayy3 = 31; season = "Spring";
                                    break;
                                case 3:
                                    month = "April"; ayy3 = 30; season = "Spring";
                                    break;
                                case 4:
                                    month = "May"; ayy3 = 31; season = "Spring";
                                    break;
                                case 5:
                                    month = "June"; ayy3 = 30; season = "Summer";
                                    break;
                                case 6:
                                    month = "July"; ayy3 = 31; season = "Summer";
                                    break;
                                case 7:
                                    month = "August"; ayy3 = 31; season = "Summer";
                                    break;
                                case 8:
                                    month = "September"; ayy3 = 30; season = "Fall";
                                    break;
                                case 9: 
                                    month = "October"; ayy3 = 31; season = "Fall";
                                    break;
                                case 10:
                                    month = "November"; ayy3 = 30; season = "Fall";
                                    break;
                                case 11:
                                    month = "December"; ayy3 = 31; season = "Winter";
                                    break;
                                case 12:
                                    month = "January"; ayy3 = 31; season = "Winter";
                                    break;
                                case 13:
                                    month = "February"; season = "Winter";
                                    if (year1 % 4 == 0)
                                    {
                                        ayy3 = 29;
                                    }
                                    else
                                    {
                                        ayy3 = 28;
                                    }
                                    break;
                                default:
                                    break;

                            }

                            Console.WriteLine(month + " " + year1 + "-" + season);
                            Console.WriteLine("Mo Tu We Th Fr Sa Su");
                            if (s < (13))
                            {
                                schedule3_j(); //Another method, I will explain them in itselfs
                                if ((ayy3 == 31 && Zeller2 == 4) || (ayy3 == 30 && Zeller2 == 5))
                                {
                                    Zeller2 = ((Zeller2 + ((ayy3 - 1) % 7)) + 1) % 7;    // This is the algorithm that used for determine 
                                                                                        //start day for next month.
                                }
                                else
                                {
                                    Zeller2 = (Zeller2 + ((ayy3 - 1) % 7)) % 7;
                                    Zeller2 = Zeller2 + 1;
                                }
                            }
                            if (m1 > 13)
                            {                                   //I used if-statement here because for january and month m1's value was making
                                m1 = m1 % 12 + 1;              //a fuss. Because their value is 13 and 14.
                            }
                            else
                            {
                                m1++;
                            }

                        }

                        year1 = year1 + 1;
                    } while (s > 12);
                    //This loop for from the first month the user enters to the end of that year

                    //I use this loop if I have not-printed full year.
                    do
                    {
                        //The code is looping until the years are equal
                        if (year1 != year2)
                        {
                            m1 = 13; month1 = "January";                            //I firstly printed first month of the year
                            ayy1 = 31;
                            Console.WriteLine("\n");                      
                            Console.WriteLine(month1 + " " + year1 + "-" +season);
                            Console.WriteLine("Mo Tu We Th Fr Sa Su");
                            schedule4_january(); //Another method, I will explain them in itselfs
                            if ((ayy1 == 31 && Zeller2 == 4) || (ayy1 == 30 && Zeller2 == 5))
                            {


                                Zeller2 = ((Zeller2 + ((ayy1 - 1) % 7)) + 1) % 7;           // This is the algorithm that used for determine 
                                                                                           //start day for next month.
                            }
                            else
                            {
                                Zeller2 = (Zeller2 + ((ayy1 - 1) % 7)) % 7;
                                Zeller2 = Zeller2 + 1;
                            }
                            

                            if (m1 > 12)
                            {
                                s = m1 % 12;
                            }
                            else
                            {
                                s = m1;                          //I used if-statement here because for january and month m1's value was making
                            }                                   //a fuss. Because their value is 13 and 14.

                            if (m2 > 12)
                            {
                                y = m2 % 12;
                            }
                            else
                            {
                                y = m2;
                            }
                            m1++;

                            //This is algorithm that used for print months except January
                            do
                            {
                                for (int i = s+1; i <= 12; i++)
                                {
                                    Console.WriteLine("\n");
                                    switch (m1)
                                    {
                                        case 3:
                                            month = "March"; ayy3 = 31; season = "Spring";
                                            break;
                                        case 4:
                                            month = "April"; ayy3 = 30; season = "Spring";
                                            break;
                                        case 5:
                                            month = "May"; ayy3 = 31; season = "Spring";
                                            break;
                                        case 6:
                                            month = "June"; ayy3 = 30; season = "Summer";
                                            break;
                                        case 7:
                                            month = "July"; ayy3 = 31; season = "Summer";
                                            break;
                                        case 8:                                         // I defined this variable to use at the loops.
                                            month = "August"; ayy3 = 31; season = "Summer";
                                            break;
                                        case 9:
                                            month = "September"; ayy3 = 30; season = "Fall";
                                            break;
                                        case 10:
                                            month = "October"; ayy3 = 31; season = "Fall";
                                            break;
                                        case 11:
                                            month = "November"; ayy3 = 30; season = "Fall";
                                            break;
                                        case 12:
                                            month = "December"; ayy3 = 31; season = "Winter";
                                            break;
                                        case 13:
                                            month = "January"; ayy3 = 31; season = "Winter";
                                            break;
                                        case 14:
                                            month = "February"; season = "Winter";
                                            if (year1 % 4 == 0)
                                            {
                                                ayy3 = 29;
                                            }
                                            else
                                            {
                                                ayy3 = 28;
                                            }
                                            break;
                                        default:
                                            break;

                                    }

                                    Console.WriteLine(month + " " + year1 + "-" + season);
                                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                    if (s < (13))
                                    {
                                        schedule3_j(); //Another method, I will explain them in itselfs

                                        if ((ayy3 == 31 && Zeller2 == 4) || (ayy3 == 30 && Zeller2 == 5))
                                        {
                                            Zeller2 = ((Zeller2 + ((ayy3 - 1) % 7)) + 1) % 7;  // This is the algorithm that used for determine 
                                                                                               //start day for next month.
                                        }
                                        else
                                        {
                                            Zeller2 = (Zeller2 + ((ayy3 - 1) % 7)) % 7;
                                            Zeller2 = Zeller2 + 1;
                                        }
                                    }
                                    if (m1 > 13)
                                    {
                                        m1 = m1 % 12 + 1;
                                    }
                                    else
                                    {
                                        m1++;
                                    }


                                }

                            } while ((s > 12));
                            //This is algorithm that used for print months except January

                            year1++;    // I increase year at the end of the loop because if years are equal, code must exit the this loop.

                        }
                        else { }
                        same_year = same_year + 1;  //I defined another variable that used for print the schedule if years are equal.
                    } while (year1 != year2);
                    //The code is looping until the years are equal

                    //If years are same, I use this statement and loop.
                    if (same_year == ((y2-y1)-1))
                    {
                        if (m2 == 13)
                        {
                           
                        }
                        else
                        {
                            m1 = 13; month1 = "January";
                            ayy1 = 31;
                            Console.WriteLine("\n");                                             //I firstly printed first month of the year
                            Console.WriteLine(month1 + " " + year1+"-"+season);
                            Console.WriteLine("Mo Tu We Th Fr Sa Su");
                            schedule4_january();  //Another method, I will explain them in itselfs
                            if ((ayy1 == 31 && Zeller2 == 4) || (ayy1 == 30 && Zeller2 == 5))
                            {


                                Zeller2 = ((Zeller2 + ((ayy1 - 1) % 7)) + 1) % 7;  // This is the algorithm that used for determine 
                                                                                  //start day for next month.
                            }
                            else
                            {
                                Zeller2 = (Zeller2 + ((ayy1 - 1) % 7)) % 7;
                                Zeller2 = Zeller2 + 1;
                            }

                            m1++;


                        }
                        int q;
                        if (m2 == 12)
                        {                                              //I used if-statement here because for january and month m1's value was making
                            q = m2;                                   //a fuss. Because their value is 13 and 14.
                        }
                        else
                        {
                            q = m2 % 12;
                        }




                        //This loop for the printed schedule up to second date's month and day.
                        do
                        {
                            for (int i = m1 % 12; i < q; i++)
                            {
                                Console.WriteLine("\n");
                                switch (m1)
                                {
                                    case 3:
                                        month = "March"; ayy3 = 31; season = "Spring";
                                        break;
                                    case 4:
                                        month = "April"; ayy3 = 30; season = "Spring";
                                        break;
                                    case 5:
                                        month = "May"; ayy3 = 31; season = "Spring";
                                        break;
                                    case 6:
                                        month = "June"; ayy3 = 30; season = "Summer";
                                        break;
                                    case 7:
                                        month = "July"; ayy3 = 31; season = "Summer";
                                        break;
                                    case 8:
                                        month = "August"; ayy3 = 31; season = "Summer";
                                        break;
                                    case 9:
                                        month = "September"; ayy3 = 30; season = "Fall";
                                        break;
                                    case 10:
                                        month = "October"; ayy3 = 31; season = "Fall";
                                        break;                                                   // I defined this variable to use at the loops.
                                    case 11:
                                        month = "November"; ayy3 = 30; season = "Fall";
                                        break;
                                    case 12:
                                        month = "December"; ayy3 = 31; season = "Winter";
                                        break;
                                    case 13:
                                        month = "January"; ayy3 = 31; season = "Winter";
                                        break;
                                    case 14:
                                        month = "February"; season = "Winter";
                                        if (year1 % 4 == 0)
                                        {
                                            ayy3 = 29;
                                        }
                                        else
                                        {
                                            ayy3 = 28;
                                        }
                                        break;
                                    default:
                                        break;

                                }

                                Console.WriteLine(month + " " + year1+"-"+season);
                                Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                if (m1 % 12 < (13))
                                {
                                    schedule3_j(); //Another method, I will explain them in itselfs
                                    if ((ayy3 == 31 && Zeller2 == 4) || (ayy3 == 30 && Zeller2 == 5))
                                    {
                                        Zeller2 = ((Zeller2 + ((ayy3 - 1) % 7)) + 1) % 7;  // This is the algorithm that used for determine 
                                                                                           //start day for next month.
                                    }
                                    else
                                    {
                                        Zeller2 = (Zeller2 + ((ayy3 - 1) % 7)) % 7;
                                        Zeller2 = Zeller2 + 1;
                                    }
                                }
                                if (m1 < 14)
                                {
                                    m1++;
                                }
                                else
                                {
                                    m1 = m1 % 12 + 1;
                                }

                            }
                            
                        } while ((m1 % 12 > m2));
                        //This loop for the printed schedule up to second date's month and day.

                        Console.WriteLine("\n");
                        Console.WriteLine(month2 + " " + year1 + "-" + season);
                        Console.WriteLine("Mo Tu We Th Fr Sa Su");          //This is for the printed schedule second date's month and day.
                        schedule5_j_day2(); //Another method, I will explain them in itselfs
                    }
                }
                
                //Thi statement is for the situation that years are equal.
                else if (year2 == year1)
                {

                    if (m1 > 12)
                    {
                        s = m1 % 12;
                    }
                    else
                    {
                        s = m1;              //I used if-statement here because for january and month m1's value was making
                    }                       //a fuss. Because their value is 13 and 14.

                    if (m2 > 12)
                    {
                        y = m2 % 12;
                    }
                    else
                    {
                        y = m2;
                    }

                    if (y > s)
                    {
                        Console.Clear();
                        Console.WriteLine(month1 + " " + year1 + "-" + season);
                        Console.WriteLine("Mo Tu We Th Fr Sa Su");
                        schedule2_first_month(); //Another method, I will explain them in itselfs
                        if ((ayy1 == 31 && Zeller1 == 4) || (ayy1 == 30 && Zeller1 == 5))
                        {


                            Zeller2 = ((Zeller1 + ((ayy1 - day1) % 7)) + 1) % 7;  // This is the algorithm that used for determine 
                                                                                 //start day for next month.
                        }
                        else
                        {
                            Zeller2 = (Zeller1 + ((ayy1 - day1) % 7)) % 7;
                            Zeller2 = Zeller2 + 1;
                        }

                        int L = s + 1;
                        if (L > 12)
                        {
                            s = L % 12;
                        }
                        else
                        {
                            s = L;              //I used if-statement here because for january and month m1's value was making
                        }                       //a fuss. Because their value is 13 and 14.

                        if (m2 > 12)
                        {
                            y = m2 % 12;
                        }
                        else
                        {
                            y = m2;
                        }

                        do
                        {
                            for (int i = s; i < y; i++)
                            {

                                Console.WriteLine("\n");
                                switch (m1)
                                {
                                    case 14:
                                        month = "March"; ayy3 = 31; season = "Spring";
                                        break;
                                    case 3:
                                        month = "April"; ayy3 = 30; season = "Spring";
                                        break;
                                    case 4:
                                        month = "May"; ayy3 = 31; season = "Spring";
                                        break;
                                    case 5:
                                        month = "June"; ayy3 = 30; season = "Summer";
                                        break;
                                    case 6:
                                        month = "July"; ayy3 = 31; season = "Summer";
                                        break;
                                    case 7:
                                        month = "August"; ayy3 = 31; season = "Summer";
                                        break;
                                    case 8:
                                        month = "September"; ayy3 = 30; season = "Fall";                     // I defined this variable to use at the loops.
                                        break;
                                    case 9:
                                        month = "October"; ayy3 = 31; season = "Fall";
                                        break;
                                    case 10:
                                        month = "November"; ayy3 = 30; season = "Fall";
                                        break;
                                    case 11:
                                        month = "December"; ayy3 = 31; season = "Winter";
                                        break;
                                    case 12:
                                        month = "January"; ayy3 = 31; season = "Winter";
                                        break;
                                    case 13:
                                        month = "February"; season = "Winter";
                                        if (year1 % 4 == 0)
                                        {
                                            ayy3 = 29;
                                        }
                                        else
                                        {
                                            ayy3 = 28;
                                        }
                                        break;
                                    default:
                                        break;

                                }

                                Console.WriteLine(month + " " + year1+"-" + season);
                                Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                if (s > 0)
                                {
                                    schedule3_j(); //Another method, I will explain them in itselfs

                                    if ((ayy3 == 31 && Zeller2 == 4) || (ayy3 == 30 && Zeller2 == 5))
                                    {
                                        Zeller2 = ((Zeller2 + ((ayy3 - 1) % 7)) + 1) % 7;  // This is the algorithm that used for determine 
                                                                                           //start day for next month.
                                    }
                                    else
                                    {
                                        Zeller2 = (Zeller2 + ((ayy3 - 1) % 7)) % 7;
                                        Zeller2 = Zeller2 + 1;
                                    }
                                }
                                if (m1 > 13)
                                {
                                    m1 = m1 % 12 + 1;
                                }
                                else
                                {
                                    m1++;
                                }

                            }


                        } while (s > y);
                        Console.WriteLine("\n");
                        Console.WriteLine(month2 + " " + year1+"-"+season);
                        Console.WriteLine("Mo Tu We Th Fr Sa Su");

                        schedule5_j_day2(); //Another method, I will explain them in itselfs

                    }

                    //This is statement for if years and months are the same.
                    else if (m2 % 12 == m1 % 12)
                    {
                        if (day1 < day2)
                        {
                            switch (m1)
                            {
                                case 3:
                                    Console.WriteLine(month1 + " " + year1+"-"+season);
                                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                    schedule_between_days();  //Another method, I will explain them in itselfs
                                    break;
                                case 4:
                                    Console.WriteLine(month1 + " " + year1 + "-" + season);
                                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                    schedule_between_days();  //Another method, I will explain them in itselfs
                                    break;
                                case 5:
                                    Console.WriteLine(month1 + " " + year1 + "-" + season);
                                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                    schedule_between_days();  //Another method, I will explain them in itselfs
                                    break;
                                case 6:
                                    Console.WriteLine(month1 + " " + year1 + "-" + season);
                                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                    schedule_between_days();  //Another method, I will explain them in itselfs
                                    break;
                                case 7:
                                    Console.WriteLine(month1 + " " + year1 + "-" + season);
                                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                    schedule_between_days();  //Another method, I will explain them in itselfs
                                    break;
                                case 8:
                                    Console.WriteLine(month1 + " " + year1 + "-" + season);
                                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                    schedule_between_days();  //Another method, I will explain them in itselfs
                                    break;
                                case 9:
                                    Console.WriteLine(month1 + " " + year1 + "-" + season);
                                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                    schedule_between_days(); //Another method, I will explain them in itselfs
                                    break;
                                case 10:
                                    Console.WriteLine(month1 + " " + year1 + "-" + season);
                                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                    schedule_between_days();  //Another method, I will explain them in itselfs
                                    break;
                                case 11:
                                    Console.WriteLine(month1 + " " + year1 + "-" + season);
                                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                    schedule_between_days();  //Another method, I will explain them in itselfs
                                    break;
                                case 12:
                                    Console.WriteLine(month1 + " " + year1 + "-" + season);
                                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                    schedule_between_days();  //Another method, I will explain them in itselfs
                                    break;
                                case 13:
                                    Console.WriteLine(month1 + " " + year1 + "-" + season);
                                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                    schedule_between_days();  //Another method, I will explain them in itselfs
                                    break;
                                case 14:
                                    Console.WriteLine(month1 + " " + year1 + "-" + season);
                                    Console.WriteLine("Mo Tu We Th Fr Sa Su");
                                    schedule_between_days(); //Another method, I will explain them in itselfs
                                    break;

                            }

                        }

                        //Error message statement. The first date must be before the second date.
                        else if (day2 < day1)
                        {
                            Console.WriteLine("The first date must be before the second date.");
                        }
                        else //Error message statement. The first date must be before the second date.
                        {
                            Console.WriteLine("The first date must be before the second date.");
                        }
                    }
                    else //Error message statement. The first date must be before the second date.
                    {
                        Console.WriteLine("The first date must be before the second date.");
                    }
                }

                //Error message statement. The first date must be before the second date.
                else if (year2 < year1)
                {
                    Console.WriteLine("The first date must be before the second date.");
                }
                //Error message statement. The first date must be before the second date.

                Console.ReadLine();

                //This method is for print schedule from the same year and month
                void schedule_between_days()
                {
                    // If Zeller is 1, day is sunday. // If Zeller is 2, day is monday. // If Zeller is 3, day is tuesday. // If Zeller is 4, day is wednesday.
                              // If Zeller is 5, day is thursday. // If Zeller is 6, day is friday. // If Zeller is 0, day is saturday.

                    if (Zeller1 == 1 || Zeller1 == -6)              //Thus, I defined "day_of_the_week" as 7 because
                    {                                             //sunday is seventh day of the week. And then I left some space for print day under
                        day_of_the_week = 7;                     //sunday.
                        Console.Write("                  ");        
                        for (int i = day1; i <= day2; i++)      //loop starting first day that entered by user and continues second day that entered by user
                        {
                            if (i > 0 && i < 10)   //----------------> This is for single digits number
                                Console.Write(" " + i);
                            if (i >= 10)                     // I used "for" to print days from day1 up to day2. And every turn I increased "day_of_the_week"
                                Console.Write(i);           //Because I printed sunday first turn but I have to print monday second turn.

                            if (((day_of_the_week) % 7) > 0) // if "day_of_the_week"'s mod7 > 0 , I understand that I print a day under the its day, and then I increase
                            {                               //"day_of_the_week" and it is still greater than zero, so I must left a space and the print another day under
                                Console.Write(" ");        //the its day. If "day_of_the_week"'s mod7 !> 0, I understand that I printed sunday lastly because there are 7
                            }                             //days in a week. So if this statement is true, I printed sunday. So, I have to go down a row.

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    // If Zeller is 0, day is saturday.
                    else if (Zeller1 == 0 || Zeller1 == -7)
                    {
                        day_of_the_week = 6;
                        Console.Write("               ");
                        for (int i = day1; i <= day2; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    // If Zeller is 0, day is saturday.

                    // If Zeller is 6, day is friday.
                    else if (Zeller1 == 6 || Zeller1 == -1)
                    {
                        day_of_the_week = 5;
                        Console.Write("            ");
                        for (int i = day1; i <= day2; i++)
                        {

                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    // If Zeller is 6, day is friday.

                    // If Zeller is 5, day is thursday.
                    else if (Zeller1 == 5 || Zeller1 == -2)
                    {
                        day_of_the_week = 4;
                        Console.Write("         ");
                        for (int i = day1; i <= day2; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    // If Zeller is 5, day is thursday.

                    // If Zeller is 4, day is wednesday.
                    else if (Zeller1 == 4 || Zeller1 == -3)
                    {
                        day_of_the_week = 3;
                        Console.Write("      ");
                        for (int i = day1; i <= day2; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    // If Zeller is 4, day is wednesday.

                    // If Zeller is 3, day is tuesday.
                    else if (Zeller1 == 3 || Zeller1 == -4)
                    {
                        day_of_the_week = 2;
                        Console.Write("   ");
                        for (int i = day1; i <= day2; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;


                        }
                    }
                    // If Zeller is 3, day is tuesday.

                    // If Zeller is 2, day is monday.
                    else if (Zeller1 == 2 || Zeller1 == -5)
                    {
                        day_of_the_week = 1;
                        for (int i = day1; i <= day2; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;


                        }
                    }
                    // If Zeller is 2, day is monday.
                }
                //This method is for print schedule from the same year and month

                //This method is for print the first month of the user's date
                void schedule2_first_month()
                {
                    // If Zeller is 1, day is sunday. // If Zeller is 2, day is monday. // If Zeller is 3, day is tuesday. // If Zeller is 4, day is wednesday.
                                        // If Zeller is 5, day is thursday. // If Zeller is 6, day is friday. // If Zeller is 0, day is saturday.

                    if (Zeller1 == 1 || Zeller1 == -6)
                    {
                        day_of_the_week = 7;
                        Console.Write("                  ");        //There is same Zeller's algorithm that used at "schedule_between_days()"
                        for (int i = day1; i <= ayy1; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);            //loop starting first day that entered by user and continues month's last day that entered by user
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    else if (Zeller1 == 0 || Zeller1 == -7)
                    {
                        day_of_the_week = 6;
                        Console.Write("               ");
                        for (int i = day1; i <= ayy1; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    else if (Zeller1 == 6 || Zeller1 == -1)
                    {
                        day_of_the_week = 5;
                        Console.Write("            ");
                        for (int i = day1; i <= ayy1; i++)
                        {

                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    else if (Zeller1 == 5 || Zeller1 == -2)
                    {
                        day_of_the_week = 4;
                        Console.Write("         ");
                        for (int i = day1; i <= ayy1; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }

                    else if (Zeller1 == 4 || Zeller1 == -3)
                    {
                        day_of_the_week = 3;
                        Console.Write("      ");
                        for (int i = day1; i <= ayy1; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }

                    else if (Zeller1 == 3 || Zeller1 == -4)
                    {
                        day_of_the_week = 2;
                        Console.Write("   ");
                        for (int i = day1; i <= ayy1; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;


                        }
                    }


                    else if (Zeller1 == 2 || Zeller1 == -5)
                    {
                        day_of_the_week = 1;
                        for (int i = day1; i <= ayy1; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;


                        }
                    }
                }
                //This method is for print the first month of the user's date

                //This method is for print the every day in every months that entered by user by one by in a year 
                void schedule3_j()
                {
                    // If Zeller is 1, day is sunday. // If Zeller is 2, day is monday. // If Zeller is 3, day is tuesday. // If Zeller is 4, day is wednesday.
                            // If Zeller is 5, day is thursday. // If Zeller is 6, day is friday. // If Zeller is 0, day is saturday.

                    if (Zeller2 == 1 || Zeller2 == -6)
                    {
                        day_of_the_week = 7;
                        Console.Write("                  ");        //There is same Zeller's algorithm that used at "schedule_between_days()"
                        for (int j = 1; j <= ayy3; j++)
                        {
                            if (j > 0 && j < 10)
                                Console.Write(" " + j);           //loop starting 1 that first day any month  and continues up to that month's last day.
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    else if (Zeller2 == 0 || Zeller2 == -7)
                    {
                        day_of_the_week = 6;                                           
                        Console.Write("               ");
                        for (int j = 1; j <= ayy3; j++)
                        {
                            if (j > 0 && j < 10)
                                Console.Write(" " + j);
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    else if (Zeller2 == 6 || Zeller2 == -1)
                    {
                        day_of_the_week = 5;
                        Console.Write("            ");
                        for (int j = 1; j <= ayy3; j++)
                        {

                            if (j > 0 && j < 10)
                                Console.Write(" " + j);
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    else if (Zeller2 == 5 || Zeller2 == -2)
                    {
                        day_of_the_week = 4;
                        Console.Write("         ");
                        for (int j = 1; j <= ayy3; j++)
                        {
                            if (j > 0 && j < 10)
                                Console.Write(" " + j);
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }

                    else if (Zeller2 == 4 || Zeller2 == -3)
                    {
                        day_of_the_week = 3;
                        Console.Write("      ");
                        for (int j = 1; j <= ayy3; j++)
                        {
                            if (j > 0 && j < 10)
                                Console.Write(" " + j);
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }

                    else if (Zeller2 == 3 || Zeller2 == -4)
                    {
                        day_of_the_week = 2;
                        Console.Write("   ");
                        for (int j = 1; j <= ayy3; j++)
                        {
                            if (j > 0 && j < 10)
                                Console.Write(" " + j);
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;


                        }
                    }


                    else if (Zeller2 == 2 || Zeller2 == -5)
                    {
                        day_of_the_week = 1;
                        for (int j = 1; j <= ayy3; j++)
                        {
                            if (j > 0 && j < 10)
                                Console.Write(" " + j);
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;


                        }
                    }
                }
                //This method is for print the every day in every months that entered by user by one by in a year 

                //This method is for print the first month any year
                void schedule4_january()
                {
                    // If Zeller is 1, day is sunday. // If Zeller is 2, day is monday. // If Zeller is 3, day is tuesday. // If Zeller is 4, day is wednesday.
                             // If Zeller is 5, day is thursday. // If Zeller is 6, day is friday. // If Zeller is 0, day is saturday.

                    if (Zeller2 == 1 || Zeller2 == -6)
                    {
                        day_of_the_week = 7;
                        Console.Write("                  ");               //There is same Zeller's algorithm that used at "schedule_between_days()"
                        for (int i = 1; i <= ayy1; i++)
                        {
                            if (i > 0 && i < 10)                    //loop starting 1 that first day any month  and continues up to entered first month's last day.
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    else if (Zeller2 == 0 || Zeller2 == -7)
                    {
                        day_of_the_week = 6;
                        Console.Write("               ");
                        for (int i = 1; i <= ayy1; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    else if (Zeller2 == 6 || Zeller2 == -1)
                    {
                        day_of_the_week = 5;
                        Console.Write("            ");
                        for (int i = 1; i <= ayy1; i++)
                        {

                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    else if (Zeller2 == 5 || Zeller2 == -2)
                    {
                        day_of_the_week = 4;
                        Console.Write("         ");
                        for (int i = 1; i <= ayy1; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }

                    else if (Zeller2 == 4 || Zeller2 == -3)
                    {
                        day_of_the_week = 3;
                        Console.Write("      ");
                        for (int i = 1; i <= ayy1; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }

                    else if (Zeller2 == 3 || Zeller2 == -4)
                    {
                        day_of_the_week = 2;
                        Console.Write("   ");
                        for (int i = 1; i <= ayy1; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;


                        }
                    }


                    else if (Zeller2 == 2 || Zeller2 == -5)
                    {
                        day_of_the_week = 1;
                        for (int i = 1; i <= ayy1; i++)
                        {
                            if (i > 0 && i < 10)
                                Console.Write(" " + i);
                            if (i >= 10)
                                Console.Write(i);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;


                        }
                    }
                }
                //This method is for print the first month any year

                //This method is for print the last month that entered by user
                void schedule5_j_day2()
                {
                    // If Zeller is 1, day is sunday. // If Zeller is 2, day is monday. // If Zeller is 3, day is tuesday. // If Zeller is 4, day is wednesday.
                                // If Zeller is 5, day is thursday. // If Zeller is 6, day is friday. // If Zeller is 0, day is saturday.

                    if (Zeller2 == 1 || Zeller2 == -6)
                    {
                        day_of_the_week = 7;
                        Console.Write("                  ");            //There is same Zeller's algorithm that used at "schedule_between_days()"
                        for (int j = 1; j <= day2; j++)
                        {
                            if (j > 0 && j < 10)
                                Console.Write(" " + j);                //loop starting 1 that first day last month  and continues up to entered second day.  
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    else if (Zeller2 == 0 || Zeller2 == -7)
                    {
                        day_of_the_week = 6;
                        Console.Write("               ");
                        for (int j = 1; j <= day2; j++)
                        {
                            if (j > 0 && j < 10)
                                Console.Write(" " + j);
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    else if (Zeller2 == 6 || Zeller2 == -1)
                    {
                        day_of_the_week = 5;
                        Console.Write("            ");
                        for (int j = 1; j <= day2; j++)
                        {

                            if (j > 0 && j < 10)
                                Console.Write(" " + j);
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }
                    else if (Zeller2 == 5 || Zeller2 == -2)
                    {
                        day_of_the_week = 4;
                        Console.Write("         ");
                        for (int j = 1; j <= day2; j++)
                        {
                            if (j > 0 && j < 10)
                                Console.Write(" " + j);
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }

                    else if (Zeller2 == 4 || Zeller2 == -3)
                    {
                        day_of_the_week = 3;
                        Console.Write("      ");
                        for (int j = 1; j <= day2; j++)
                        {
                            if (j > 0 && j < 10)
                                Console.Write(" " + j);
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;

                        }
                    }

                    else if (Zeller2 == 3 || Zeller2 == -4)
                    {
                        day_of_the_week = 2;
                        Console.Write("   ");
                        for (int j = 1; j <= day2; j++)
                        {
                            if (j > 0 && j < 10)
                                Console.Write(" " + j);
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;


                        }
                    }


                    else if (Zeller2 == 2 || Zeller2 == -5)
                    {
                        day_of_the_week = 1;
                        for (int j = 1; j <= day2; j++)
                        {
                            if (j > 0 && j < 10)
                                Console.Write(" " + j);
                            if (j >= 10)
                                Console.Write(j);

                            if (((day_of_the_week) % 7) > 0)
                            {
                                Console.Write(" ");
                            }

                            else
                            {
                                Console.Write("\n");
                            }
                            day_of_the_week = day_of_the_week + 1;


                        }
                    }
                   }
                //This method is for print the last month that entered by user

            } while (year1 != year2 && m1 != m2);
            //I used do-while loops to print schedule that between two different dates consecutively
            //Schedule algorithm
        }

    }
}


