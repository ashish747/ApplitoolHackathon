using ApplitoolHackathonHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public  class HomePageAct : TestBase
    {

        private HomePageLocators homePageLocator;

        public HomePageAct()
        {
            homePageLocator = new HomePageLocators();
        }
       
        public HomePageAct SortAmount()
        {
            Browser.Click(homePageLocator.Amount);
            return this;
        }

        internal HomePageAct GotoExpensePage()
        {
            Browser.Click(homePageLocator.ShowExpense);
            return this;
        }
    }
}
