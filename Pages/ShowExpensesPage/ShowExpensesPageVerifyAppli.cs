using ApplitoolHackathonHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Pages
{
    public class ShowExpensesPageVerifyAppli : TestBase , IShowExpensesPageVerify
    {
       
        public ShowExpensesPageVerifyAppli()
        {
            
        }

    

        public IShowExpensesPageVerify verifyChart(List<List<string>> results)
        {
            VerifyApplieye("verifyChart");
            return this;
            
       }
    }
}
