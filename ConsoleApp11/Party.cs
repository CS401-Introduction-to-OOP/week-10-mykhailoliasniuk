namespace ConsoleApp11;
using System;
using System.Collections.Generic;

class Party
{
    private IEnumerable<Person> party = new List<Person>();

    IEnumerable<Person> ReturnAll()
    {
        foreach (var person in party)
        {
            Console.WriteLine($"Person: {person.Name} is returned from Party");
            yield return person;
        }
    }

    IEnumerable<Person> ReturnActive()
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

    IEnumerable<Person> GetHigherHP(double hp)
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
        return  party.Max(n => n.Gold);
    }

    IEnumerable<string> GetNames()
    {
        return party.Select(n => n.Name);
    }
}