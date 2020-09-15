using CarSalesDemo.Models;
using CarSalesDemo.ViewModel;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace CarSalesDemo.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var vehicleTypes = _context.VehicleTypes.ToList();
            var viewModel = new VehicleFormViewModel 
            {
                VehicleTypes = vehicleTypes
            };

            return View(viewModel);
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