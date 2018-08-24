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
        public void regex_group_string()
        {
            string s = regex_class.GetRegexWithGroup(str,reg, grname, null);
            Assert.AreEqual(s, "10b");
        }

        [TestMethod]
        public void regex_group_with_id()
        {
            string s = regex_class.GetRegexWithGroup(str, reg, grname, 0);
            Assert.AreEqual(s, "10b");
            string s2 = regex_class.GetRegexWithGroup(str, reg, grname, 1);
            Assert.AreEqual(s2, "15");
        }

        [TestMethod]
        public void regex_string()
        {
            string s = regex_class.GetRegex(str, reg, null);
            Assert.AreEqual(s, "Line 10b");
        }

        [TestMethod]
        public void regex_string_with_id()
        {
            string s = regex_class.GetRegex(str, reg, 1);
            Assert.AreEqual(s, "Line15");
        }

    }
}
