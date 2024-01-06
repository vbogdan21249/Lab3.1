namespace BLL.Interfaces;

public interface IStudyBehaviour
{
    string Study();
}

public class StudyAtUniversity : IStudyBehaviour
{
    public string Study()
    {
        return " is studying at university.";
    }
}

public class StudyAtHome : IStudyBehaviour
{
    public string Study()
    {
        return " is studying at home.";
    }
}

public class CantStudy : IStudyBehaviour
{
    public string Study()
    {
        return " is not studying.";
    }
}