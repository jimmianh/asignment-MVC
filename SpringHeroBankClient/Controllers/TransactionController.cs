using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpringHeroBankClient.ServiceReference1;

namespace SpringHeroBankClient.Controllers
{

    public class TransactionController : Controller
    {
      

        Service1Client service;

        public TransactionController()
        {
            service = new Service1Client();
        }

        public ActionResult Deposit()
        {
           

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DepositPost(String token, double Amount)
        {


            if (service.Deposit(token, Amount) == null)
            {
                return View("Failed");
            }
            else
            {
                return View("Success");
            }
        }

        public ActionResult Withdraw()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Withdraw(string token, double Amount)
        {

            if (service.Deposit(token, Amount) == null)
            {
                return View("Failed");
            }
            else
            {
                return View("Success");
            }
        }
        public ActionResult Transfer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Transfer(string receiverAccountNumber, double amount)
        {
            var service = new Service1Client();
            var token = Views.AccountController.staticToken;

            if (service.Transfer(token, receiverAccountNumber, amount))
            {
                ViewBag.Message = "Action success";
            }
            else
            {
                ViewBag.Message = "Action failed";
            }
            return View();
        }
    }
}