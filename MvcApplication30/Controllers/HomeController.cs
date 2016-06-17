using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication30.Controllers
{
    //[LogTraffic]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }


    }

    public static class TrafficManager
    {
        public static void Log(string useragent)
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.ConStr))
            {
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Traffic (Useragent, DateTime) VALUES (" +
                                      "@ua, @d)";
                command.Parameters.AddWithValue("@ua", useragent);
                command.Parameters.AddWithValue("@d", DateTime.Now);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
