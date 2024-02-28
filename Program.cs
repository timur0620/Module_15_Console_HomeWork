namespace Module_15_Console_HomeWork
{
    internal class Program
    {
        static int count = 0;
        static Random random = new Random();
        static void Main(string[] args)
        {
            Task[] tasks = new Task[100];

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = new Task(TaskConsole);

                tasks[i].Start();

                Thread.Sleep(random.Next(10, 100));
                tasks[i].Wait();

                tasks[i].Dispose();
            }
        }
        static void TaskConsole()
        {
            Console.WriteLine($"id -->{Thread.GetCurrentProcessorId()} | count {count++}");
        }
    }
}
