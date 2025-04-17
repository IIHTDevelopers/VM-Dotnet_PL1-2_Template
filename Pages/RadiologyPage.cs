using DotNetSelenium.Utilities;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;

public class RadiologyPage
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public RadiologyPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
    }

    /**
   * @Test9
   * @description This method verifies that the data displayed in the radiology list request is within the last three months.
   * It navigates to the Radiology module, selects the "Last 3 Months" option from the date range dropdown, and confirms the filter.
   * The method retrieves all dates from the table, validates their format, and checks if they fall within the last three months.
   * Logs detailed errors if dates are invalid or out of range and provides debug information about the number of date cells and retrieved dates.
   * Throws an error if any date is invalid or outside the range.
   */
    public void VerifyDataWithinLastThreeMonths()
    {
    //Write your logic here
    }

    /**
   * @Test14
   * @description This method filters the list of radiology requests based on a specified date range and imaging type.
   * It navigates to the Radiology module, applies the selected filter, enters the 'From' and 'To' dates, and confirms the filter action.
   * The method verifies that the filtered results match the specified imaging type.
   */
    public void FilterListRequestsByDateAndType()
    {
     //Write your logic here
    }
}
