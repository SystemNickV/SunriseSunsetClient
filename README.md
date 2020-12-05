# .NET Client for Sunrise Sunset API

[![telegram chat](https://img.shields.io/badge/Developer-Telegram-blue.svg?style=flat-square)](https://t.me/SystemNick) _// TODO add more shields_

**Sunrise Sunset Client** is the .NET Client for Sunrise Sunset API.

This API is an HTTP-based interface created for easier use of <https://sunrise-sunset.org/api>.

Check the _[original website]_ to understand what it is and what it can do.

## 🔨 Getting Started

Sunrise Sunset doesn't require any access token to use their API.

### Hello World

Create a new project or use existing one. It should be .NET 5 project.

```dotnet new console```

Add a reference to `SunriseSunsetClient` package.

```dotnet add package SunriseSunsetClient```

Open Program.cs file and use the following content. This code fetches information based on provided latitude and longitude.

```You can replace latitude, longitude and date with your own values```

```C#
using System;
using System.Threading.Tasks;
using SunriseSunsetClient.Types;

namespace MyFirstSunApp {
    class Program
    {
        static async Task Main(string[] args)
        {
            var location = new LocationData
            {
                Latitude = 1M,
                Longitude = 1M,
                Date = new DateTime(2020, 01, 01)
            };

            var client = new SunClient();

            var sun = await client.GetSunTimingsAsync(location);

            Console.WriteLine(sun);
        }
    }
}
```

Now you can run the program.

```dotnet run```

Output should look like this:

```log
Sunrise: 2020-01-01 09:18:20
Sunset: 2020-01-01 17:28:45
Solar noon: 2020-01-01 13:23:33
Day length: 08:10:25
Civil twilight start: 2020-01-01 08:40:19
Civil twilight end: 2020-01-01 18:06:46
Nautical twilight start: 2020-01-01 07:58:59
Nautical twilight end: 2020-01-01 18:48:06
Astronomical twilight start: 2020-01-01 07:19:41
Astronomical twilight end: 2020-01-01 19:27:24
```

Great! You've succesfully used Sunrise Sunset API. Check the properties of `SunTimings` to use them in your projects.

## 🚧 Supported Platforms

Project targets **.NET Standard 2.1** and **.NET 5** at minimum.

## ✅ Correctness & Testing

This project is not fully tested and needs further development. The API itself is not that complex, so you can easily undertand the code and use it or contribute to the repository.

## 🗂 References

- [Examples](https://github.com/SystemNickV/SunriseSunsetClient/tree/master/examples/)

[original website]: https://sunrise-sunset.org
