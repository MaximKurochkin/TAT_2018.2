using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_9
{
    /// <summary>
    /// Class MailIdentifiers
    /// keeps different mails identifiers 
    /// </summary>
    
    class MailIdentifiers
    {
        /// <summary>
        /// Method UserMail
        /// returns url of page with conversations
        /// </summary>
        /// <returns>url of page</returns>
        
        public string UserMails()
        {
            return "http://vk.com/im";
        }

        /// <summary>
        /// Method NotReadMails
        /// returns id of 
        /// </summary>
        /// <returns></returns>
        public static By NotReadMail()
        {
            //return By.ClassName("nim-dialog--unread");
            return By.Id(" ui_rmenu_unread ");
        }

        public static By Conversation()
        {
            return By.Id(" im_dialogs ");
        }

        public static By Mail()
        {
            return By.ClassName(" nim-dialog - cw ");
        }

        public static By MailSender()
        {
            return By.ClassName(" nim-dialog - name ");
        }

        public static By MailText()
        {
            return By.ClassName(" nim-dialog - text-preview ");
        }
    }
}
