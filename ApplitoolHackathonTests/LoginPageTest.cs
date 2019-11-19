using ApplitoolHackathonHelpers;
using NUnit.Framework;
using Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApplitoolHackathonTests
{
    public class LoginPageTest : TestBase
    {
        [Test]
        public void LoginPageSuccessful()
        {
            TestName = "LoginPageSuccessful";
            LoginPage loginPage = LoginPage.getLoginpage();
            HomePage homePage = HomePage.getHomePage();

            loginPage.act().AddUserName("username").AddPassword("password").Login();

            homePage.verify().VerifyLogo();
                                  
        }

        [Test]
        [TestCase ("username","", "Password must be present")]
        [TestCase ("", "password", "Username must be present")]
        [TestCase("", "", "Both Username and Password must be present")]
        public void LoginPageFailure(string username, string password, string Error )
        {
            TestName = "LoginPageFailure"+Error;
            LoginPage loginPage = LoginPage.getLoginpage();

            loginPage.act().AddUserName(username).AddPassword(password).Login();
            
            loginPage.verify().verifyError(Error);
        }

        [Test]
        public void LoginPageVerifyUI()
        {
            TestName = "LoginPageVerifyUI";
            LoginPage loginPage = LoginPage.getLoginpage();

            loginPage.verify().VerifyLoginForm().VerifyIcon().VerifyRememberMe().VerifyMediaConnects();

        }

    }
}
