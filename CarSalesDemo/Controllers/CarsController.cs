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
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Cars
        public ActionResult Index()
        {
            return View(db.Cars.ToList());
        }

        // GET: Cars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        [HttpPost] 
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NumberOfDoors,NumberOfWheels,BodyTypeId,VehicleTypeId,Make,Model,Engine")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(car);
        }

        //// POST: Cars/Save
        //[HttpPost]
        //public ActionResult Save(Car car)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var viewModel = new VehicleFormViewModel()
        //        {
        //            MovieTypes = _context.MovieTypes.ToList()
        //        };
        //        return View("MovieForm", viewModel);
        //    }

        //    if (movie.Id == 0)
        //        _context.Movies.Add(movie);
        //    else
        //    {
        //        var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

        //        movieInDb.Name = movie.Name;
        //        movieInDb.MovieTypeId = movie.MovieTypeId;
        //        movieInDb.ReleaseDate = movie.ReleaseDate;
        //        movieInDb.MovieType = movie.MovieType;
        //        movieInDb.NumberInStock = movie.NumberInStock;
        //    }
        //    _context.SaveChanges();

        //    return RedirectToAction("Index", "Movies");
        //}

        // GET: Cars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
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
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
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
            Car car = db.Cars.Find(id);
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
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
