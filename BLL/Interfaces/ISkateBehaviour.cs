namespace BLL.Interfaces;

public interface ISkateBehaviour
{
    string Skate();
}

public class CanSkate : ISkateBehaviour
{
    public string Skate()
    {
        return " is skating.";
    }
}


public class CantSkate : ISkateBehaviour
{
    public string Skate()
    {
        return " can't skate.";
    }
}