using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using System.ComponentModel.DataAnnotations;

namespace BookStoreWpf.Models
{
    public class User
    {
        public int id {  get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public List<Order> orders { get; set; }
        public Role role { get; set; }
    }
}
