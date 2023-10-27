namespace RWLibrary;

public class Token
{
    public string Type = "";
    public string Value = "";

    public bool IsChar = false;

    
    public override string ToString()
    {
        return "{ " + Type + " , " + Value + " , " + IsChar + " }";
    }
}