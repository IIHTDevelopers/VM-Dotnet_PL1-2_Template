using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using Newtonsoft.Json.Linq;
using SeleniumExtras.WaitHelpers;
using DotNetSelenium.Utilities;

public class MaternityPage
{
    private readonly IWebDriver driver;
    private readonly WebDriverWait wait;

    public MaternityPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }

    private readonly By maternityLink = null;
    private readonly By reportLink = null;
    private readonly By maternityAllowanceReport = null;
    private readonly By dateFrom = null;
    private readonly By showReportBtn = null;
    private readonly By dataType = null;

    /**
        * @Test7
        * @description This method verifies the functionality of the Maternity Allowance Report.
        * It navigates to the Maternity module, accesses the report section, and opens the Maternity Allowance Report.
        * Initially, it ensures that the data grid is not visible, selects a date range by entering the 'from date,'
        * and clicks the 'Show Report' button. Finally, it waits for the report to load and asserts that the data grid becomes visible.
        */
    public void VerifyMaternityAllowanceReport()
    {
        
       //Write your logic here
    }
}
