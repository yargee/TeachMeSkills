using Microsoft.Extensions.Configuration;
using ProductInventoryProject.View;

namespace ProductInventoryProject
{
    internal class OutputHandler
    {
        private IOutputProvider outputProvider;

        public void Initialize()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile(@"F:\TeachMeSkills\Homework_14(Async)\ProductInventoryProject\appsettings.json")
                .Build();

            IConfiguration outputconfig = configuration.GetSection("AppSettings");
                        
            outputProvider = GetProvider(outputconfig);
        }

        public void PrintResult(string result)
        {
            outputProvider.Write(result);
        }

        private IOutputProvider GetProvider(IConfiguration config)
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
