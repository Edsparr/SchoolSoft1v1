using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using SchoolSoft1v1.Schedules;

namespace SchoolSoft1v1
{
    public interface IFileHandler
    {

        bool TryLoadDay(string path, out DaySchedule schedule);

        void SaveDay(string path, DaySchedule schedule);

    }
    public class FileHandler : IFileHandler
    {
        public void SaveDay(string path, DaySchedule schedule)
        {
            var json = JsonConvert.SerializeObject(schedule);
            using(StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate)))
            {
                writer.Write(json);
            }
        }

        public bool TryLoadDay(string path, out DaySchedule schedule)
        {
            schedule = null;
            if (!File.Exists(path))
                return false;

            using(StreamReader reader = new StreamReader(path))
            {
                schedule = JsonConvert.DeserializeObject<DaySchedule>(reader.ReadToEnd());
                return true;
            }
        }
    }
}
