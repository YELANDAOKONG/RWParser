using System.Text.RegularExpressions;

namespace RWLibrary;

public interface IRWRule
{
    // Regex ID - Regex Name
    public Dictionary<int, string> GetNameList();
    // Regex ID - Regex Object
    public Dictionary<int, Regex> GetRegexList();
    // Weight - Regex ID
    public Dictionary<int, int> GetWeightList();
    // Special Char
    public List<string> GetSpecialCharList();
    // Char - Name
    public Dictionary<string, string> GetCharList();
}