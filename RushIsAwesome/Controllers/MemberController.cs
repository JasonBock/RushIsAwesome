using System;
using System.Web.Mvc;
using RushIsAwesome.Models;

namespace RushIsAwesome.Controllers
{
	public sealed class MemberController : Controller
	{
		public ActionResult Index(int id)
		{
			return this.View(MemberController.GetModel(id));
		}

		private static MemberModel GetModel(int id)
		{
			if (id == 1)
			{
				// Neil Peart
				// http://en.wikipedia.org/wiki/Neil_peart
				return new MemberModel
				{
					Name = "Neil Peart",
					Description = "Neil Peart is a Canadian musician and author. He is the drummer and lyricist for the rock band Rush. Peart has received numerous awards for his musical performances, and is known for his technical proficiency and stamina.",
					Image = "~/Images/Neil.png"
				};
			}
			else if (id == 2)
			{
				// Geddy Lee
				// http://en.wikipedia.org/wiki/Geddy_Lee
				return new MemberModel
				{
					Name = "Geddy Lee",
					Description = "Geddy Lee is a Canadian musician and songwriter, best known as the lead vocalist, bassist, and keyboardist for the Canadian rock group Rush.",
					Image = "~/Images/Geddy.png"
				};
			}
			else if (id == 3)
			{
				// Alex Lifeson
				// http://en.wikipedia.org/wiki/Alex_Lifeson
				return new MemberModel
				{
					Name = "Alex Lifeson",
					Description = "Alex Lifeson is a Canadian musician, best known as the guitarist of the Canadian rock band Rush",
					Image = "~/Images/Alex.png"
				};
			}
			else
			{
				throw new NotSupportedException("There are only three members of Rush.");
			}
		}
	}
}