using ConsoleApp11;

namespace ConsoleApp11;

public class EventLog
{
    private List<Ivent> _ivents = new List<Ivent>();
    private IEnumerable<Ivent> _event => _ivents;
    public void Add(Ivent ivent)
    {
        _ivents.Add(ivent);
    }
    public IEnumerable<Ivent> KhronologicalOrder()
    {
        var sorted = _event.OrderBy(i => i.Number);
        foreach (var item in sorted)
        {
            Console.WriteLine($"Description: {item.Description} returned in sorted order");
            yield return item;
        }
    }
    
}