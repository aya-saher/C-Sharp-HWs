using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.models
{
    class Attendance
    {
        public string all()
        {
            return "SELECT room_name AS `Room`, course_name AS `Course`, teacher_name AS `Teacher`, attendance_date AS `Date`, satrt_time AS `Start At`, leaving_time AS `Leaving At`, comment FROM (((attendances INNER JOIN courses ON attendances.course_id = courses.course_id) INNER JOIN teachers ON attendances.teacher_id = teachers.teacher_id) INNER JOIN rooms ON attendances.room_id = rooms.room_id)";
        }

        public string insert(string teacher_id, string course_id, string room_id, string date, string start_at, string leaving_at, string comment)
        {
            string query = "INSERT INTO attendances(teacher_id, course_id, room_id, attendance_date, satrt_time, leaving_time, comment)";
            query += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", teacher_id, course_id, room_id, date, start_at, leaving_at, comment);
            return query;
        }
    }
}
