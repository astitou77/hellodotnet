// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

            using(IWebDriver driver = new ChromeDriver()){
                driver.Navigate().GoToUrl("https://www.google.com");

                IWebElement searchBox = driver.FindElement(By.Name("q"));
                searchBox.SendKeys("Selenium WebDriver");

                searchBox.Submit();

                System.Threading.Thread.Sleep(2000);

                IWebElement results = driver.FindElement(By.Id("search"));
                if(results.Displayed){ 
                    Console.WriteLine("Search results are displayed !!!");
                }else{
                    Console.WriteLine("Search results are NOT displayed !");
                }

                driver.Quit();
            }
        }
    }
}



