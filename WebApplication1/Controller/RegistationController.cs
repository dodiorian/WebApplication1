using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistationController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        //שולף את כל הנתונים מטבלת מוצרים
        [HttpGet]
        public List<Registation> GetAllProducts()
        {
            return db.Registation.Where(x => x.Status == true).ToList();

        }



        [HttpPost]
        public void AddRegistation(Registation registation)
        {
            db.Registation.Add(registation);
            db.SaveChanges();

        }
        [HttpPut]
        public void UpdateProduct(Registation r)
        {
            Registation r2 = db.Registation.FirstOrDefault(x => x.RegId == r.RegId);
            r2.StudentId = r.StudentId;
            r2.CourseId = r.CourseId;
            r2.RegDate = r.RegDate;
            r2.StatusReg = r2.StatusReg;
            r2.Status = r2.Status;
            db.Registation.Update(r2);
            db.SaveChanges();

        }
        //מחיקה מהמאגר ע"י שינוי הסטטוס מאמת לשקר
        [HttpPut("deleteRegistation")]
        public void DelRegistation(int id)
        {
            Registation r2 = db.Registation.FirstOrDefault(x => x.RegId == id);
            r2.Status = false;
            db.Registation.Update(r2);
            db.SaveChanges();
        }
    }
}

            
        
    


    


