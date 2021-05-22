using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1.models
{
    class Employee
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string birth_date { get; set; }
        public string address { get; set; }

        public Employee(string id, string first_name, string last_name, string birth_date, string address)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.birth_date = birth_date;
            this.address = address;
        }
    }
}
