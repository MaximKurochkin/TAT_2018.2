using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DEV_9
{
    /// <summary>
    /// Class LogInVk
    /// logins into VK
    /// </summary>
    
    class LogInVK
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public IWebDriver Driver { get; set; }

        IWebElement logInbtn;

        /// <summary>
        /// Method LogInVK
        /// constructor
        /// </summary>
        /// <param name="login">user login</param>
        /// <param name="password">user password</param>
        /// <param name="driver">brauser</param>
        
        public LogInVK(string login, string password, IWebDriver driver)
        {
            Login = login;
            Password = password;
            Driver = driver;

            WebDriverWait waiter = new WebDriverWait(Driver, TimeSpan.FromSeconds(120));

            LogInIdentifiers identifiers = new LogInIdentifiers();
            Driver.Navigate().GoToUrl(identifiers.VkUrl());

            logInbtn = waiter.Until(_driver => driver.FindElement(By.Id(identifiers.LogInBtn())));
        }

        /// <summary>
        /// Method LogIn
        /// Login in VK
        /// </summary>
        
        public void LogIn()
        {
            LogInIdentifiers identifiers = new LogInIdentifiers();

            Driver.FindElement(By.Id(identifiers.LogInIdentifier())).SendKeys(Login);
            Driver.FindElement(By.Id(identifiers.PasswordIdentifier())).SendKeys(Password);

            logInbtn.Click();
        }
    }
}
