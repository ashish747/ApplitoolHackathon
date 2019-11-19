using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{

    
    public class LoginPage : Page
    {
        private LoginPageAct loginPageAct;
        private LoginPageVerify loginPageVerify;
        private LoginPageVerifyAppli loginPageVerifyAppli;

        private LoginPage()
        {
            loginPageAct = new LoginPageAct();
            loginPageVerify = new LoginPageVerify();
            loginPageVerifyAppli = new LoginPageVerifyAppli();
        }

        public static LoginPage getLoginpage()
        {
            return new LoginPage();
        }

        public HomePage GotoHomePage()
        {
            loginPageAct.AddUserName("username").AddPassword("password").Login();
            return HomePage.getHomePage();
        }

        public LoginPageAct act()
        {
            return loginPageAct;
        }

        public ILoginPageVerify verify()
        {
            if (!VerifyWithAppli)
                return loginPageVerify;

            return loginPageVerifyAppli;
            
        }

    }
}
