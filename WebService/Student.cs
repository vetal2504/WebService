using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class Student
    {
        private int id;
        private string name;
        private DateTime date;
        public Student()
        {

        }

        public Student(int id, string name, DateTime date)
        {
            Id = id;
            Name = name;
            Date = date;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
    }
}