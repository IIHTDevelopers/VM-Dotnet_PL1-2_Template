using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Threading;
using SeleniumExtras.WaitHelpers;
using DotNetSelenium.Utilities;

    public class MedicalRecordsPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        private By medicalRecordsLink = null;
        private By mrOutpatientList = null;
        private By okButton = null;
        private By searchBar = null;
        private By fromDate = null;
        private By doctorFilter = null;

        public MedicalRecordsPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// This method verifies patient records in the Dispensary module by applying a date filter
        /// and searching for a specific patient by gender. It validates the search results by checking
        /// if the gender appears in the filtered records.
        /// </summary>
        public void KeywordMatching()
        {
            //Write your logic here
        }

        /// <summary>
        /// This method verifies the presence of the doctor filter functionality in the medical records module.
        /// It applies the filter by selecting a specific doctor and a date range, and validates that the search results
        /// correctly display records associated with the selected doctor.
        /// </summary>
        public void PresenceOfDoctorFilter()
        {
        //Write your logic here           
        }
    }
