using JsonBugReport.Models;
using System;
using System.Text.Json;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace JsonBugReport
{
	class Program
	{
		static void Main(string[] args)
		{
			var session = new Session
			{
				SessionId = Guid.NewGuid(),
				Created = DateTime.UtcNow,
				Title = "Test"
			};

			var content = JsonContent.Create(session);
			Task<string> task = content.ReadAsStringAsync();
			task.Wait();
			var json = task.Result;

			Console.WriteLine("Serialised: ");
			Console.WriteLine(json);

			var deserialised = JsonSerializer.Deserialize<Session>(json);

			Console.WriteLine();
			Console.WriteLine("Deserialised: ");
			Console.WriteLine(JsonSerializer.Serialize(deserialised));
		}
	}
}
