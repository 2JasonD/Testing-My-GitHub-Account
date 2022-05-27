using Microsoft.AspNetCore.Mvc;
using Login_Form.Models;

namespace Login_Form.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)

            //Here w set up an if statement to verify is the logins used
            // are the correct ones

        {
            if(userModel.Username =="Jason" && userModel.Password =="jas123")
            {
                return View("LoginSuccess", userModel);
                // if that did not work, we use the else statement
                // and return another view called Loginfailure, saying to the user that
                // did not work that
            } else
            {
                return View("LoginFailure", userModel);
            }
        }

    }
}
