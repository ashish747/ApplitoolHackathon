using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class HomePageLocators
    {
       
        public string Logo = @"/html/body/div/div[1]/div[1]/a/div[2]";
        public string Table =@"//*[@id='transactionsTable']";
        public string Amount =@"//*[@id='amount']";
        public string ShowExpense =@"//*[@id='showExpensesChart']";
        public string SaleImage2 =@"//*[@id='flashSale2']";
        public string SaleImage1 =@"//*[@id='flashSale']";

        public HomePageLocators()
        {}
        
    }
}
