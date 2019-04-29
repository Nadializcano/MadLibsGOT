using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/main")]
    public ActionResult Main() { return View(); }
    [Route("/form")]
    public ActionResult Form(){return View();}
    [Route("/story")]
    public ActionResult Story(string nameone, string nametwo, string namethree)
    {
      LibsVariable myLibsVariable = new LibsVariable();
      myLibsVariable.SetNameOne(nameone);
      myLibsVariable.SetNameTwo(nametwo);
      myLibsVariable.SetNameThree(namethree);
      // Console.WriteLine(myLibsVariable.GetNameOne());
      return View(myLibsVariable);
    }


  }
}
