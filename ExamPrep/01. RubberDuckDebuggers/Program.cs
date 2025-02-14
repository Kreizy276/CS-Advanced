namespace _01._RubberDuckDebuggers;

internal class Program
{
    static void Main(string[] args)
    {
        int[] time = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int[] tasks = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Queue<int> programmerTime = new(time);
        Stack<int> taskNumbers = new(tasks);

        Dictionary<string, int> duckCount = new()
        {
            ["Darth Vader Ducky"] = 0,
            ["Thor Ducky"] = 0,
            ["Big Blue Rubber Ducky"] = 0,
            ["Small Yellow Rubber Ducky"] = 0
        };


        while(programmerTime.Count != 0)
        {
            int currentTime = programmerTime.Dequeue();
            int currentTask = taskNumbers.Pop();

            int result = currentTime * currentTask;

            if (result <= 60) duckCount["Darth Vader Ducky"]++;
            else if (result > 61 && result <= 120) duckCount["Thor Ducky"]++;
            else if (result > 121 && result <= 180) duckCount["Big Blue Rubber Ducky"]++;
            else if (result > 181 && result <= 240) duckCount["Small Yellow Rubber Ducky"]++;
            else
            {
                currentTask -= 2;
                programmerTime.Enqueue(currentTime);
                taskNumbers.Push(currentTask);
            }
        }

        Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded: ");
        foreach(var element in duckCount)
        {
            Console.WriteLine($"{element.Key}: {element.Value}");
        }
    }
}
