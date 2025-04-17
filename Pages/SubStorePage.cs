using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DotNetSelenium.Utilities;
using SeleniumExtras.WaitHelpers;

public class SubStorePage
{
    private IWebDriver driver;
    private WebDriverWait wait;
    private JObject subStoreData;

    private By wardSupplyLink = null;
    private By substore = null;
    private By inventoryRequisitionTab = null;
    private By createRequisitionButton = null;
    private By targetInventoryDropdown = null;
    private By itemNameField = null;
    private By requestButton = null;
    private By successMessage = null;
    private By accountBtn = null;
    private By printButton = null;
    private By consumptionLink = null;
    private By newConsumptionBtn = null;
    private By inputItemName = null;
    private By saveBtn = null;
    private By successMessage1 = null;
    private By reportLink = null;
    private By consumptionReport = null;
    private By subCategory = null;
    private By showReport = null;
    private By issueField = null;

    public SubStorePage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }

    /**
   * @Test7
   * @description This method verifies the creation of an inventory requisition in the Ward Supply module.
   * It navigates to the Substore section, selects a target inventory, adds an item, and submits the requisition.
   * The method ensures the requisition is successfully created by verifying the success message.
   */
    public void CreateInventoryRequisition()
    {
       //Write your logic here
    }

    /**
   * @Test11
   * @description This method creates a new consumption section. It navigates through the Ward Supply module,
   * accesses the account and consumption sections, and opens the "New Consumption" form.
   * The function enters the item name, submits the form, and verifies the successful creation of the consumption
   * section by asserting that a success message becomes visible.
   * Throws an error if the success message is not displayed after submission.
   */
    public void CreatingConsumptionSection()
    {
        //Write your logic here
    }

    /**
   * @Test12
   * @description This method creates a new report section in the Ward Supply module. It navigates through
   * the report section and selects the specified item name from the subcategory dropdown. After generating
   * the report, the function verifies if the selected item name is displayed in the report grid.
   * Throws an error if the item name is not found in the report results.
   */
    public void CreatingReportSection()
    {
        //Write your logic here
    }
}
