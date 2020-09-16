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
            ViewBag.Message = "Simple Vehicle Management Application";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}