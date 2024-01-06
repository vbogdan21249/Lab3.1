using BLL.Enums;

namespace BLL.Interfaces;

public interface IComposeBehaviour
{
    string Compose();
}

public class CanCompose : IComposeBehaviour
{
    public string Compose()
    {
        return " is composing.";
    }
}

public class CantCompose : IComposeBehaviour
{
    public string Compose()
    {
        return " can't compose.";
    }
}

public class ComposeOnInstrument(Instruments instrument) : IComposeBehaviour
{
    public string Compose()
    {
        return $" is composing on {instrument}.";
    }
}