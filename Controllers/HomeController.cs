using Microsoft.AspNetCore.Mvc;

namespace PSST.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}