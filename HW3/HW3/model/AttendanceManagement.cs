using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3.model
{
    class AttendanceManagement
    {
        public List<Course> courses;
        public List<Teacher> teachers;
        public List<Room> rooms;
        public List<Attendance> attendances;

        public AttendanceManagement()
        {
            courses = new List<Course>();
            teachers = new List<Teacher>();
            rooms = new List<Room>();
            attendances = new List<Attendance>();
        }

        public void addNewCourse(string name)
        {
            courses.Add(new Course(courses.Count + 1, name));
        }

        public List<Course> getCourses()
        {
            List<Course> temp;

            temp = courses.GetRange(0, courses.Count);

            temp.Add(new Course(0, "Add New Course"));

            return temp;
        }


        public void addNewRoom(string name)
        {
            rooms.Add(new Room(rooms.Count + 1, name));
        }

        public List<Room> getRooms()
        {
            List<Room> temp;

            temp = rooms.GetRange(0, rooms.Count);

            temp.Add(new Room(0, "Add New Room"));

            return temp;
        }


        public void addNewTeacher(string name)
        {
            teachers.Add(new Teacher(teachers.Count + 1, name));
        }

        public List<Teacher> getTeachers()
        {
            List<Teacher> temp;

            temp = teachers.GetRange(0, teachers.Count);

            temp.Add(new Teacher(0, "Add New Teacher"));

            return temp;
        }

        public void SaveAttendance(Teacher teacher, Course course, Room room, string date, string start_time, string leaving_time, string comment)
        {
            attendances.Insert(0, new Attendance(teacher, course, room, date, start_time, leaving_time, comment));
        }

        public List<Attendance> GetAttendances()
        {
            return this.attendances;
        }
    }
}
