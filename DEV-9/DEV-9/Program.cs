using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_9
{
    /// <summary>
    /// Class Program
    /// prints not read mails from VK into console
    /// </summary>
    
    class Program
    {
        /// <summary>
        /// Method Main
        /// entery point
        /// </summary>
        /// <param name="args"></param>
        
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            LogInVK logInVK = new LogInVK("Login", "Password", driver);
            logInVK.LogIn();

            Mails mails = new Mails(driver);
            mails.PrintNotReadMails();

            driver.Quit();
        }
    }
}
