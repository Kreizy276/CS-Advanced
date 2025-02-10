namespace _03._PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string[] chemicals = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach(string chemical in chemicals)
                {
                    set.Add(chemical);
                }
            }

            Console.WriteLine(string.Join(' ', set.OrderBy(n => n)));
        }
    }
}
