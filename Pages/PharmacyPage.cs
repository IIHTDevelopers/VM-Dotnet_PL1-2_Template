using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using SeleniumExtras.WaitHelpers;
using DotNetSelenium.Utilities;
using NUnit.Framework;

public class PharmacyPage
{
    private readonly IWebDriver driver;
    private readonly WebDriverWait wait;

    public PharmacyPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
    }

    private By pharmacyModule = null;
    private By orderLink = null;
    private By addNewGoodReceiptButton = null;
    private By goodReceiptModalTitle = null;
    private By printReceiptButton = null;
    private By addNewItemButton = null;
    private By itemNameField = null;
    private By batchNoField = null;
    private By itemQtyField = null;
    private By rateField = null;
    private By saveButton = null;
    private By supplierNameField = null;
    private By invoiceField = null;
    private By successMessage = null;
    private By supplierName = null;
    private By showDetails = null;

    /**
   * @Test1
   * @description This method navigates to the Pharmacy module, verifies the Good Receipt modal,
   * handles alerts during the Good Receipt print process, and ensures the modal is visible
   * before performing further actions.
   */
    public void HandlingAlertOnPharmacy()
    {
        //Write your logic here
    }

    private void HandleAlert(string alertText)
    {
        //Write your logic here
    }

    /**
   * @Test2
   * @description This method verifies the process of adding a new Good Receipt in the Pharmacy module,
   * filling in item details such as item name, batch number, quantity, rate, supplier name,
   * and a randomly generated invoice number. It concludes by validating the successful printing of the receipt.
   */
    public void VerifyPrintReceipt()
    {
        //Write your logic here
    }

    /**
   * @Test13
   * @description This method verifies the presence of a supplier name in the order section of the Pharmacy module.
   * It navigates through the necessary elements to input the supplier name, triggers the search, and then checks if
   * the supplier name appears in the results grid. If the supplier name is not found, it throws an error.
   */
    public void VerifyPresenceOfSupplierName()
    {
        //Write your logic here
    }
}
