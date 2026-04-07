using DefaultNamespace;

namespace ConsoleApp11;

public class EventLog
{
    private IEnumerable<Ivent> _event = new List<Ivent>();
    
    IEnumerable<Ivent> KhronologicalOrder()
    {
        var sorted = _event.OrderBy(i => i.Number);
        foreach (var item in sorted)
        {
            Console.WriteLine($"Description: {item.Description} returned in sorted order");
            yield return item;
        }
    }
    
}