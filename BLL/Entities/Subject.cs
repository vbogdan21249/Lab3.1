namespace BLL.Entities;

public class Subject
{
    public string Name { get; set; } = null!;
    public int Hours { get; set; }
    public Subject() {}
    public Subject(string name, int hours)
    {
        Name = name;
        Hours = hours;
    }
}