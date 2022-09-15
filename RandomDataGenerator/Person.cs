///-----------------------------------------------------------------
///   Namespace:      RandomDataGenerator
///   Class:          Person
///   Description:    CSCI-2910-201 - LAB 3
///   Author:         NASCIMENTO, LEO              Date:  09.11.2022
///   Notes:          <Notes>
///-----------------------------------------------------------------
///   Revision History: N/A
///   Name:N/A           Date: N/A        Description: N/A
///-----------------------------------------------------------------

using System;
using System.Text;
using System.Transactions;

namespace RandomDataGenerator
{
    public class Person
    {
        private string[] _arrayOfFirstNames = { "Bob", "Jack", "Tom", "Tim", "Frank", "Jerry", "Wayne", "Christine", "Samantha" }; 
        private Dependent[] _dependents;                


        public string FirstName     { get; init; }
        public string LastName      { get; init; }
        public DateTime BirthDate   { get; init; }
        public SSN SSN              { get; init; }
        public Phone Phone          { get; init; }

        public Person()
        {

            Random rand = new Random();
            int identifier = rand.Next(_arrayOfFirstNames.Length); 
            FirstName = _arrayOfFirstNames[identifier];

            Array ofLastNames = Enum.GetValues(typeof(LastName));
            var last = (LastName?)ofLastNames.GetValue(rand.Next(ofLastNames.Length));
            LastName = "" + last.ToString();

            DateTime start = new DateTime(1904, 1, 1);
            DateTime end = new DateTime(2022, 1, 1);
            int range = (end - start).Days;
            BirthDate = start.AddDays(rand.Next(range));


            this.SSN = new SSN();
            this.Phone = new Phone();
            _dependents = new Dependent[10];
        }

        public int Age()
        {
            int currentDate = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(BirthDate.ToString("yyyyMMdd"));
            int age = (currentDate - dob); // /1000
            return age;
        }


        public override string ToString()
        {
            return $"{FirstName} {LastName} {BirthDate} {Age}";
        }

    }


}

