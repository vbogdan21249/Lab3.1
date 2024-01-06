namespace BLL.Interfaces;

public interface ITeachBehaviour
{
    string Teach();
}

public class TeachAtUniversity : ITeachBehaviour
{
    public string Teach()
    {
        return " is teaching at university.";
    }
}

public class TeachAtHome : ITeachBehaviour
{
    public string Teach()
    {
        return " is teaching at home.";
    }
}

public class CantTeach : ITeachBehaviour
{
    public string Teach()
    {
        return " is not teaching.";
    }
}