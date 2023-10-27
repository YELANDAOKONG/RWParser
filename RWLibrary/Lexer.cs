using System.Data;
using System.Text.RegularExpressions;

namespace RWLibrary;

public class Lexer
{
    public IRWRule Rule;

    public Lexer(IRWRule rule)
    {
        this.Rule = rule;
    }

    public List<Token> GetTokenList(string input)
    {
        List<Token> list = new List<Token>();

        string cache = "";
        foreach (var charNow in input)
        {
            foreach (var weight in Rule.GetWeightList())
            {
                int rid = weight.Value;
                string name = Rule.GetNameList()[rid];
                Regex regex = Rule.GetRegexList()[rid];

                if (regex.IsMatch(cache) && regex.Match(cache).Length == cache.Length)
                {
                    Token token = new Token();
                    token.Type = name;
                    token.Value = regex.Match(cache).Value;
                    token.IsChar = false;
                    list.Add(token);
                    cache = "";
                    break;
                }
            }
            
            if (Rule.GetCharList().ContainsKey(cache))
            {
                Token token = new Token();
                token.Type = Rule.GetCharList()[cache];
                token.Value = cache;
                token.IsChar = true;
                list.Add(token);
                cache = "";
                continue;
            }
            
            cache += charNow;
            // Console.WriteLine(charNow);
        }
        
        



        return list;
    }
    
    
    
    
}