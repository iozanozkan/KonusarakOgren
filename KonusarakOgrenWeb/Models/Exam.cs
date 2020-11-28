using System;
using System.Collections.Generic;

namespace KonusarakOgrenWeb.Models
{
    public class Exam
    {
        public Exam()
        {
            DateAdded = DateTime.Now;
            Questions = new List<Question>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DateAdded { get; set; }
        public List<Question> Questions { get; set; }
    }
}
