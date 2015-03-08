using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tutorial Session 1:
            //HelloWorldTest();
            //UserInputTest();
            //ClassesTest();
            //CalculatorTest();
            //AnagramTest();


            //Tutorial Session 2:   .NET Containers
            //ArrayTest();
            //ListTest();
            //StackTest();
            DictionaryTest();


            Console.WriteLine("\nPlease press any key to exit...");
            Console.ReadKey();
        }

        //Tutorial Session 1 Test Functions
        static void HelloWorldTest()
        {
            //Exercise - Hello World
            Console.Write("Hello World");
            while (true) ; //This just keeps our console window open
        }
        static void UserInputTest()
        {
            //Exercise - User Input
            Console.Write("Please enter your first name: ");
            string name = Console.ReadLine();

            Console.Clear();

            Console.Write("Hello " + name);
            while (true) ;
        }
        static void ClassesTest()
        {
            //Exercise - Classes
            MyClass myClass = new MyClass();

            int answer = myClass.SimpleAdditionFunction(3, 4);

            Console.Write("3 + 4 = " + answer);
            Console.ReadKey();
        }
        static void CalculatorTest()
        {
            //Exercise - Simple Calculator
            string number1, number2;
            double num1, num2;
            MyClass myClass = new MyClass();

            do
            {
                Console.Write("Please enter first number: ");
                number1 = Console.ReadLine();

            } while (!double.TryParse(number1, out num1));

            do
            {
                Console.Write("Please enter second number: ");
                number2 = Console.ReadLine();

            } while (!double.TryParse(number2, out num2));

            Console.WriteLine(num1 + " + " + num2 + " = " + myClass.Add(num1, num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + myClass.Subtract(num1, num2));
            Console.WriteLine(num1 + " * " + num2 + " = " + myClass.Multiply(num1, num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + myClass.Divide(num1, num2));
            Console.WriteLine("Please press any key to exit...");
            Console.ReadKey();
        }
        static void AnagramTest()
        {
            //Exercise - Testing Anagrams
            TestAnagrams test = new TestAnagrams();

            string phraseOne, phraseTwo;

            Console.Write("Please enter first phrase: ");
            phraseOne = Console.ReadLine();

            Console.Write("\nPlease enter second phrase: ");
            phraseTwo = Console.ReadLine();

            if (test.testPhrases(phraseOne, phraseTwo))
            {
                Console.WriteLine("\n\"" + phraseOne + "\" and \"" + phraseTwo + "\" are anagrams of each other. Congratulations!!\n\n");
            }
            else
            {
                Console.WriteLine("\n\"" + phraseOne + "\" and \"" + phraseTwo + "\" are not anagrams of each other. Commiserations.\n\n");
            }
        }

        //Tutorial Session 2 Test Functions
        static void ArrayTest()
        {
            ContainersTutorial containers = new ContainersTutorial();

            containers.ArrayExample(10);
        }
        static void ListTest()
        {
            ContainersTutorial containers = new ContainersTutorial();

            containers.ListExample();
        }
        static void StackTest()
        {
            ContainersTutorial containers = new ContainersTutorial();

            containers.StackExample();
        }
        static void DictionaryTest()
        {
            ContainersTutorial containers = new ContainersTutorial();

            containers.DictionaryExample();
        }
    }
}
