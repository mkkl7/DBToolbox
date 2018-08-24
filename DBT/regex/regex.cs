using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using DBT;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString RegexWithGroup(string inp, string regex, string group,  int? groupid)
    {
        string s = regex_class.GetRegexWithGroup(inp, regex, group, groupid);

        return new SqlString(s);
    }
}
