using System.Collections.Concurrent;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Gamelist = new List<string>();

            Gamelist.Add("Mario");

            Gamelist.Add("Halo");

            Gamelist.Add("Fifa");

            Gamelist.Add("Fortnite");

            Gamelist.Add("GeoWars");

            var orderedByLength = Gamelist.OrderBy(x => x.Length);

            foreach(var item in orderedByLength)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
