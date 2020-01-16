using System;
using System.IO;
using System.Collections.Generic;

namespace SchoolSoft1v1
{
    class Program
    {
        static void Main(string[] args)
        {

            new ConsoleWorker().Start();
            ConsoleWorker.ins
            //if (ClassMananger.CurrentLessonSelect() == true)
            //{
            //    Lesson templesson = Lesson.MyList[LessonManager.CurrentLesson];
            //    Console.WriteLine(templesson.LessonName + " ends in " + (templesson.LessonEndTime - Time.CT));
            //}

        }
    }
}
