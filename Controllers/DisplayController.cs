using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Linq;
using PSST.Models;

namespace PSST.Controllers
{
  public class DisplayController : Controller
  {
    public readonly PSSTContext _db;

    public DisplayController(PSSTContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View();
    }
    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }
    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }
  }
}