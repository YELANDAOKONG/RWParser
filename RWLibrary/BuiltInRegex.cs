using System.Text.RegularExpressions;

namespace RWLibrary;

public class BuiltInRegex
{
    public static readonly Regex String = new Regex("^\".*\"$");
    public static readonly Regex Char = new Regex("^\'.*\'$");
}