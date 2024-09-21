using System;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;

namespace OrangeHRM.Pages;

public class DashboardPage
{
    private IWebDriver driver;

    public DashboardPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    //Access links
    private IWebElement IconField => driver.FindElement(By.CssSelector("img[alt='client brand banner']"));
    private IWebElement SearchField => driver.FindElement(By.CssSelector("input[class='oxd-input oxd-input--active']"));
    private IWebElement AdminAccessField => driver.FindElement(By.CssSelector("a[href='/web/index.php/admin/viewAdminModule']"));
    private IWebElement PIMAccessField => driver.FindElement(By.CssSelector("a[href='/web/index.php/pim/viewPimModule']"));
    private IWebElement LeaveAccessField => driver.FindElement(By.CssSelector("a[href='/web/index.php/leave/viewLeaveModule']"));
    private IWebElement TimeAccessField => driver.FindElement(By.CssSelector("a[href='/web/index.php/time/viewTimeModule']"));
    private IWebElement RecruitmenAccessField => driver.FindElement(By.CssSelector("a[href='/web/index.php/recruitment/viewRecruitmentModule']"));
    private IWebElement MyInfoAccessField => driver.FindElement(By.CssSelector("a[href='/web/index.php/pim/viewMyDetails']"));
    private IWebElement PerformanceAccessField => driver.FindElement(By.CssSelector("a[href='/web/index.php/performance/viewPerformanceModule']"));
    private IWebElement DirectoryAccessField => driver.FindElement(By.CssSelector("a[href='/web/index.php/directory/viewDirectory']"));
    private IWebElement MaintenanceAccessField => driver.FindElement(By.CssSelector("a[href='/web/index.php/maintenance/viewMaintenanceModule']"));
    private IWebElement ClaimAccessField => driver.FindElement(By.CssSelector("a[href='/web/index.php/claim/viewClaimModule']"));
    private IWebElement BuzzAccessField => driver.FindElement(By.CssSelector("a[href='/web/index.php/buzz/viewBuzz']"));



}
