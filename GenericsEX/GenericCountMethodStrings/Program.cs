namespace GenericCountMethodStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<double> list = new List<double>();
            
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }
            double valueToCompare = double.Parse(Console.ReadLine());

            Box<double> box = new(valueToCompare);

            Console.WriteLine(box.Count(list));
        }
    }
}
