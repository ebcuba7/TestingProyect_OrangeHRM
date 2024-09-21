using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OrangeHRM.Driver;

public class WebDriverManager
{
    private IWebDriver driver;


    public IWebDriver GetDriver()
    {
        if (driver == null)
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--remote-allow-origins=*");
            options.AddArguments("--disable-search-engine-choice-screen");

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            
        }
        return driver;
    }

    public void CloseDriver()
    {
        if (driver!=null)
        {
            driver.Quit();
            driver = null;
        }
        
    }

}
