// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace hellodotnet{
    class Adnane{
        /// This is an XML comment with 3 slashes
        /// <summary>
        /// This is a Test App to Say Hello
        /// </summary>
        /// <param name='args'>An array of string arguments from the command line</param>
        /// <returns>
        /// No value returned
        /// </returns>
        public static void Main(String[] args){
            Console.WriteLine("What's yo name brah ?");
            string str = Console.ReadLine();
            Console.WriteLine("yo name iz: " + str);
        }
    }
}



