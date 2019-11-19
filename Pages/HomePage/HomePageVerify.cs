using ApplitoolHackathonHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Pages
{
    public class HomePageVerify : TestBase , IHomePageVerify
    {
        private HomePageLocators homePageLocator;
        public HomePageVerify()
        {
            homePageLocator = new HomePageLocators();
        }

        public IHomePageVerify VerifyLogo()
        {

            Assert.IsTrue( Browser.IsElementOnPage(homePageLocator.Logo));
            return this;
        }

        public IHomePageVerify VerifyAmountColumnSorted()
        {
            var AmountColumn= Browser.GetTable(homePageLocator.Table);

            double prevValue = int.MinValue;

            //check if column is sorted
            foreach( var value in AmountColumn)
            {
                var value1 = value.TrimEnd('U', 'S', 'D').Replace(" ","").Replace("+","");
                
                double currvalue = Convert.ToDouble(value1);// int.Parse(value1);
                Assert.IsFalse(prevValue > currvalue);
                prevValue = currvalue;
            }

            return this;
        }

        public IHomePageVerify VerifyFlashSaleImagesDisplayed()
        {
            Assert.IsTrue(Browser.GetAttributes(homePageLocator.SaleImage1).Contains(".gif"));
            Assert.IsTrue(Browser.GetAttributes(homePageLocator.SaleImage2).Contains(".gif"));
            return this;
        }
    }
}
