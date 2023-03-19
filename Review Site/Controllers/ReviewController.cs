using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Review_Site.Data;
using Review_Site.Models;

namespace Review_Site.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ReviewSiteContext _context;

        public ReviewController(ReviewSiteContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View(_context.Reviews.Include(r=>r.Destinations).ToList());
        }
        public ActionResult Create()
        {
            var review = new ReviewModel();
            review.DestinationList = DestList();
            return View(review);
        }
        [HttpPost]
        public ActionResult Create(ReviewModel reviews)
        {
            if (ModelState.IsValid)
            {
                _context.Reviews.Add(reviews);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reviews);
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var reviews = _context.Reviews.FirstOrDefault(
                g => g.Id == id);
            if (reviews == null)
            {
                return NotFound();
            }
            return View(reviews);
        }

        //the http delete method doesnt delete the specified game, it returns a view of the game wher you can submit the deletion
        [HttpPost]
        public ActionResult Delete(int? id, bool notUsed)
        {
            if (_context.Reviews == null)
            {
                return Problem("Entity set 'GameContext.BoardGames is null");
            }
            var reviews = _context.Reviews.Find(id);
            _context.Reviews.Remove(reviews);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var review = _context.Reviews.Where(r => r.Id == id).FirstOrDefault();
            review.DestinationList = DestList();
            return View(review);
        }
        [HttpPost]
        public ActionResult Edit(int id, ReviewModel review)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(review).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(review);
        }

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var review = _context.Reviews.Find(id);
            return View(review);
        }
        public List<SelectListItem> DestList()
        {
            var list = _context.Destinations.ToList();
            List<SelectListItem> retValue = list.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            return retValue;
        }
    } 

}