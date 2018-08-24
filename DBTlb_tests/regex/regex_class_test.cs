using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DBT;

namespace DBTlb_tests.regex
{
    [TestClass]
    public class regex_class_test
    {
        string str = "Point 18a, Line 10b; Line15, ";
        string reg = @"(Line\s?)(?<lineno>\d+\w?)";
        string grname = "lineno";


        [TestMethod]
        public void regexgroup()
        {
            string s = regex_class.GetRegexWithGroup(str,reg, grname, null);
            Assert.AreEqual(s, "10b");
        }

        [TestMethod]
        public void regexgroupid()
        {
            string s = regex_class.GetRegexWithGroup(str, reg, grname, 0);
            Assert.AreEqual(s, "10b");
            string s2 = regex_class.GetRegexWithGroup(str, reg, grname, 1);
            Assert.AreEqual(s2, "15");
        }

    }
}
