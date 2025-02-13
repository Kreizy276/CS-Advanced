namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();

            int n = int.Parse(Console.ReadLine());

            // Box<int> box = new Box<int>();

            for(int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();
                list.Add(data);
                //box.List.Add(data);
            }

            int[] dataIndex = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int index1 = dataIndex[0], index2 = dataIndex[1];

            //box.Swap(index1, index2);
            Swap(index1, index2, list);
            foreach(string element in list) // in order if i use box class its "box.List"
            {
                //Console.WriteLine($"{box.ToString()}{element}");
                Console.WriteLine($"{element.GetType()}: {element}");
            }
        }
        public static void Swap<T>(int index1, int index2, List<T> list)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
