using ApplitoolHackathonHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public  class ShowExpensesPageAct : TestBase
    {

        private ShowExpensesPageLocators showExpensesPageLocators;

        public ShowExpensesPageAct()
        {
            showExpensesPageLocators = new ShowExpensesPageLocators();
        }
       
     
         public ShowExpensesPageAct GetNextYeardata()
        {
                Browser.Click(showExpensesPageLocators.NextYear);
            return this;
            }

    }
}
