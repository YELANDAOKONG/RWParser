using System.Text.RegularExpressions;
using RWLibrary;

namespace RWParser;

public class RWMath : IRWRule
{
    
    public Dictionary<int, string> GetNameList()
    {
        return new Dictionary<int, string>()
        {
            { 1, "new_line"},
            { 99999, "string"},
            { -99999999, "unknow"},
        };
    }
    
    public Dictionary<int, Regex> GetRegexList()
    {
        return new Dictionary<int, Regex>()
        {
            { 1, new Regex("^[\n|\r]$")},
            { 99999, new Regex("^\".*\"$")},
            { -99999999, new Regex("^.*$")},
        };
    }
    
    public Dictionary<int, int> GetWeightList(){
        return new Dictionary<int, int>()
        {
            
            { 1, 1 },
            { 99999, 99999 },
            // { 9999999, -99999999 },
        };
    }
    
    public List<string> GetSpecialCharList()
    {
        return new List<string>()
        {
            
        };
    }

    public Dictionary<string, string> GetCharList()
    {
        return new Dictionary<string, string>()
        {
            { ";", "char ;"},
            { "-", "char -"},
        };
    }
}