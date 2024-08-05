using CRUD_ASP.NET_.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_ASP.NET_.Controllers
{
	public class ProfileController : Controller
	{
		public IActionResult Index(User user)
		{
			using (var db = new Context())
			{
				var user1 = db.Users.Find(user.Id);
				return View(user1);
			}	
		}

		public IActionResult Edit(User user)
		{
			using (var db = new Context())
			{
				var user1 = db.Users.Find(user.Id);
				return View(user1);
			}
		}
	}
}
