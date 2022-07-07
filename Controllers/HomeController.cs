using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app.Models;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        private readonly UniversityDbContext _db;
        public HomeController(UniversityDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            //return View(_db.Students.ToList());
            return View(_db.Students.Include(s => s.College).ToList());
        }

        public IActionResult insert()
        {
            ViewData["Clgs"] = new SelectList(_db.Colleges, "ClgID", "Clgname");
            return View();
        }

        [HttpPost]
        public IActionResult insert(Student student)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(student);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult insert2()
        {
            ViewData["Clgs"] = new SelectList(_db.Colleges, "ClgID", "Clgname");
            return View();
        }

        [HttpPost]
        public IActionResult insert2(StudentViewModel st)
        {
            if (ModelState.IsValid)
            {
                Student student = new Student()
                {
                    StudentID = st.StudentID,
                    Name = st.Name,
                    Surname = st.Surname,
                    City = st.City,
                    ClgID = st.ClgID,
                    GPA = st.GPA
                };

                if (st.Image != null)
                    student.ImageName = st.StudentID + Path.GetExtension(st.Image.FileName);
                else
                    student.ImageName = "DefaultImage.jpg";

                _db.Students.Add(student);
                _db.SaveChanges();
                if (st.Image?.Length > 0)
                {
                    string FilePath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot", "images", student.ImageName);
                    using (var stream = new FileStream(FilePath, FileMode.Create))
                    {
                        st.Image.CopyTo(stream);
                    }
                }

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
