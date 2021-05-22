using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW3.model
{
    class Course
    {
        private int courseid;
        private string coursename;

        public Course(int courseid, string coursename)
        {
            this.courseid = courseid;
            this.coursename = coursename;
        }

        public int CourseId
        {
            set
            {
                courseid = value;
            }
            get
            {
                return this.courseid;
            }

        }

        public String CourseName
        {
            set
            {
                coursename = value;
            }
            get
            {
                return this.coursename;
            }

        }

        public override string ToString()
        {
            return this.coursename;
        }
    }
}
