using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DBT
{
    public static class regex_class
    {
        public static string GetRegexWithGroup(string inp, string regex, string group, int? groupid)
        {
            var r = new Regex(regex);
            var m = r.Matches(inp);
            if (m.Count > 0)
            {
                if (groupid is null)
                    return m[0].Groups[group].Value;
                else
                    return m[(int)groupid].Groups[group].Value;
            }
            else
                return null;
        }

        public static string GetRegex(string inp, string regex, int? matchid)
        {
            var r = new Regex(regex);
            var m = r.Matches(inp);
            if (m.Count > 0)
            {
                if (matchid is null)
                    return m[0].Value;
                else
                    return m[(int)matchid].Value;
            }
            else
                return null;
        }
    }
}
