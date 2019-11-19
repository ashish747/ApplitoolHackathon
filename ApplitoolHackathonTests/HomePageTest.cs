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
    public class HomePageTest : TestBase
    {
        [Test]
        public void ClickAmountColumnSorted()
        {
            TestName = "ClickAmountColumnSorted";
            HomePage homePage = LoginPage.getLoginpage().GotoHomePage();

            homePage.act().SortAmount();

            homePage.verify().VerifyAmountColumnSorted();
            
        }
               

        [Test]
        public void DynamicContentTesting()
        {
            TestName = "DynamicContentTesting";
            HomePage homePage = LoginPage.getLoginpage().GotoHomePage();
            homePage.verify().VerifyFlashSaleImagesDisplayed();
        }

        }
    }
