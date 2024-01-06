namespace BLL.Interfaces;

public interface IFlyBehaviour
{
    public string Fly();
}

public class FlyOnAnAirplane : IFlyBehaviour
{
    public string Fly()
    {
        return " is flying on an airplane.";
    }
}

public class FlyOnABroomstick : IFlyBehaviour
{
    public string Fly()
    {
        return " is flying on a broomstick.";
    }
}

public class CantFly : IFlyBehaviour
{
    public string Fly()
    {
        return " can't fly.";
    }
}
