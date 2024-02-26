using System;
using System.Collections.Generic;

namespace smart_first_homework.Entites
{
    public class Event
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        //relation
        public IEnumerable<Person> Persons { get; set; }
    }
}
