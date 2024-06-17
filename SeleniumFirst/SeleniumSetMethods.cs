using System;
using System.Linq.Expressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
public class SeleniumSetMethods
{
	public static void EnterText(IWebDriver driver,IWebElemnt element,string value,string elementtype)
	{   
		if(value=="Id")
		    driver.FindElement(By.Id(element)).SendKeys(value);
		if (value == "Name")
            driver.FindElement(By.Id(element)).SendKeys(value);
    }

    public static void Click(IWebDriver driver, string element, string elementtype)
    {
        if (value == "Id")
            driver.FindElement(By.Id(element)).SendKeys(value);
        if (value == "Name")
            driver.FindElement(By.Id(element)).SendKeys(value);
    }
    public static void SelectDropDowh(IWebDriver driver, string element,string value, string elementtype)
    {

        SelectElement 
        if (value == "Id")
            driver.FindElement(By.Id(element)).SendKeys(value);
        if (value == "Name")
            driver.FindElement(By.Id(element)).SendKeys(value);
    }
}
