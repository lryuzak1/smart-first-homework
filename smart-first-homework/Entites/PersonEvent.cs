using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework.Entites
{
    public class PersonEvent
    {
        public int PersonId { get; set; }
        public int EventId { get; set; }
        public Person Person { get; set; }
        public Event Event { get; set; }
    }
}
