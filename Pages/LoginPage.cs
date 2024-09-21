using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OrangeHRM.Pages;

public class LoginPage
{
    private IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;

    }
    private IWebElement UsernameFild => driver.FindElement(By.Name("username"));
    private IWebElement PasswordField => driver.FindElement(By.Name("password"));
    private IWebElement ButtonAccess => driver.FindElement(By.CssSelector("button[type='submit']"));
    private IWebElement ForgotYourPassword => driver.FindElement(By.CssSelector("p[class='oxd-text oxd-text--p orangehrm-login-forgot-header']"));
    private IWebElement OrangeHRMInc => driver.FindElement(By.CssSelector("a[href='http://www.orangehrm.com']"));

    public void EnterUsername(string username)
    {
        UsernameFild.SendKeys(username);
    }
    public void EnterPassword(string password)
    {
        PasswordField.SendKeys(password);
    }
    public void ButtonClic()
    {
        ButtonAccess.Click();
    }

    public void ResetPassword()
    {
        ForgotYourPassword.Click();
    }

    public void AccessToPublicity()
    {
        OrangeHRMInc.Click();
    }
}
