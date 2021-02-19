using static System.Console;
using System.IO;
using JourneyCloudToDaybook.Library.Model;
using System.Text.Json;

namespace JourneyCloudToDaybook.ConsoleApp
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            WriteLine("Hello World!");

            // Read in sample json file.
            using var stream = File.OpenRead(@"example.json");
            var journeyCloud = await JsonSerializer.DeserializeAsync<JourneyCloud>(stream);
            WriteLine(journeyCloud.Text);
        }
    }
}
