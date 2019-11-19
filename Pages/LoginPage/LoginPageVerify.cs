using ApplitoolHackathonHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Pages
{
    public class LoginPageVerify : TestBase , ILoginPageVerify
    {
        private LoginPageLocators logingPageLocator;
        public LoginPageVerify()
        {
            logingPageLocator = new LoginPageLocators();
        }

        public ILoginPageVerify verifyError(string value)
        {

            Assert.AreEqual( Browser.GetValue(logingPageLocator.Error),value);
            return this;
        }

        public ILoginPageVerify VerifyLoginForm()
        {
            Assert.AreEqual(Browser.GetValue(logingPageLocator.LoginFormText),"Login Form");
            return this;
        }
        public ILoginPageVerify VerifyIcon()
        {
            Assert.IsTrue(Browser.IsElementOnPage(logingPageLocator.UserNameIcon));
            Assert.IsTrue(Browser.IsElementOnPage(logingPageLocator.PasswordIcon));
            Assert.IsTrue(Browser.IsElementOnPage(logingPageLocator.CompanyIcon));
            return this;
        }
        public ILoginPageVerify VerifyRememberMe()
        {
            Assert.IsTrue(Browser.IsElementOnPage(logingPageLocator.RemembermeCheckbox));
           
            return this;
        }
        public ILoginPageVerify VerifyMediaConnects()
        {
            Assert.IsTrue(Browser.IsElementOnPage(logingPageLocator.FacebookIcon));
            Assert.IsTrue(Browser.IsElementOnPage(logingPageLocator.LinkedInIcon));
            Assert.IsTrue(Browser.IsElementOnPage(logingPageLocator.TwitterIcon));
            return this;
        }

    }
}
