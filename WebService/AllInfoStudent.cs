using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class AllInfoStudent
    {
        private string address;
        private int telephone = 0;
        private string parents;
        private string number_tickets;
        public AllInfoStudent(string address, string parents, string number_tickets, int telephone)
        {
            Address = address;
            Parents = parents;
            Number_tickets = number_tickets;
            Telephone = telephone;
        }

        public string Address { get { return address; } set { address = value; } }
        public int Telephone { get { return telephone; } set { telephone = value; } }
        public string Parents { get { return parents; } set { parents = value; } }
        public string Number_tickets { get { return number_tickets; } set { number_tickets = value; } }
    }
}