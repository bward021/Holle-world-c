using System;

namespace Hello_world_c
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
        }
        // <access modifier> <static> <return type> <method name> <parameters>
        public static void WriteSomething()
        {
            Console.WriteLine("I am Called from a method");
        }

    }
}


// *** Previous Practice from Main Method ***
//int num1 = 13;
//int num2 = 10;
//int sum = num1 + num2;

//double d1 = 3.5;
//double d2 = 1.537;
//double sumDouble = d1 + d2;

//float f1 = 3.5f;
//float f2 = 1.537f;

//string myName = "Brandon";

//string lowerCaseName = myName.ToUpper();

//string boom = "BOOOOOOOOM";

//string lower = boom.ToLower();


////Console.WriteLine("The sum of " + num1 + " and " + num2 + " is equal to " + sum);
////Console.WriteLine("The sum of " + d1 + " and " + d2 + " is equal to " + sumDouble);
////Console.WriteLine("My name is " + lowerCaseName);

//// ********* Casting ********** 

////Implicit Conversion

//int num = 123321123;

//long bigNum = num;

//double myDouble = 13.37;
//int myInt;

//// casting double into int
//// explicit conversion
//myInt = (int)myDouble;

//string myString = myDouble.ToString();

////Console.WriteLine(myInt);

//// ************* Parsing ***********

//string parsingstring1 = "15";
//string parsingString2 = "13";

//int parseSum = Int32.Parse(parsingstring1) + Int32.Parse(parsingString2);

////Console.WriteLine(parseSum);

//// ****** Code Challenge 1 *********

//string yourName;
//char letterIndex;

//Console.Write("Please Enter Your Name: ");
//yourName = Console.ReadLine();
//Console.Write("Pick a letter to find the index of: ");
//letterIndex = Console.ReadLine()[0];

//int index = yourName.IndexOf(letterIndex);

//Console.WriteLine(yourName + " is your name. The index of " + letterIndex + " is " + index);
