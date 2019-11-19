using ApplitoolHackathonHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Pages
{
    public class ShowExpensesPageVerify : TestBase , IShowExpensesPageVerify
    {
        private ShowExpensesPageLocators showExpensesPageLocator;
        public ShowExpensesPageVerify()
        {
            showExpensesPageLocator = new ShowExpensesPageLocators();
        }

       public IShowExpensesPageVerify verifyChart(List<List<string>> results)
        {

           List<string> str = new List<string>();

            var values = Browser.GetAttributes(showExpensesPageLocator.chart);

            int start, end, count = 0;
            do
            {
                start = values.IndexOf("[");
                end = values.IndexOf("]");
                str.Add(values.Substring(start, end));
                count = (end - start);
                if (start <= 0 || count <= 0 || end <= 0)
                    break;
                values = values.Remove(start, count + 1);
            } while (start > 0);

            int i = 0;
            foreach (var result in results)
            {
                foreach (var item in result)
                {
                    Assert.IsTrue(str[i].Contains(item));
                }
                i++;
            }

            return this;
       }
    }
}
