namespace DefaultNamespace;

public class Ivent
{
    public int Number;
    public string Description;
    public string Type;

    public Ivent(int number, string description, string type)
    {
        Number = number;
        Description = description;
        Type = type;
    }

    public void ChangeCharacterictics(int number, string description, string type)
    {
        Number = number;
        Description = description;
        Type = type;
    }
}