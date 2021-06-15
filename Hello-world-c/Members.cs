using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world_c
{
    class Members
    {
        // Private member fields
        private string memberName;
        private string jobTitle;

        // public member fields
        public int age;

        // properties are members as well
        //public string jobTitle {
        //    get
        //    {
        //        return jobTitle;
        //    }
        //    set
        //    {
        //        jobTitle = value;
        //    }
        //}

        // methods are members
        public void SayHi()
        {
            Console.WriteLine("Hi There");
        }

        private void SharingSomethingPrivateInformation()
        {
            Console.WriteLine("this is private info");
        }

        // constructor member
        public Members()
        {
            Console.WriteLine("Object Created");
        }

        // member - finalizer-deconstructor
        ~Members()
        {
            // this is here for clean up statements
            Console.WriteLine("for deconstruction of object");
        }
    }
}
