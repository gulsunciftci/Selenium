using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[]args)
        {
            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver();

            //Navigate to Google page

            driver.Navigate().GoToUrl("https://www.google.com.tr/");
            Console.WriteLine("Opened URL");

            //EnterText(element,value,type)

            //Find the Element

            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Ops

            element.SendKeys("executeautomation");
            element.Submit();
            Console.WriteLine("Executed Test");

            driver.Close();
            Console.WriteLine("Closed the browser");
        }


    }
}
