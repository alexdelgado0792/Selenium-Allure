using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework
{

    [TestFixture]
    [AllureNUnit]
    //[AllureDisplayIgnored]
    public class UnitTest1
    {
        [Test(Description = "XXX")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        //[AllureIssue("ISSUE-1")]
        //[AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver
            {
                Url = "https://www.webpage.com/"
            };
            driver.Close();
        }
    }
}
