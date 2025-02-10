using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<string, Action<int[]>> action = new Dictionary<string, Action<int[]>>
            {
                ["add"] = arr => Transform(arr, x => x + 1),
                ["multiply"] = arr => Transform(arr, x => x * 2),
                ["subtract"] = arr => Transform(arr, x => x - 1),
                ["print"] = arr => Console.WriteLine(string.Join(' ', arr))
            };*/

            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string command;
            while((command = Console.ReadLine()) != "end")
            {
                Action<int[]>? actionToInvoke = command switch
                {
                    "add" => arr => Transform(arr, x => x + 1),
                    "multiply" => arr => Transform(arr, x => x * 2),
                    "subtract" => arr => Transform(arr, x => x - 1),
                    "print" => arr => Console.WriteLine(string.Join(' ', arr)),
                    _ => null
                };
                if(actionToInvoke is not null) actionToInvoke(numbers);

                //actionToInvoke?.Invoke(numbers);


                //if (action.ContainsKey(command)) action[command](numbers);
            }
        }

        static void Transform(int[] numbers, Func<int, int> func)
        {
            for(int i = 0; i < numbers.Length; i++) numbers[i] = func(numbers[i]);
        }
    }
}
