# What is selenium?
* It is a testing framework used to test web applications in different browsers or environments.
* In other words, it is a suite of software test automation tools used for quality assurance of web applications.
* It is also free because it is open source software.
* Multiple programming languages ​​such as C#, Python, Java are used for Test Scripts.

# Sudo code for setting up selenium
* Create the reference for our browser
IWebDriver driver = new ChromeDriver();

* Navigate to Google page

driver.Navigate().GoToUrl("https://www.google.com.tr/");

* Find the Element

IWebElement element = driver.FindElement(By.Name("q"));

* Perform Ops

element.SendKeys("executeautomation");