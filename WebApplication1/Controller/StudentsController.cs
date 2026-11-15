using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        //שולף את כל הנתונים מטבלת מוצרים
        [HttpGet]
        public List<Students> GetAllProducts()
        {
            return db.Students.Where(x => x.Status == true).ToList();
        }
        [HttpPost]
        public void AddStudents(Students s1)
        {
            db.Students.Add(s1);
            db.SaveChanges();

        }
        [HttpPut]
        public void UpdateStudents(Students s)
        {
            Students s2 = db.Students.FirstOrDefault(x => x.CodeStudent == s.CodeStudent);
            s2.StudentId = s.StudentId;
            s2.FirstName = s.FirstName;
            s2.LastName = s.LastName;
            s2.Email = s.Email;
            s2.Phone = s.Phone;
            s2.Degree = s.Degree;
            s2.Status = s2.Status;
            db.Students.Update(s2);
            db.SaveChanges();

        }
        //מחיקה מהמאגר ע"י שינוי הסטטוס מאמת לשקר
        [HttpPut("deleteRegistation")]
        public void DelStudents(int id)
        {
            Students s2 = db.Students.FirstOrDefault(x => x.CodeStudent == id);
            s2.Status = false;
            db.Students.Update(s2);
            db.SaveChanges();
        }
    }
}
