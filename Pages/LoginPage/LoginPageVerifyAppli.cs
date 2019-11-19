using ApplitoolHackathonHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Pages
{
    public class LoginPageVerifyAppli : TestBase , ILoginPageVerify
    {
       
        public LoginPageVerifyAppli()
        {
            
        }

        public ILoginPageVerify verifyError(string value)
        {

            VerifyApplieye("verifyError");
            return this;
        }

        public ILoginPageVerify VerifyLoginForm()
        {
            VerifyApplieye("VerifyLoginForm");
            return this;
        }
        public ILoginPageVerify VerifyIcon()
        {
            VerifyApplieye("VerifyIcon");
            return this;
        }
        public ILoginPageVerify VerifyRememberMe()
        {

            VerifyApplieye("VerifyRememberMe");
            return this;
        }
        public ILoginPageVerify VerifyMediaConnects()
        {
            VerifyApplieye("VerifyMediaConnects");
            return this;
        }

    }
}
