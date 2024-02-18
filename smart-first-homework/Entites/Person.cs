using System;
using System.Collections.Generic;

namespace smart_first_homework.Entites
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        //relation
        public Address Address { get; set; }
        public IEnumerable<PhoneNumber> PhoneNumbers { get; set; }
        public IEnumerable<Email> Emails { get; set; }
        public IEnumerable<Event> Events { get; set; }
    }
}
