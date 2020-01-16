using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSoft1v1.Commands
{
    public class CreateLessonCommand : CommandBase
    {
        public override string Name { get; } = "createlesson";

        public override string Execute(string args)
        {
            Console.WriteLine("Name of the lesson");
            string name = Console.ReadLine();
            Console.WriteLine("Hour of the lesson ending");

            if (!int.TryParse(Console.ReadLine(), out int endingHour) || endingHour > 24 || endingHour < 0)
                return "Hour is not a valid hour!";

            //ConsoleWorker.Instance.FileHandler.TryLoadDay(name)
            //Console.WriteLine("Succesfull!");
            return "succesfull";
        }
    }
}
