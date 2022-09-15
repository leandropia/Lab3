///-----------------------------------------------------------------
///   Namespace:      RandomDataGenerator
///   Class:          Dependent
///   Description:    CSCI-2910-201 - LAB 3
///   Author:         NASCIMENTO, LEO              Date:  09.13.2022
///   Notes:          <Notes>
///-----------------------------------------------------------------
///   Revision History: N/A
///   Name:N/A           Date: N/A        Description: N/A
///-----------------------------------------------------------------
///
using System;
namespace RandomDataGenerator
{
    public class Dependent : Person
    {
        public Dependent() : base()
        {
            Random rand = new Random();
            BirthDate = DateTime.Now.AddYears(rand.Next(11));
        }
    }
}

