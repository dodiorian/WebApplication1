using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        //שולף את כל הנתונים מטבלת מוצרים
        [HttpGet]
        public List<Schedule> GetAllProducts()
        {
            return db.Schedule.Where(x => x.Status == true).ToList();
        }
        [HttpPost]
        public void AddSchedule(Schedule sch)
        {
            db.Schedule.Add(sch);
            db.SaveChanges();

        }
        [HttpPut]
        public void UpdateSchedule(Schedule s)
        {
            Schedule s2 = db.Schedule.FirstOrDefault(x => x.ScheduleId == s.ScheduleId);
            s2.CourseId = s.CourseId;
            s2.Day = s.Day;
            s2.StartTime = s.StartTime;
            s2.EndTime = s.EndTime;
            s2.Classroom = s2.Classroom;
            s2.Status = s2.Status;
            db.Schedule.Update(s2);
            db.SaveChanges();

        }
        //מחיקה מהמאגר ע"י שינוי הסטטוס מאמת לשקר
        [HttpPut("deleteSchedule")]
        public void DelSchedule(int id)
        {
            Schedule s2 = db.Schedule.FirstOrDefault(x => x.ScheduleId == id);
            s2.Status = false;
            db.Schedule.Update(s2);
            db.SaveChanges();
        }
    }
}
