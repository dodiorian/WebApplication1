using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorsController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        //שולף את כל הנתונים מטבלת מוצרים
        [HttpGet]
        public List<Professors> GetAllProducts()
        {
            return db.Professors.Where(x => x.Status == true).ToList();
        }
        [HttpGet("ByProfessors")]
        public List<Professors> GetAllProductsByCategory(int Professors)
        {
            return db.Professors.Where(x => x.ProfessorId == Professors).ToList();
        }



        [HttpPost]

        public void AddProfessors(Professors professors)
        {
            db.Professors.Add(professors);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateProfessors(Professors c)
        {
            Professors c2 = db.Professors.FirstOrDefault(x => x.ProfessorId == c.ProfessorId);
            c2.FirstName = c.FirstName;
            c2.LastName = c.LastName;
            c2.Email = c.Email;
            c2.Phone = c.Phone;
            c2.Department = c.Department;
            c2.Status = c.Status;
            db.Professors.Update(c2);
            db.SaveChanges();
        }
        //מחיקה מהמאגר ע"י שינוי הסטטוס מאמת לשקר
        [HttpPut("deleteCourse")]
        public void DelProfessors(int id)
        {
            Professors c2 = db.Professors.FirstOrDefault(x => x.ProfessorId == id);
            c2.Status = false;
            db.Professors.Update(c2);
            db.SaveChanges();
        }

    }
}


