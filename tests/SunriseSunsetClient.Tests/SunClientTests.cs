using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using SunriseSunsetClient;
using SunriseSunsetClient.Types;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace SunriseSunsetClient.Tests
{
    public class SunClientTests
    {
        [Fact]
        public async Task GetSunTimingsAsync()
        {
            var location = new LocationData
            {
                Latitude = 1M,
                Longitude = 1M,
                Date = new DateTime(2020, 01, 01)
            };

            var client = new SunClient();

            var sun = await client.GetSunTimingsAsync(location);

            Assert.Equal(43442, sun.DayLengthInSeconds);
        }
    }
}
