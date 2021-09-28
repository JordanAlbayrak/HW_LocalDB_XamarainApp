using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HW_LocalDB_XamarainApp
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double CGPA { get; set; }

    }
}
