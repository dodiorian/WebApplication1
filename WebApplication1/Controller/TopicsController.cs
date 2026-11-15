using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        //שולף את כל הנתונים מטבלת מוצרים
        [HttpGet]
        public List<Topics> GetAllProducts()
        {
            return db.Topics.Where(x => x.Status == true).ToList();
        }

        [HttpPost]

        public void AddTopics(Topics topics)
        {
            db.Topics.Add(topics);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateTopics(Topics t)
        {
            Topics t2 = db.Topics.FirstOrDefault(x => x.TopicId == t.TopicId);  
            t2.TopicName = t.TopicName;
            t2.Description = t.Description;
            t2.Status = t2.Status;
            db.Topics.Update(t2);
            db.SaveChanges();

        }
        //מחיקה מהמאגר ע"י שינוי הסטטוס מאמת לשקר
        [HttpPut("deleteTopics")]
        public void DelTopics(int id)
        {
            Topics t2 = db.Topics.FirstOrDefault(x => x.TopicId == id);
            t2.Status = false;
            db.Topics.Update(t2);
            db.SaveChanges();
        }
    }
}