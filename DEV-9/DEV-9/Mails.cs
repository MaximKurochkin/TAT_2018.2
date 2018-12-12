using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_9
{
    /// <summary>
    /// Class Mails
    /// finds and prints not read mails
    /// </summary>
    
    class Mails
    { 
        public IWebDriver Driver { get; set; }
        IWebElement notReadMail;

        /// <summary>
        /// starts page with conversations
        /// </summary>
        /// <param name="driver">brauser</param>
        
        public Mails (IWebDriver driver)
        {
            MailIdentifiers identifiers = new MailIdentifiers();

            Driver = driver;
            driver.Navigate().GoToUrl(identifiers.UserMails());
        }

        /// <summary>
        /// Method GetNotReadMails
        /// goes to conversation with not read mail
        /// </summary>
        
        public void GetNotReadMails()
        {
            notReadMail = Driver.FindElement(MailIdentifiers.NotReadMail());
            notReadMail.Click();
        }

        /// <summary>
        /// Method PrintNotReadMails
        /// prints not read conversation 
        /// </summary>
        
        public void PrintNotReadMails()
        {
            GetNotReadMails();
            IWebElement conversation = Driver.FindElement(MailIdentifiers.Conversation());
            var mails = conversation.FindElements(MailIdentifiers.Mail());
            foreach(var i in mails)
            {
                Console.WriteLine("Sender: " + i.FindElement(MailIdentifiers.MailSender()).Text);
                Console.WriteLine("Mail: " + i.FindElement(MailIdentifiers.MailText()).Text);
            }
        }
    }
}
