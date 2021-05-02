using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW2.model
{
    class Course
    {
        private int courseid;
        private String coursename;

        public Course(int courseid, String coursename)
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
