using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string job, string name, string motto)
        {

            List<Models.project> list = new List<Models.project>();
            var item = new Models.project();

            item.job = "組長";
            item.name = "李文正";
            item.motto = "191";

            list.Add(item);

            var item2 = new Models.project();

            item2.job = "組員";
            item2.name = "紀鈞哲";
            item2.motto = "亞軍哲";
            list.Add(item2);
            ViewBag.ListDatas = list;

            var item3 = new Models.project();

            item3.job = "組員";
            item3.name = "林品叡";
            item3.motto = "麗寶叡";
            list.Add(item3);
            ViewBag.ListDatas = list;

            var item4 = new Models.project();

            item4.job = "組員";
            item4.name = "陳聖昀";
            item4.motto = "中國昀";
            list.Add(item4);
            ViewBag.ListDatas = list;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}