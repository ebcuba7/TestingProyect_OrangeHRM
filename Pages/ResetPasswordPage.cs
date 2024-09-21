using System;
using OpenQA.Selenium;

namespace OrangeHRM.Pages;

public class ResetPasswordPage
{
    private IWebDriver driver;

    public ResetPasswordPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    private IWebElement UsernameFild => driver.FindElement(By.Name("username"));
    private IWebElement CancelButton => driver.FindElement(By.CssSelector("button[class='oxd-button oxd-button--large oxd-button--ghost orangehrm-forgot-password-button orangehrm-forgot-password-button--cancel']"));
    private IWebElement RessetButton => driver.FindElement(By.CssSelector("button[class='oxd-button oxd-button--large oxd-button--secondary orangehrm-forgot-password-button orangehrm-forgot-password-button--reset']"));

    public void EnterUsername(string username)
    {
        UsernameFild.SendKeys(username);
    }
    public void CLickCancelButton()
    {
        CancelButton.Click();
    }
    public void CLickRessetButton()
    {
        RessetButton.Click();
    }
}
