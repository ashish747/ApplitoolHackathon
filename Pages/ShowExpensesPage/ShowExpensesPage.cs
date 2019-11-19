using ApplitoolHackathonHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{

    
    public class ShowExpensesPage : Page
    {
        private ShowExpensesPageAct showExpensesPageAct;
        private ShowExpensesPageVerify showExpensesPageVerify;
        private ShowExpensesPageVerifyAppli showExpensesPageVerifyAppli;


        private ShowExpensesPage()
        {
            showExpensesPageAct = new ShowExpensesPageAct();
            showExpensesPageVerify = new ShowExpensesPageVerify();
            showExpensesPageVerifyAppli = new ShowExpensesPageVerifyAppli();
        }

        public ShowExpensesPageAct act()
        {
            return showExpensesPageAct;
        }

        public IShowExpensesPageVerify verify()
        {
            if (!VerifyWithAppli)
                return showExpensesPageVerify;

            return showExpensesPageVerifyAppli;
        }

        public static ShowExpensesPage GetShowExpensesPage()
        {
            return new ShowExpensesPage();
        }
    }
}
