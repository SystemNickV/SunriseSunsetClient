using System;
using System.Threading.Tasks;
using SunriseSunsetClient.Types;

namespace SunriseSunsetClient.Examples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(await GetLocalSunInfo(50M, 10M));
        }

        /// <summary>
        /// Get info about the specified location for today. Display time uses local time zone of the system.
        /// </summary>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="longitude">Longitude of the location.</param>
        /// <returns>String containing full formatted for console output info about the sun in the local time zone.</returns>
        private static async Task<string> GetLocalSunInfo(decimal latitude, decimal longitude)
        {
            var location = new LocationData
            {
                Latitude = latitude,
                Longitude = longitude,
                Date = new DateTime(2020, 01, 01)
            };

            var client = new SunClient();

            var sun = await client.GetSunTimingsAsync(location);

            sun.ChangeTimeZone(TimeZoneInfo.Local.Id);

            return $"Sunrise Sunset info for \"{TimeZoneInfo.Local.DisplayName}\" time zone:\n\n{sun}";
        }
    }
}
