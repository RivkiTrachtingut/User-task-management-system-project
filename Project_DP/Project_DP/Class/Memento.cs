using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DP.Class
{
    public class Memento
    {
        public Enum.Priority Priority { get; set; }
        public IStatus Status { get; set; }
        public User Reporter { get; set; }
    }
}

