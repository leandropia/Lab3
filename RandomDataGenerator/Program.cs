///-----------------------------------------------------------------
///   Namespace:      RandomDataGenerator
///   Class:          Program
///   Description:    CSCI-2910-201 - LAB 3
///   Author:         NASCIMENTO, LEO              Date:  09.11.2022
///   Notes:          <Notes>
///-----------------------------------------------------------------
///   Revision History: N/A
///   Name:N/A           Date: N/A        Description: N/A
///-----------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class Program
    {
        public static ArrayList people = new ArrayList(); // 
        static void Main(string[] args)
      

        {
            bool displayMenu = true; //
            while (displayMenu)
            {
                displayMenu = Menu();
            }

        }

        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("   SELECT AN OPTION FROM THE MENU BELOW:");
            Console.WriteLine("1) Create a Person");
            Console.WriteLine("2) Display Person");
            Console.WriteLine("3) Delete Person");
            Console.WriteLine("4) Display a Random Last Name List");
            Console.WriteLine("5) Display a Random SSN");
            Console.WriteLine("6) Display a Random Phone number");
            Console.WriteLine("9) EXIT");
            string result = Console.ReadLine();

            if (result == "1")
            {
                CreatePerson();
                return true;
            }
            else if (result == "2")
            {
                DisplayPerson();
                return true;
            }
            else if (result == "3")
            {
                DeletePerson();
                return true;
            }
            else if (result == "4")
            {


                foreach (string lastname in Enum.GetNames(typeof(LastName)))
                {
                    Console.WriteLine(lastname);
                }
                Console.WriteLine();
                Console.WriteLine("Press ENTER to return to the Menu.");
                Console.ReadLine();
                return true;
            }
            else if (result == "5")
            {



                Person randomSSN = new Person();


             
                     Console.WriteLine("Here is a random invalid SSN: " + randomSSN.SSN);

                     Console.WriteLine("Press ENTER to return to the Menu.");
                     Console.ReadLine();


               
                Console.ReadLine();
                return true;
            }
            else if (result == "6")
            {
                Person randomPhone = new Person();

                Console.WriteLine("Here is a random Phone No.: " + randomPhone.Phone.Number);

                Console.WriteLine();
                Console.WriteLine("Press ENTER to return to the Menu.");
                Console.ReadLine();

                return true;
            }
            else if (result == "9")
            {
                return false;
            }

            else

            {
                return true;
            }

        }

        // some comment

        public static void CreatePerson()
        {
            Console.Clear();
            Console.WriteLine("How many Person(s) would you like to create? ");
            Console.Write("Type a Number: ");
            int result = int.Parse(Console.ReadLine());

            for (int i = 0; i < result; i++)
            {
                people.Add(new Person());
            }

            Console.WriteLine();
            Console.WriteLine($"Created {result} Person(s). Press ENTER to return to the Menu.");
            Console.ReadLine();

        }


        public static void DisplayPerson()
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i]);
                
            }

            Console.WriteLine();
            Console.WriteLine($"Displayed {people.Count} Person(s). Press ENTER to return to the Menu.");
            Console.ReadLine();
        }


        public static void DeletePerson()
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine("ID #" + i + " - " + people[i]);
            }
            Console.WriteLine("Type the ID # of the record that you want to delete: ");
            int result = int.Parse(Console.ReadLine());

            if (people[result] == null)
            {
                Console.WriteLine("Invalid!");
            }
            else if (people[result] != null)
            {
                people.Remove(people[result]);
                Console.WriteLine();
                Console.WriteLine($"The person at index ID # {result} was deleted. Press ENTER to return to the Menu.");
                Console.ReadLine();
            }
        }
    }
}

