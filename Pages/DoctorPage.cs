using System;
using System.IO;
using DotNetSelenium.Utilities;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace YakshaTests
{
    public class DoctorPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public DoctorPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        private By doctorsLink = null;
        private By inpatientDepartmentTab = null;
        private By searchBar = null;
        private By orderDropdown = null;
        private By imagingActionButton = null;
        private By searchOrderItem = null;
        private By proceedButton = null;
        private By signButton = null;
        private By successMessage = null;

        /**
            * @Test8
            * @description This method verifies the process of placing an imaging order for an inpatient.
            * It navigates to the Inpatient Department, searches for a specific patient, selects an imaging action,
            * chooses an order type, specifies the order item, and completes the process by signing the order.
            * The method confirms the successful placement of the order by verifying the success message.
            */
        public void PerformInpatientImagingOrder()
        {
            // Write your logic here    
        }
}
