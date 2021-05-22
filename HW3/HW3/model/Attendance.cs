using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3.model
{
    class Attendance
    {
        public string teacher { get; set; }
        public string course { get; set; }
        public string room { get; set; }
        public string date { get; set; }
        public string start_time { get; set; }
        public string leaving_time { get; set; }
        public string comment { get; set; }

        public Attendance(string teacher, string course, string room, string date, string start_time, string leaving_time, string comment)
        {
            this.teacher = teacher;
            this.course = course;
            this.room = room;
            this.date = date;
            this.start_time = start_time;
            this.leaving_time = leaving_time;
            this.comment = comment;
        }
    }
}
