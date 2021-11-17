/// Homework No. 11 Project No. 1
/// File Name : Program.cs
/// @author : Joshua Um
/// Date : November 17 2021
/// 
/// Problem Statement : Create a phone lookup program. It should have the ability to add, delete, and find phones number. 
/// 
/// Plan:
/// 1. Prompt user with menu interface to interact with program.
/// 2. Selecting option "1" will let the user to lookup a phonenumber using the first name as the key.
/// 3. Selecting option "2" will let the user to add numbers by entering a first name and phone number.
/// 4. Selecting option "3" will let the user to delete a number by entering the first name of the phone number entry.
/// 5. Selecting option "4" will exit the program.


using System;
using System.Collections.Generic;

namespace HW11Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<string, int> phoneDictionary = new Dictionary<string, int>();

            while (true)
            {
                Console.WriteLine("\n\tPhone Lookup Program\n1. Lookup phone number\n2. Add phone number\n3. Delete phone number\n4. Exit program\n");

                int choice = Int32.Parse(Console.ReadLine());

                if (choice == 4) break;

                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter First Name : ");
                            string name = Console.ReadLine();
                            int number;
                            try
                            {
                                number = phoneDictionary[name];
                            }
                            catch (KeyNotFoundException)
                            {
                                Console.WriteLine("Error: No entry found for name \"" + name + "\"");
                                continue;
                            }

                            Console.WriteLine("\nName : " + name + "\nPhone Number : " + number);
                        }
                        
                        break;
                    case 2:
                        {
                            Console.Write("Enter First Name : ");
                            string name = Console.ReadLine();
                            
                            int number;
                            try
                            {
                                number = phoneDictionary[name];
                            }
                            catch (KeyNotFoundException)
                            {
                               

                                bool isValid = false;
                                do
                                {   
                                    Console.Write("Enter Phone number: ");
                                    isValid = Int32.TryParse(Console.ReadLine(), out number);
                                    if (isValid)
                                    {
                                        phoneDictionary.Add(name, number);
                                        Console.WriteLine(" Entry successfully added");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid phone number, try again");
                                    }
                                } while (!isValid);
                               
                               
                                break;
                            }

                            Console.WriteLine("Name \"" + name +"\" already exists.");
                            break;
                        }

                        
                    case 3:
                        {
                             Console.Write("Enter First Name : ");
                             string name = Console.ReadLine();
                             
                             try
                             {
                                 phoneDictionary.Remove(name);
                             }
                             catch (KeyNotFoundException)
                             {
                                Console.WriteLine("Error: No entry found for name \"" + name + "\"");
                             }
                            
                             
                             
                             
                            
                             break;

                        }
                    default:
                        Console.WriteLine("Invalid input, try again.");
                        break;
                }
            }
        }

       


    }
}
