// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("http://www.google.com");
driver.FindElement(By.Name("q")).SendKeys("learn Automation");
