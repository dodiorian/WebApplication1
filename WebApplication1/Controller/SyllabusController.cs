using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SyllabusController : ControllerBase
    {
        MyDataContext db = new MyDataContext();

        [HttpGet]
        public List<Syllabus> GetAllProducts()
        {
            return db.Syllabus.Where(x => x.Status == true).ToList();
        }
        [HttpPost]
        public void AddSyllabus(Syllabus syllabus)
        {
            db.Syllabus.Add(syllabus);
            db.SaveChanges();



        }
        [HttpPut]
        public void UpdateSyllabus(Syllabus s)
        {
            Syllabus s2 = db.Syllabus.FirstOrDefault(x => x.SyllabusId == s.SyllabusId);
            s2.CourseId = s.CourseId;
            s2.LessonTopic = s.LessonTopic;
            s2.LessonCount = s.LessonCount;
            s2.Status = s.Status;
            db.Syllabus.Update(s2);
            db.SaveChanges();


        }
        //מחיקה מהמאגר ע"י שינוי הסטטוס מאמת לשקר
        [HttpPut("deleteSyllabus")]
        public void DelSyllabus(int id)
        {
            Syllabus s2 = db.Syllabus.FirstOrDefault(x => x.SyllabusId == id);
            s2.Status = false;
            db.Syllabus.Update(s2);
            db.SaveChanges();
        }
    }
}