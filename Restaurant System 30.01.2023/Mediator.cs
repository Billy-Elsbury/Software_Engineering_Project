using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_System
{

    //ArrayList Currently non-functioning

    public class Mediator
    {
        public List<MenuItem> MenuItems { get; set; }

        public Mediator()
        {
            MenuItems = new List<MenuItem>();
        }
    }
}
