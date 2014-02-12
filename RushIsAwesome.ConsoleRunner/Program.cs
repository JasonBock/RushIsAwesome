using System;
using System.Net.Http;

namespace RushIsAwesome.ConsoleRunner
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new HttpClient();
			var postResponse = client.GetAsync("http://rushisawesomedev.azurewebsites.net/api/trivia").Result;
			var result = postResponse.Content.ReadAsStringAsync().Result;
			Console.Out.WriteLine(result);
		}
	}
}
