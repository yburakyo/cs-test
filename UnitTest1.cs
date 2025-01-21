namespace project2;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

        var options = new ChromeOptions();
        options.AddArgument("--disable-notifications");
        IWebDriver driver = new ChromeDriver(options);

        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("https://www.trendyol.com");

        IWebElement modal_close = driver.FindElement(By.ClassName("modal-close"));
        modal_close.Click();

        System.Threading.Thread.Sleep(2000);

        driver.Quit();
    }
}
