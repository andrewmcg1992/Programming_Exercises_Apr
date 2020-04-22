using System;

namespace Programming_Exercises_Apr
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                DisplayMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            palindrome();
                            break;
                        }
                    case 2:
                        {
                            smallTown();
                            break;
                        }
                    case 3:
                        {
                            averageCounter();
                            break;
                        }
                    case 4:
                        {
                            stars();
                            break;
                        }
                    case 5:
                        {
                            BloodSugarLevel();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Hit enter to quit");
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please select an option again");
                            Console.ReadLine();
                            break;
                        }
                }
            } while (choice != 6);

            //Shows a menu that lets user select their program and enter a command via digit 1-6
            static void DisplayMenu()
            {
                Console.WriteLine();
                Console.WriteLine("Please select a program below:");
                Console.WriteLine();
                Console.WriteLine("1: Palindrome Tester");
                Console.WriteLine("2: SmallTown vs BigTown");
                Console.WriteLine("3: Average of multiple numbers");
                Console.WriteLine("4: Star triangle");
                Console.WriteLine("5: Blood sugar level table.");
                Console.WriteLine("6: Exit Program");
                Console.WriteLine();
                Console.Write("Please choose the corresponding program (1 - 6) : ");
            }




            //Question 1 - Palindrome checker
            static void palindrome()
            {
                Console.WriteLine("Please enter a number below to check if it is a panlindrome");
                string number = Console.ReadLine();
                string reverse = "";


                Console.WriteLine("Your number is: " + number);
                int length;
                length = number.Length - 1;
                while (length >= 0)
                {
                    reverse = (reverse + number[length]);
                    length--;
                }

                Console.WriteLine("Reversed number is: " + reverse);

                if (number == reverse)
                {
                    Console.WriteLine("Your number is a palindrome.");
                }
                else
                {
                    Console.WriteLine("Your number is NOT palindrome.");

                }
                Console.WriteLine("Please press enter to return to menu.");

                Console.ReadLine();
            }






            //Questiom 2 - Small Town vs Big Town
            static void smallTown()
            {
                double smallTownPop = 30435;
                double bigTownPop = 37816;
                int year = 1;
                int test = 1;
                int yearExceed = 0;
                double smallChangeRate = 0.0225;
                double bigChangeRate = 0.015;

                for (int x = 0; x < 10; x++)
                {
                    smallTownPop = (smallTownPop + (smallTownPop * smallChangeRate));
                    smallTownPop = Math.Round(smallTownPop, 0);

                    bigTownPop = (bigTownPop - (bigTownPop * bigChangeRate));
                    bigTownPop = Math.Round(bigTownPop, 0);

                    Console.Write("Population of Small Town Year " + year + "= ");
                    Console.WriteLine(smallTownPop);
                    Console.Write("Population of Big Town Year " + year + "= ");
                    Console.WriteLine(bigTownPop);
                    Console.WriteLine();

                    //this loop executes once small town population exceeds big town. integer test is already set at 1. Once it executes, test is increased by 1, this loop won't run again.
                    if (smallTownPop > bigTownPop && test == 1)
                    {
                        yearExceed = year;
                        test++;
                    }

                    year++;
                }
                //prints the year that smalltown exceeded bigtown. 
                Console.WriteLine("Small town will exceed big town in year " + yearExceed);
                Console.WriteLine("Please press enter to return to menu.");

                Console.ReadLine();

            }





            //Question 3 - Average calculation
            static void averageCounter()
            {
                int counter = 0;
                int total = 0;

                Console.WriteLine("Enter a number, input 9999 to end: ");
                int number = int.Parse(Console.ReadLine());

                //this loop runs once the user does not type 9999 (sentinel). The total keeps adding the newest input (number). The counter int is used to keep record of how many numbers were entered.
                while (number != 9999)
                {

                    total = (total + number);
                    counter++;

                    Console.WriteLine("Enter a number, input 9999 to end: ");
                    number = int.Parse(Console.ReadLine());
                }

                double average = total / counter;
                Console.WriteLine("The total is: " + total);
                Console.WriteLine("The Average is: " + average);
                Console.WriteLine("Please press enter to return to menu.");

            }




            //Question 4 - Triangle of stars
            static void stars()
            {
                int stars = 10;
                int count1, count2, count3;
                for (count1 = 1; count1 <= stars; count1++)
                {
                    for (count2 = 1; count2 <= stars - count1; count2++)
                    {
                        Console.Write(" ");
                    }
                    for (count3 = 1; count3 <= count1; count3++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("Please press enter to return to menu.");

            }




            //Question 5 - Blood sugar levels
            static void BloodSugarLevel()
            {
                Console.WriteLine("Please enter the requested data");

                //calls and assigns the value of the returnd string from the bloodLevelInput method 
                string patientOne = BloodLevelInput();
                string patientTwo = BloodLevelInput();
                string patientThree = BloodLevelInput();

                Console.WriteLine();
                //writes out the table heading and then prints each patient string in the console
                Console.WriteLine("Name" + "\t" + "Mon" + "\t" + "Tue" + "\t" + "Wed" + "\t" + "Thu" + "\t" + "Fri" + "\t" + "Avg" + "\t" + "Comment");
                Console.WriteLine(patientOne);
                Console.WriteLine(patientTwo);
                Console.WriteLine(patientThree);
                Console.WriteLine();
            }

            //this method is used to generate a string with all the required information to populate the table for question 5
            static string BloodLevelInput()
            {
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();

                //The console reads the user input and assigns the value to each variable
                Console.WriteLine("Enter your blood sugar levels for Monday - Friday respectively:");
                Console.Write("Monday: ");
                double mon = double.Parse(Console.ReadLine());
                Console.Write("Tuesday: ");
                double tue = double.Parse(Console.ReadLine());
                Console.Write("Wednesday: ");
                double wed = double.Parse(Console.ReadLine());
                Console.Write("Thursday: ");
                double thu = double.Parse(Console.ReadLine());
                Console.Write("Friday: ");
                double fri = double.Parse(Console.ReadLine());

                //works out average blood sugar level from the 5 inputted figures and then rounds it to 1 decimal point
                double averageBloodSugar = ((mon + tue + wed + thu + fri) / 5);
                averageBloodSugar = Math.Round(averageBloodSugar, 1);

                //if statement to assign the correct comment based on the average number
                string commentAvg = "test";
                if (averageBloodSugar < 4)
                {
                    commentAvg = "increase sugar";
                }
                else if (averageBloodSugar > 3.9 && averageBloodSugar < 6.1)
                {
                    commentAvg = "excellent";
                }
                else if (averageBloodSugar > 6)
                {
                    commentAvg = "Reduce sugar";
                }

                //concatenates all the variables and returns them as a single string
                string final = name + "\t" + mon + "\t" + tue + "\t" + wed + "\t" + thu + "\t" + fri + "\t" + averageBloodSugar + "\t" + commentAvg;
                return final;
            }
        }
    }
}
