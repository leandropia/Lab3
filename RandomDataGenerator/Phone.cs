///-----------------------------------------------------------------
///   Namespace:      RandomDataGenerator
///   Class:          Phone
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
    

public class Phone
    {
        public string Number { get; init; }

        public Phone()
        {
            Number = Format();
        }

       

        public string Format(char separator = '-')
        {
            Random random = new Random();
            var phoneFormat = new StringBuilder();

            phoneFormat.Append(random.Next(2, 10));

            for (int i = 0; i < 9; i++)
            {
                phoneFormat.Append(random.Next(0, 10));
            }

            string formattedPhoneNumber = phoneFormat.ToString();
            formattedPhoneNumber = formattedPhoneNumber.Insert(3, separator.ToString());
            formattedPhoneNumber = formattedPhoneNumber.Insert(7, separator.ToString());

            return formattedPhoneNumber;

            // phonenumber = phonenumber.Insert(3, separator.ToString()).Insert(7, separator.ToString());
            //  phonenumber = phonenumber.Insert(3 & 7, separator.ToString());         





        }



    }

}

