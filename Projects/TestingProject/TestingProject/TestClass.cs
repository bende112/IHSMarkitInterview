using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestingProject.BaseClass;


namespace TestingProject
{
    
    public class TestClass : BaseTest
    {
      
        [Test]
        public void TestMethod()
        {
            IWebElement ViewButton = Driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div[2]/div[2]/button"));
            ViewButton.Click();
        }
    }
}