using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        MyDataContext db = new MyDataContext();
        //שולף את כל הנתונים מטבלת מוצרים
        [HttpGet]
        public List<Course> GetAllProducts()
        {
            return db.Course.Where(x => x.Status == true).ToList();
        }
        [HttpGet("ByCourse")]
        public List<Course> GetAllProductsByCategory(string Course)
        {
            return db.Course.Where(x => x.CourseCode == Course).ToList();
        }


        [HttpPost]
        public void AddCourse(Course course)
        {
            db.Course.Add(course);
            db.SaveChanges();

        }
        [HttpPut]
        public void UpdateProduct(Course c)
        {
            Course c2 = db.Course.FirstOrDefault(x => x.CourseId == c.CourseId);
            c2.CourseName = c.CourseName;
            c2.CourseCode = c.CourseCode;
            c2.Credits = c.Credits;
            c2.TopicsId = c.TopicsId;
            c2.ProfessorsId = c.ProfessorsId;
            c2.Status = c.Status;
            db.Course.Update(c2);
            db.SaveChanges();


        }
        //מחיקה מהמאגר ע"י שינוי הסטטוס מאמת לשקר
        [HttpPut("deleteCourse")]
        public void DelCourse(string id)
        {
            Course c2 = db.Course.FirstOrDefault(x => x.CourseCode == id);
            c2.Status = false;
            db.Course.Update(c2);
            db.SaveChanges();
        }
       

    }
}






