using BLL.Interfaces;

namespace BLL.Entities;

public abstract class Person : ISkateBehaviour
{
    public ISkateBehaviour _skateBehaviour = new CantSkate();
    public string Name { get; private set; } = null!;
    public string Gender { get; private set; } = null!;

    protected Person()
    {
    }

    protected Person(string name, string gender)
    {
        Name = name;
        Gender = gender;
    }

    public string Skate()
    {
        return _skateBehaviour.Skate();
    }
    public void SetSkateBehaviour(ISkateBehaviour skateBehaviour)
    {
        _skateBehaviour = skateBehaviour;
    }
}