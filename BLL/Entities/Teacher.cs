using BLL.Interfaces;

namespace BLL.Entities;

public class Teacher : Person, ITeachBehaviour
{
    private ITeachBehaviour _teachBehaviour;
    List<Subject> _subjects;
    public Teacher() {}

    public Teacher(string name, string gender, Subject subject) : base(name, gender)
    {
        _teachBehaviour = new TeachAtUniversity();
    }
    
    public void SetTeachBehaviour(ITeachBehaviour teachBehaviour)
    {
        _teachBehaviour = teachBehaviour;
    }
    
    public void AddSubject(Subject subject)
    {
        _subjects.Add(subject);
    }
    
    public string Teach()
    {
        return _teachBehaviour.Teach();
    }
}

