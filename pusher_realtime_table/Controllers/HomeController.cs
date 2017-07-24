using pusher_realtime_table.Models;
using System.Linq;
using System.Web.Mvc;
using PusherServer;
using System.Threading.Tasks;

namespace pusher_realtime_table.Controllers
{
    public class HomeController : Controller

    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(realtimetable data)
        {
            realtimetable setdata = new realtimetable();
            setdata.title = data.title;
            setdata.year = data.year;
            db.realtime.Add(setdata);
            db.SaveChanges();
            var options = new PusherOptions();
            options.Cluster = "XXX_APP_CLUSTER";
            var pusher = new Pusher("XXX_APP_ID", "XXX_APP_KEY", "XXX_APP_SECRET", options);
            ITriggerResult result = await pusher.TriggerAsync("asp_channel", "asp_event", data);
            return RedirectToAction("view", "Home");
        }

        public ActionResult seen()
        {
            return Json(db.realtime.ToArray(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult view()
        {
            return View();
        }

       
       
    }
}