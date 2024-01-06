namespace BLL.Entities;

public class MusicalInstrument
{
    public string Name { get; set; } = null!;
    public MusicalInstrument() {}
    public MusicalInstrument(string name)
    {
        Name = name;
    }
}