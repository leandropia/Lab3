///-----------------------------------------------------------------
///   Namespace:      RandomDataGenerator
///   Class:          SSN
///   Description:    CSCI-2910-201 - LAB 3
///   Author:         NASCIMENTO, LEO              Date:  09.13.2022
///   Notes:          <Notes>
///-----------------------------------------------------------------
///   Revision History: N/A
///   Name:N/A           Date: N/A        Description: N/A
///-----------------------------------------------------------------
///
using System;
using System.Text;
namespace RandomDataGenerator
{

    public class SSN
    {
        public string GenerateInvalidSSN { get; init; }

        public SSN()
        {
            //keep track of first 3 numbers (must be 000, 666 or 900
            //Generate Random from 900 to 999 and convert to String

            Random rand = new Random();
            int randomSSN = rand.Next(900, 1000);
            string nineHundredSeries = Convert.ToString(randomSSN);

            string[] firstThree = { "000", "666", nineHundredSeries }; //Declaring a new array of strings and populating at same time
            string secondTwo = "00";
            string lastFour = "0000";



                int index = rand.Next(0, firstThree.Length);
                string invalidFirstSet = firstThree[index];

             string[] invalidOptionsArray = { invalidFirstSet, secondTwo, lastFour };
             int invalidIndex = rand.Next(0, invalidOptionsArray.Length);


           // GenerateInvalidSSN = firstThree.ToString() + secondTwo.ToString() + lastFour.ToString();


            
             var ssnBuilder = new StringBuilder();

             switch (invalidIndex)
             {
                 case 0:
                     ssnBuilder.Append(invalidFirstSet);
                     for (int i = 0; i < 6; i++)
                     {
                         ssnBuilder.Append(rand.Next(0, 10));
                     }
                     break;
                 case 1:
                     for (int i = 0; i < 3; i++)
                     {
                         ssnBuilder.Append(rand.Next(0, 10));
                     }
                     ssnBuilder.Append(secondTwo);
                     for (int i = 0; i < 4; i++)
                     {
                         ssnBuilder.Append(rand.Next(0, 10));
                     }
                     break;
                 case 2:
                     for (int i = 0; i < 5; i++)
                     {
                         ssnBuilder.Append(rand.Next(0, 10));
                     }
                     ssnBuilder.Append(lastFour);
                     break;
                 default:
                     Console.WriteLine("Invalid index in array selected.");
                     break;
             }

             GenerateInvalidSSN = ssnBuilder.ToString();
         }

         public override string ToString()
         {
             string formattedSSN = GenerateInvalidSSN;
             formattedSSN = formattedSSN.Insert(3, "-");
             formattedSSN = formattedSSN.Insert(6, "-");
             return formattedSSN.ToString();
         } 
        }



}