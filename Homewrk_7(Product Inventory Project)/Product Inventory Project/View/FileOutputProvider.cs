namespace ProductInventoryProject.View
{
    internal class FileOutputProvider : IOutputProvider
    {
        private string _path;

        public FileOutputProvider(string path)
        {
            _path = path;
        }

        public void Write(string message)
        {
            File.WriteAllText(_path, message);
        }
    }
}
