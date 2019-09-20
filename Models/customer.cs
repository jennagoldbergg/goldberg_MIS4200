using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goldberg_MIS4200.Models
{
    public class customer
    {
        public int customerID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string fullName { get
            {
                return lastName + "," + firstName;
            }
        }
        public ICollection<order> orders { get; set; }

    }
}