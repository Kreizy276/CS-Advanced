namespace BoxOfStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Box<int> box = new(number);
                Console.WriteLine(box.ToString());

                //string word = Console.ReadLine();
                //Box<string> box = new(word);
                //Console.WriteLine(box.ToString());
            }
        }
    }
}
