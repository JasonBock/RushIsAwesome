using System.Web.Mvc;

namespace RushIsAwesome.Controllers
{
	public sealed class HomeController
		: Controller
	{
		public ActionResult Index()
		{
			return this.View();
		}
	}
}