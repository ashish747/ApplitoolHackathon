using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
   public interface IHomePageVerify
    {
        IHomePageVerify VerifyLogo();

        IHomePageVerify VerifyAmountColumnSorted();
        IHomePageVerify VerifyFlashSaleImagesDisplayed();
    }
}
