using System;
using 
namespace BendeTest.Page
{
    public class CustomerListPage
    {
        public WebDriver Driver;

        public CustomerListPage(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebElement ClickViewButton => Driver(By.CssSelector("btn btn-info"));
    }
}
