using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CarSalesDemo.Models;
using CarSalesDemo.ViewModel;

namespace CarSalesDemo.Controllers
{
    public class CarsController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        public CarsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Cars
        public ActionResult Index()
        {
            //var bodyTypes = _context.BodyTypes.ToList();
            //var viewModel = new CarBodyTypeViewModel
            //{
            //    BodyTypes = bodyTypes
            //};
            //return View(viewModel);
            return View(_context.Cars.ToList());
        }

        // GET: Cars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = _context.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            var bodyTypes = _context.BodyTypes.ToList();
            var viewModel = new CarBodyTypeViewModel
            {
                BodyTypes = bodyTypes
            };
            return View(viewModel);
        }

        // POST: Cars/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NumberOfDoors,NumberOfWheels,BodyTypeId,VehicleTypeId,Make,Model,Engine")] Car car)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CarBodyTypeViewModel(car)
                {
                    BodyTypes = _context.BodyTypes.ToList()
                };
                return View("Create", viewModel);
            }

            if (car.Id == 0)
                _context.Cars.Add(car);
            else
            {
                var carInDb = _context.Cars.Single(model => model.Id == car.Id);

                carInDb.Make = car.Make;
                carInDb.Model = car.Model;
                carInDb.Engine = car.Engine;
                carInDb.BodyType = car.BodyType;
                carInDb.BodyTypeId = car.BodyTypeId;
                carInDb.NumberOfDoors = car.NumberOfDoors;
                carInDb.NumberOfWheels = car.NumberOfWheels;
            }
            _context.SaveChanges();

            var item = new CarBodyTypeViewModel(car);
            return RedirectToAction("Details", new { id = item.Id });

            //return RedirectToAction("Index");   
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = _context.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Cars/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NumberOfDoors,NumberOfWheels,BodyTypeId,VehicleTypeId,Make,Model,Engine")] Car car)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(car).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = _context.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = _context.Cars.Find(id);
            _context.Cars.Remove(car);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
