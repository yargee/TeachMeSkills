using Microsoft.Extensions.Configuration;
using ProductInventoryProject.View;

namespace ProductInventoryProject
{
    internal class OutputInitializer
    {
        public IOutputProvider GetProvider(IConfiguration config)
        {
            IOutputProvider provider = config["OutputInto"] switch
            {
                "Console" => new ConsoleOutputProvider(),
                "File" => new FileOutputProvider(config["OutputFilePath"]),
                _ => new ConsoleOutputProvider()
            };

            return provider;
        }
    }
}
