using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
      [Route("/hello")]
      public string Hello2() { return "Hello friend!"; }

      [Route("/goodbye")]
      public string Goodbye() { return "Goodbye friend."; }

      [Route("/view")]
      public ActionResult Letter()
      {
        return View();
      }

      [Route("/journal")]
      public ActionResult Journal1()
      {
        return View();
      }

      [Route("/")]
      public ActionResult Hello()
      {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.SetRecipient("David");
        myLetterVariable.SetSender("Brian");
        return View(myLetterVariable);
      }

      [Route("/form")]
      public ActionResult Form()
      {
        return View();
      }

      [Route("/greeting_card")]
      public ActionResult GreetingCard()
      {
          LetterVariable myLetterVariable = new LetterVariable();
          myLetterVariable.SetRecipient(Request.Query["recipient"]);
          myLetterVariable.SetSender(Request.Query["sender"]);
          return View("Hello", myLetterVariable);
      }      

  }
}

// http://localhost:5000/home/hello
