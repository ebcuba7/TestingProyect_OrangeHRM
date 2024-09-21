using System;
using OpenQA.Selenium;
using OrangeHRM.Driver;
using OrangeHRM.Pages;

namespace OrangeHRM.Test;

public class LoginPageTest : IDisposable
{
    private WebDriverManager webDriverManager;
    private LoginPage loginPage;

    public LoginPageTest()
    {
        webDriverManager = new WebDriverManager();
        var driver = webDriverManager.GetDriver();

        loginPage = new LoginPage(driver);
        driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
    }

    [Fact]
    public void ValidLoginTest()
    {
        loginPage.EnterUsername("Admin");
        loginPage.EnterPassword("admin123");
        loginPage.ButtonClic();

        Assert.True(webDriverManager.GetDriver().Title.Contains("OrangeHRM"));
        // Title.Contains("OrangeHRM");
    }

    [Fact]
    public void InvalidLoginTest()
    {
        loginPage.EnterUsername("Admin");
        loginPage.EnterPassword("admin");
        loginPage.ButtonClic();

        var errorMessage = webDriverManager.GetDriver().FindElement(By.CssSelector("p[class='oxd-text oxd-text--p oxd-alert-content-text']"));
        Assert.True(errorMessage.Displayed);
    }
    [Fact]
    public void AccessResetPassword()
    {
        loginPage.ResetPassword();
        var result = webDriverManager.GetDriver().FindElement(By.CssSelector("div[class='orangehrm-card-container']"));

        Assert.True(result.Displayed);
    }

   /* [Fact]
     public void DontAccessResetPassword()
    {
        loginPage.ResetPassword();
        var result = webDriverManager.GetDriver().FindElement(By.CssSelector("div[class='orangehrm-card-container']"));

        Assert.True(!result.Displayed);
    } */

  /*   [Fact]
    public void AccessOrangeHRMInc()
    {
        loginPage.AccessToPublicity();
        Assert.True(webDriverManager.GetDriver().Title.Contains("Human Resources Management Software"));

    } */
    public void Dispose()
    {
         webDriverManager.CloseDriver(); 
    }
}
