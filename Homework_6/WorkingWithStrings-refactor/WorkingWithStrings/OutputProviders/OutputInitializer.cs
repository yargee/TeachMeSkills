using System.Configuration;

namespace WorkingWithStrings.OutputProviders
{
    internal class OutputInitializer
    {
        private readonly string adressKey = "FileOutput";

        public IOutputProvider InitOutput()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                    return new ConsoleOutputProvider();
                }
                else
                {
                    foreach (var key in appSettings)
                    {
                        if (key.ToString() == adressKey)
                        {
                            var output = appSettings[adressKey];
                            return new FileOutputProvider(output);
                        }
                    }                    
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }

            return new ConsoleOutputProvider();
        }
    }
}
