using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_first_homework.Entites
{
    public class Email
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public bool IsPrimary { get; set; }
        //relation
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
