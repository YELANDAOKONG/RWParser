// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using RWLibrary;
using RWParser;

Console.WriteLine("Hello, World!");
Console.WriteLine(new Regex("^\".*\"$").Match("asdasd"));
Console.WriteLine(new Regex("^\".*\"$").Match("\"asd\""));
Console.WriteLine(new Regex("^\".*\"$").Match("\""));
Console.WriteLine(new Regex("^\".*\"$").Match("asd\""));
Console.WriteLine(new Regex("^\".*\"$").Match("\"asd\\\"wdfd\""));


string code = "\"Hi\"\n\"wdf\\\"wdf\"-;\"";



Lexer lexer = new Lexer(new RWMath());
List<Token> tokens = lexer.GetTokenList(code);
foreach (var token in tokens)
{
    Console.WriteLine(token.ToString());
}