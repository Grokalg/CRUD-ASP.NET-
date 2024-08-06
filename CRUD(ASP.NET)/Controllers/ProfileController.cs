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
				var db_user = db.Users.Find(user.Id);
				return View(db_user);
			}	
		}

		public IActionResult Edit(User user)
		{
			using (var db = new Context())
			{
				var db_user = db.Users.Find(user.Id);
				return View(db_user);
			}
		}

		public IActionResult Check(User user)
		{
			if (ModelState.IsValid)
			{
				using (var db = new Context())
				{
					var db_user = db.Users.Find(user.Id);
					db_user.Name = user.Name;
					db_user.Email = user.Email;
					db_user.Password = user.Password;
					db.SaveChanges();
					return View("Index", user);
				}
			}
			return View("Edit");
		}
	}
}
