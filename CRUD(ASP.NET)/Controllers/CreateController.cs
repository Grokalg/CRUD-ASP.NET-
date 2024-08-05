using CRUD_ASP.NET_.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_ASP.NET_.Controllers
{
    public class CreateController : Controller
    {
		public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public Task<IActionResult> CheckAsync(User user)
		{
			if (ModelState.IsValid)
			{
				using (Context db = new Context())
				{
					db.Users.Add(user);
					db.SaveChanges();
				}
				return Task.FromResult<IActionResult>(Redirect("/"));
			}
			return Task.FromResult<IActionResult>(View("Index"));
		}
	}
}
