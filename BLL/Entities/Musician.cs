using BLL.Enums;
using BLL.Interfaces;

namespace BLL.Entities;

public class Musician: Person, IComposeBehaviour
{
    private IComposeBehaviour _composeBehaviour;
    private Instruments _instrument;
    public Musician() {}
    public Musician(string name, string gender) : base(name, gender)
    {
        _composeBehaviour = new CantCompose();
    }
    
    public void SetInstrument(Instruments instrument)
    {
        _instrument = instrument;
        _composeBehaviour = new ComposeOnInstrument(instrument);
    }
    
    
    
    
    public string Compose()
    {
        return _composeBehaviour.Compose();
    }
    
}