using CRUD_ASP.NET_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;

namespace CRUD_ASP.NET_.Controllers
{
	public class DeleteController : Controller
	{
		public IActionResult Index(User user)
		{
			using (var db = new Context())
			{
				db.Remove(user);
				db.SaveChanges();
			}
			return Redirect("/");
		}
	}
}
