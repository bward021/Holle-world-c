using System;

namespace Hello_world_c
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = { "Nate", "Madi", "Savanah", "Jessica", "Caitlin" };

            foreach (string friend in friends)
            {
                Console.WriteLine("Hey there {0}", friend);
            }


        }
    }
}

// ********* For each loops *******

//int[] nums = new int[10];

//for (int i = 0; i < 10; i++)
//{
//    nums[i] = i + 10;
//}

//for (int j = 0; j < 10; j++)
//{
//    Console.WriteLine("element at {0} = {1}", j, nums[j]);
//}

//foreach (int k in nums)
//{
//    Console.WriteLine(k);
//}


//static void Main(string[] args)
//{

//    Members member1 = new Members();
//    member1.SayHi();

//}


// properties practice ***************
//Human denis = new Human("Brandon", "Ward", "Brown", 26);
//denis.introduceMyself();

//Box box = new Box();
//box.Height = -4;
//box.Width = 3;
//box.displayInfo();
//box.SetLength(4);
//Console.WriteLine("Box volume is " + box.GetVolume());


// **** Terinary statement ****
//int temperature = -5;
//string stateOfMatter;

//stateOfMatter = temperature < 0 ? "Solid" : "Liquid";

//Console.WriteLine("State of the matter is " + stateOfMatter);



// switch statements
//int age = 26;

//switch (age)
//{
//    case 15:
//        Console.WriteLine("To young to party in the club");
//        break;
//    case 26:
//        Console.WriteLine("Good to go");
//        break;
//    default:
//        Console.WriteLine("How old are you then?");
//        break;

//}

// review of switch statements
//int age = 26;

//switch (age)
//{
//    case 15:
//        Console.WriteLine("To young to party in the club");
//        break;
//    case 26:
//        Console.WriteLine("Good to go");
//        break;
//    default:
//        Console.WriteLine("How old are you then?");
//        break;

//}

// ***** registering Challenge *****
//Console.Write("Username: ");
//string userName = Console.ReadLine();
//Console.Write("Password: ");
//string password = Console.ReadLine();

//if (userName != "" && password != "")
//{
//    Console.WriteLine("Thank you for registering with us today!");
//}


// Nested if statements
//bool isAdmin = false;
//bool isRegistered = true;
//string userName = "";

//if (isRegistered)
//{
//    Console.WriteLine("Hi there, Registered User");
//    if (userName != "")
//    {
//        Console.WriteLine("Hi there, " + userName);
//        if (isAdmin == true)
//        {
//            Console.WriteLine("Admin");
//        }
//    }
//}

// ***** Try Parse *****

//Console.Write("What is the temperature like? : ");
//string temperature = Console.ReadLine();
//int numTemp;
//int number;

//if (int.TryParse(temperature, out number))
//{
//    numTemp = number;
//}
//else
//{
//    numTemp = 0;
//    Console.WriteLine("Value entered was of a incorrect type, temp set to 0");
//}

//if (numTemp < 20)
//{
//    Console.WriteLine("take a coat");
//}
//else if (numTemp == 20)
//{
//    Console.WriteLine("Pants should be fine");
//}
//else if (numTemp > 30)
//{
//    Console.WriteLine("It is super hot!!");
//}
//else
//{
//    Console.WriteLine("Shorts are good for today!");
//}


// *** introduction to unary operators. previous knowledge skipped video***
//int num = 5;
//int num2 = 3;
//int num3;

////Unary Operator
//num3 = -num;
//Console.WriteLine("num3 is {0}", num3);

//bool isSunny = true;
//Console.WriteLine("Is it sunny? {0}", !isSunny);

// ***** Try/Catch/Finally Practice
//Console.Write("Please enter a numer: ");
//string userInput = Console.ReadLine();

//try
//{
//    int userInputasInt = int.Parse(userInput);
//}
//catch (FormatException)
//{
//    Console.WriteLine("That is not a number");
//}
//catch (Exception)
//{
//    Console.WriteLine("General Exception");
//}
//// this will run everytime after the try and catch are run
//finally
//{
//    Console.WriteLine("This is called anyways");
//}

// *** Calculator challenge ***
// ****************************
//static void Main(string[] args)
//{
//    Console.Write("Enter two numbers to add: ");
//    string inputOne = CalculatorInput();
//    string inputTwo = CalculatorInput();

//    Console.WriteLine(Calculator(Convert.ToDouble(inputOne), Convert.ToDouble(inputTwo)));
//}

//public static string CalculatorInput()
//{
//    string input = Console.ReadLine();
//    return input;
//}

//public static double Calculator(double one, double two)
//{
//    return one + two;
//}

// ******* Methods *******
//static void Main(string[] args)
//{

//    // getting input
//    string input = Console.ReadLine();
//    Console.WriteLine(input);


//    WriteSomething();
//    WriteSomethingSpecific("This is something specific to pass into the method");
//    Console.WriteLine(Add(4, 6));
//    Console.WriteLine(Multiplication(2, 6));
//    Console.WriteLine(Division(6, 2));
//}
//public static int Add(int one, int two)
//{
//    return one + two;
//}

//public static double Division(double one, double two)
//{
//    return one / two;
//}
//public static int Multiplication(int one, int two)
//{
//    return one * two;
//}
//// <access modifier> <static> <return type> <method name> <parameters>
//public static void WriteSomething()
//{
//    Console.WriteLine("I am Called from a method");
//}

//public static void WriteSomethingSpecific(string myText)
//{
//    Console.WriteLine(myText);
//}



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
