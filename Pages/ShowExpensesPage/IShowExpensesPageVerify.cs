﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
   public  interface IShowExpensesPageVerify
    {
        IShowExpensesPageVerify verifyChart(List<List<string>> results);
    }
}
