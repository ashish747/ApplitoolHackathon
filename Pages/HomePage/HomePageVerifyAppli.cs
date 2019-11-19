using ApplitoolHackathonHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Pages
{
    public class HomePageVerifyAppli : TestBase , IHomePageVerify
    {
       
        public HomePageVerifyAppli()
        {
            
        }

        public IHomePageVerify VerifyLogo()
        {

            VerifyApplieye("VerifyLogo");
            return this;
        }

        public IHomePageVerify VerifyAmountColumnSorted()
        {

            VerifyApplieye("VerifyAmountColumnSorted");
            return this;
        }

        public IHomePageVerify VerifyFlashSaleImagesDisplayed()
        {
            VerifyApplieye("VerifyFlashSaleImagesDisplayed");
              return this;
        }
    }
}
