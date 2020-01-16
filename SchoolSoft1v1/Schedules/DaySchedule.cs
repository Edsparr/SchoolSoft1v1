using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSoft1v1.Schedules
{
    public class DaySchedule
    {
        public DaySchedule() { }
        public DaySchedule(ICollection<Lesson> lessons)
        {
            this.Lessons = lessons;
        }

        public ICollection<Lesson> Lessons { get; }
    }
}
