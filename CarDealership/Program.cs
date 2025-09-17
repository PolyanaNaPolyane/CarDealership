using CarDealership.Forms;
using CarDealership.Utils;
using Microsoft.Extensions.Configuration;

namespace CarDealership
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();

            ConfigurationUtil.GeminiApiKey = configuration[nameof(ConfigurationUtil.GeminiApiKey)];

            ApplicationConfiguration.Initialize();
            Application.Run(new Cars());
        }
    }
}