using System;
using System.Web.Http;
using RushIsAwesome.Models;

namespace RushIsAwesome.Controllers
{
	public sealed class TriviaController
		: ApiController
	{
		private static readonly string[] content = new string[] 
		{
			"YYZ is the transmitter code for Toronto's Lester B. Pearson International Airport.",
			"The French lyrics in \"Circumstances\" mean \"The more that things change, the more they stay the same.\"",
			"The song \"Cinderalla Man\" is loosely based on a movie called \"Mr. Deeds Goes to Town\"",
			"\"Clockwork Angels\" was brought to you by the letter Œ"
		};

		public TriviaModel Get()
		{
			return new TriviaModel
			{
				Item = TriviaController.content[new Random().Next(TriviaController.content.Length)]
			};
		}
	}
}