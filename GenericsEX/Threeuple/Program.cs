namespace Threeuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] dataAddressTown = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] nameBeerBoolData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] bankAccData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> filter = x => x == "drunk";

            Threeuple<string, string, string> addressTown = new($"{dataAddressTown[0]} {dataAddressTown[1]}", dataAddressTown[2], string.Join(' ', dataAddressTown[3..]));

            //TODO: boolean for drunk need condition
            Threeuple<string, int, bool> personDrunkOrNot = new(
                nameBeerBoolData[0], int.Parse(nameBeerBoolData[1]), filter(nameBeerBoolData[2]));

            Threeuple<string, double, string> bankAcc = new(bankAccData[0], double.Parse(bankAccData[1]), bankAccData[2]);


            Console.WriteLine(addressTown.ToString());
            Console.WriteLine(personDrunkOrNot.ToString());
            Console.WriteLine(bankAcc.ToString());
        }
    }
}
