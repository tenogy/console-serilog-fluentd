using System;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace console
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var configuration = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json")
				.Build();

			var log = new LoggerConfiguration()
				.ReadFrom.Configuration(configuration)
				.CreateLogger();

			var position = new { Latitude = 25, Longitude = 134 };
			var elapsedMs = 34;
			log.Information("Processed {@Position} in {Elapsed:000} ms.", position, elapsedMs);
			Console.ReadKey();
		}
	}
}
