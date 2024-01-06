using BLL.Interfaces;

namespace BLL.Entities;

public class Pilot : Person, IFlyBehaviour
{
    private IFlyBehaviour _flyBehaviour;
    
    public Pilot() {}
    public Pilot(string name, string gender) : base(name, gender)
    {
        _flyBehaviour = new FlyOnAnAirplane();
    }

    public string Fly()
    {
        return _flyBehaviour.Fly();
    }
    
    public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
    {
        _flyBehaviour = flyBehaviour;
    }
}