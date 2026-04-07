namespace ConsoleApp11;
using System;
using System.Collections.Generic;

class Party
{
    private List<Person> people = new List<Person>();
    private IEnumerable<Person> party => people;

    public void Add(Person person)
    {
        people.Add(person);
    }
    public IEnumerable<Person> ReturnAll()
    {
        foreach (var person in party)
        {
            Console.WriteLine($"Person: {person.Name} is returned from Party");
            yield return person;
        }
    }

    public IEnumerable<Person> ReturnActive()
    {
        foreach (var person in party)
        {
            if (person.status == Person.Status.Active)
            {
                Console.WriteLine($"Person: {person.Name} is active in party");
                yield return person;
            }
        }
    }

    public IEnumerable<Person> GetHigherHP(double hp)
    {
        var higherHp = party.Where(p => p.Health>hp);
        foreach (var person in higherHp)
        {
            Console.WriteLine($"Person: {person.Name} has {person.Health}HP");
            yield return person;
        }
    }

    public double MaxGold()
    {
        Console.WriteLine(party.Max(n => n.Gold));
        return  party.Max(n => n.Gold);
    }

    public IEnumerable<string> GetNames()
    {
        
        return party.Select(n => n.Name);
    }
}