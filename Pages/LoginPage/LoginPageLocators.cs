using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class LoginPageLocators
    {
        public string UserName = "//*[@id='username']";
        public string PassWord = "//*[@id='password']";
        public string Login = "//*[@id='log-in']";
        public string Error = "//*[contains(@id,'random_id_')]";
        public string CompanyIcon = @"/html/body/div/div/div[1]/a/img";
        public string UserNameIcon = @"/html/body/div/div/form/div[1]/div";
        public string PasswordIcon = @"/html/body/div/div/form/div[2]/div";
        public string FacebookIcon = @"/html/body/div/div/form/div[3]/div[2]/a[2]/img";
        public string TwitterIcon = @"/html/body/div/div/form/div[3]/div[2]/a[1]/img";
        public string LinkedInIcon = @"/html/body/div/div/form/div[3]/div[2]/a[3]/img";
        public string LoginFormText = @"/html/body/div/div/h4";
        public string RemembermeCheckbox = @"/html/body/div/div/form/div[3]/div[1]/label";
        public Uri Title = new Uri(@"https://demo.applitools.com/hackathon.html");

    public  LoginPageLocators ()
        {}
        
    }
}
