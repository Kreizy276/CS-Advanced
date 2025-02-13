namespace Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] drinkingData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] intAndDouble = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);


            CustomTuple<string, string> nameAddress = new($"{personData[0]} {personData[1]}", personData[2]);

            CustomTuple<string, int> nameDrinking = new($"{drinkingData[0]}", int.Parse(drinkingData[1]));

            CustomTuple<int, double> intDouble = new(int.Parse(intAndDouble[0]), double.Parse(intAndDouble[1]));

            Console.WriteLine(nameAddress.ToString());
            Console.WriteLine(nameDrinking.ToString());
            Console.WriteLine(intDouble.ToString());
        }
    }
}
