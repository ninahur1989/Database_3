using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_3
{
    public class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int login { get; set; }
        public int Password { get; set; }
        public int Id { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();

    }
}
