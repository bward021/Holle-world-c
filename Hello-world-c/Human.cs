using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world_c
{
    class Human
    {
        //  Member variable
        public string firstName;
        public string lastName;

        public Human(string myFirstName, string lastName)
        {
            firstName = myFirstName;
            this.lastName = lastName;
        }


        public void introduceMyself()
        {
            Console.WriteLine("Hi I am {0}", firstName);
        }

    }
}
