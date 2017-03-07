using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// norrisa
// CSC 153
// 3/7/17
// 
// Examples of several programming 'idioms', 
// common constructions for how to do certain tasks in programming.


namespace ConsoleIdiomsExample
{
    public class Program
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


        public static void Main(string[] args)
        {

            // we'll write various idioms in here as methods, then call them individually.
            // this makes it easier to tell them apart.
            MenuIdiom();

            // other idioms go here
            // ForeverIdiom();
            // InputIdiom();
            // RepeatUntilIdiom();
            // IdiomToBeNamedLaterIdiom();

            // when done, wait for user input
            WaitIdiom();
        }

        // this method is private, meaning it cannot be called outside of this class.
        // This means Main() can use it, but no one else can.
        // commonly called a 'private helper function' or 'helper method'
        private static void MenuIdiom()
        {
            Console.WriteLine("This is a menu.");
            Console.WriteLine("1. Option one");
            Console.WriteLine("2. Option two");
            Console.WriteLine("Please make a selection");

            string input = Console.ReadLine();
            int menuChoiceNum = int.Parse(input);
            switch(menuChoiceNum)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                default:
                    Console.WriteLine("Unrecognized number.");
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
            Console.WriteLine("Press Enter to continue.");
            // we don't use the value in input below, so this next
            // line could just say
            // Console.ReadLine();
            string input = Console.ReadLine();
        }

        private static void ForeverIdiom()
        {
            // from http://www.programming-idioms.org/idiom/50/make-an-infinite-loop
            while (true)
            {
                // Do something
                Console.WriteLine("This is the song that never ends.");
            }
        }
    }
}
