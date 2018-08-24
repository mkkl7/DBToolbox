using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using DBT;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString RegexWithGroup(string inp, string regex, string group, int? groupid)
    {
        return new SqlString(regex_class.GetRegexWithGroup(inp, regex, group, groupid));        
    }

    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString Regex(string inp, string regex, int? matchpos)
    {
        return new SqlString(regex_class.GetRegex(inp, regex, matchpos));
    }
}
