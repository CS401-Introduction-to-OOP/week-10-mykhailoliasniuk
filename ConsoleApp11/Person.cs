namespace ConsoleApp11;

public class Person
{
    public string Name;
    public string Role;
    public int Level;
    public int Health;
    public double Gold;
    public Status status;

    public Person(string name, int health, double gold)
    {
        Name = name;
        Health = health;
        Gold = gold;
        status = Status.Active;
    }
    public enum Status
    {
        NonActive,
        Active
    }
}