using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_3
{
    public class Office
    {
        public int Id { get; set; }
        public string Ttitle { get; set; }
        public string Location { get; set; }
        public virtual List<Employee> Employees { get; set; } = new List<Employee>();
        public virtual Employee Employee { get; set; }
    }
}
