namespace ProductInventoryProject.View
{
    internal class ConsoleOutputProvider : IOutputProvider
    {
        public void Write(string message)
        {
            Console.Write(message);
            Console.WriteLine();
        }
    }
}
