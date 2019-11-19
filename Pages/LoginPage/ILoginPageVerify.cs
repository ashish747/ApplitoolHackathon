using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public interface ILoginPageVerify
    {
        ILoginPageVerify verifyError(string value);

        ILoginPageVerify VerifyLoginForm();
        ILoginPageVerify VerifyIcon();
        ILoginPageVerify VerifyRememberMe();
         ILoginPageVerify VerifyMediaConnects();
    }
}
