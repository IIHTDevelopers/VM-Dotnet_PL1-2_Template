using System;
using System.IO;
using DotNetSelenium.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class LoginPage
{
    private readonly IWebDriver driver;
    private readonly WebDriverWait wait;

    private readonly By usernameInput = null;
    private readonly By passwordInput = null;
    private readonly By loginButton = null;
    private readonly By loginErrorMessage = null;
    private readonly By admin = null;
    private readonly By logOut = null;

    // Store login data
    private string validUsername;
    private string validPassword;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }

    /*
   * @description This method performs the login operation using the provided valid credentials. It highlights the input
   *              fields for better visibility during interaction and fills the username and password fields. After submitting
   *              the login form by clicking the login button, it validates the success of the login process. The login is
   *              considered successful if there are no errors.
   */
    public void PerformLogin()
    {
        // Write your logic here
    }

    /**
   * @Test15 This method attempts login with invalid credentials and retrieves the resulting error message.
   * @description Tries logging in with incorrect credentials to verify the login error message display.
   *              Highlights each input field and the login button during interaction. Captures and returns
   *              the error message displayed upon failed login attempt.
   */
    public void PerformLoginWithInvalidCredentials()
    {
        // Write your logic here
    }
}
