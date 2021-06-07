using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world_c
{
    class Human
    {
        //  Member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //default Constructor
        public Human()
        {
            Console.WriteLine("This is a second Constructor");
        }

        // constructor when parameters are passed
        public Human(string myFirstName, string lastName, string eyeColor, int age)
        {
            firstName = myFirstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }


        public void introduceMyself()
        {
            if(age != 0)
            {
                Console.WriteLine("Hi I am {0} {1}, my eyes are {2}, and I am {3} years old.", firstName, lastName, eyeColor, age);
            }
            else
            {
                Console.WriteLine("Hi I am {0} {1} and my eyes are {2}.", firstName, lastName, eyeColor, age);

            }
        }

    }
}
