using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIdiomExample
{
    // norrisa
    // CSC 153
    // 3/7/17
    // 
    // Examples of several programming 'idioms', 
    // common constructions for how to do certain tasks in programming.

    class Program
    {

        /// <summary>
        // explanation of the Main() method:
        // 
        // public -> this method is called to start the program, so it must be accessible outside
        // of the current class
        // static -> addressed in detail in CSC253. 
        // short version: in a WinForms application, the Program class creates a Form, this form
        // is an individual case, or instance, of the form class you have written. 
        // In a console app, initialization is less complex. The runtime simply executes the 
        // methods listed in your Program. 'static' tells the compiler that this is allowed.
        // void -> no value is returned from Main()
        /// </summary>
        /// <param name="args">If you were to call this program from the command line
        /// with arguments, they would be passed here. 
        /// For example, 'dir c:/' passes 'c:/' as an argument.</param>
        /// 
        static void Main(string[] args)
        {
            // we'll write various idioms in here as methods, then call them individually.
            // this makes it easier to tell them apart.
            // MenuIdiom();

            // ForeverIdiom();
            RepeatUntilIdiom();

            // when done, wait for user input
            WaitIdiom();
        }

        private static void RepeatUntilIdiom()
        {
            // repeat until a condition is met
            // in this case, when the user enters a negative number
            print("Enter positive numbers forever, or");
            print("Enter a negative number to exit.");

            // flag
            bool repeat = true;
            int num = 0;
            int sum = 0;

            do
            {
                print("number?");
                num = inputInt();
                // print("You typed in " + num);

                if (num < 0)
                {
                    repeat = false;
                    print("Done.");
                }
                else
                {
                    sum += num;
                    print("New sum is " + sum);
                }

            } while (repeat);
        }




        private static void MenuIdiom()
        {
            print("This is a menu.");
            print("1. Option one");
            print("2. Option two");
            print("Please make a selection");

            //string input = inputString();
            //int menuChoiceNum = int.Parse(input);
            int menuChoiceNum = inputInt();

            switch (menuChoiceNum)
            {
                case 1:
                    print("You chose 1.");
                    break;
                case 2:
                    print("You chose 2.");
                    break;
                default:
                    print("Unrecognized number.");
                    break;
            }
            // there is an implicit return at the end of the method, so 
            // for a void function you don't have to write the next line.
            // unless you want to return somewhere other than the end...
            return;
        }

        private static void WaitIdiom()
        {
            // very simple -- just wait for the user to press Enter.
            // useful as console applications will otherwise close
            // before you can read their final output.
            print("Press Enter to continue.");
            // we don't use the value in input below, so this next
            // line could just say
            // Console.ReadLine();
            string input = inputString();
        }

        private static void ForeverIdiom()
        {
            while (true)
            {
                print("This is the song that never ends...");
            }
        }


        // replace WriteLine()
        private static void print(string output)
        {
            Console.WriteLine(output);
        }

        // replace ReadLine()
        private static string inputString()
        {
            return Console.ReadLine();
        }

        private static int inputInt()
        {
            string input = inputString();
            int value = int.Parse(input);
            return value;
        }
    }
}
