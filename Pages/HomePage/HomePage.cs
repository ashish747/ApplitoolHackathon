using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{

    
    public class HomePage : Page
    {
        private HomePageAct homePageAct;
        private HomePageVerify homePageVerify;
        private HomePageVerifyAppli homePageVerifyAppli;

        private HomePage()
        {
            homePageAct = new HomePageAct();
            homePageVerify = new HomePageVerify();
            homePageVerifyAppli = new HomePageVerifyAppli();
        }

        public static HomePage getHomePage()
        {
            return new HomePage();
        }

        public HomePageAct act()
        {
            return homePageAct;
        }

        public IHomePageVerify verify()
        {
            if(!VerifyWithAppli)
            return homePageVerify;

            return homePageVerifyAppli;
        }
        
        public ShowExpensesPage GetShowExpensePage()
        {
            homePageAct.GotoExpensePage();
            return ShowExpensesPage.GetShowExpensesPage();
        }

    }
}
