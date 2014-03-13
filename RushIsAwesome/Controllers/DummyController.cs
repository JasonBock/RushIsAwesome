using System.Web.Mvc;

namespace RushIsAwesome.Controllers
{
	public sealed class DummyController
		: Controller
	{
		public ActionResult Index()
		{
			return this.View();
		}
	}
}