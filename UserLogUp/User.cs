using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogUp
{
    public class User
    {
        //public string FName { get; set; }
        //public string LName { get; set; }
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Mail { get; set; }
        public string About { get; set; }
        public string Password { get; set; }
    }
}
