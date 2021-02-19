using System;
using static System.Console;
using System.IO;
using JourneyCloudToDaybook.Library.Model;
using System.Text.Json;
using System.Linq;

namespace JourneyCloudToDaybook.ConsoleApp
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            // Read in sample json file.
            using var stream = File.OpenRead(@"example.json");
            var journeyCloud = await JsonSerializer.DeserializeAsync<JourneyCloud>(stream);
            DateTime entryDateTime = DateTimeOffset
                .FromUnixTimeMilliseconds(journeyCloud.DateJournal)
                .UtcDateTime;
            WriteLine(entryDateTime);
            WriteLine(journeyCloud.PreviewText);
            if(journeyCloud.Photos.Any())
            {
                foreach (var photo in journeyCloud.Photos)
                {
                    WriteLine($"Photo filename: {photo}.");
                }
            }
            else
            {
                WriteLine(@"No photos found.");
            }
        }
    }
}
