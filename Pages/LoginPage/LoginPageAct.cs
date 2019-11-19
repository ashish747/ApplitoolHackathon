using ApplitoolHackathonHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public  class LoginPageAct : TestBase
    {

        private LoginPageLocators logingPageLocator;

        public LoginPageAct()
        {
            logingPageLocator = new LoginPageLocators();
        }
        public LoginPageAct AddUserName(string username)
        {
            Browser.SetValue(logingPageLocator.UserName, username);
            return this;
        }
        public LoginPageAct AddPassword(string password)
        {
            Browser.SetValue(logingPageLocator.PassWord, password);
            return this;
        }
        public LoginPageAct Login()
        {
            Browser.Click(logingPageLocator.Login);
            return this;
        }
       
    }
}
