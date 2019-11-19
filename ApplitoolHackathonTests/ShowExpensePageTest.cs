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
    public class ShowExpensePageTest : TestBase
    {
        [Test]
        public void ShowExpensePageChart()
        {
            TestName = "ShowExpensePageChart";
            List<List<string>> results = new List<List<string>>();
            List<string> BaseCalendar = new List<string> { "January", "February", "March", "April", "June", "July", "August" };
            List<string> DisplayCalendar = new List<string> { "January", "February", "March", "April", "June", "July" };
            List<string> ChartSet1 = new List<string> { "10", "20", "30", "40", "50", "60", "70" };
            List<string> ChartSet2 = new List<string> { "8", "9", "-10", "10", "40", "60" };

            results.Add(BaseCalendar);
            results.Add(DisplayCalendar);
            results.Add(ChartSet1);
            results.Add(ChartSet2);

            ShowExpensesPage showExpensePage = LoginPage.getLoginpage().GotoHomePage().GetShowExpensePage();

            showExpensePage.verify().verifyChart(results);
        }

        [Test]
        public void ShowExpensePageChartPostNewYearData()
        {
            TestName = "ShowExpensePageChartPostNewYearData";
            List<List<string>> results = new List<List<string>>
                {
                    new List<string> { "January", "February", "March", "April", "June", "July", "August" },
                    new List<string> { "January", "February", "March", "April", "June", "July" },
                    new List<string> { "10", "20", "30", "40", "50", "60", "70" },
                    new List<string> { "8", "9", "-10", "10", "40", "60" },
                    new List<string> { "5", "10", "15", "20", "25", "30", "35" }
                };

            ShowExpensesPage showExpensePage = LoginPage.getLoginpage().GotoHomePage().GetShowExpensePage();

            showExpensePage.act().GetNextYeardata();

            showExpensePage.verify().verifyChart(results);
        }

    }
}
