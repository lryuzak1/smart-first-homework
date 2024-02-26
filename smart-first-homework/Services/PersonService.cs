using Microsoft.EntityFrameworkCore;
using smart_first_homework.Database;
using smart_first_homework.Entites;
using System;
using System.Collections.Generic;
using System.Linq;

namespace smart_first_homework.Services
{
    public class PersonService
    {
        private readonly MyContext _database;

        public PersonService(MyContext database)
        {
            _database = database;
        }
        public void AddPerson(Person person)
        {
            _database.Add(person);
            _database.SaveChanges();
        }
        public Person GetPerson(int id)
        {
            return _database.Persons.FirstOrDefault(x => x.Id == id) ?? throw new ArgumentNullException();
        }
        public Address GetAddress(int id)
        {
            return _database.Addresses.FirstOrDefault(x => x.Id == id) ?? throw new ArgumentNullException();
        }
        public Email GetEmail(int id)
        {
            return _database.Emails.FirstOrDefault(x => x.Id == id) ?? throw new ArgumentNullException();       
        }
        public void DeletePerson(int id)
        {
            _database.Persons.Remove(GetPerson(id));
            _database.SaveChanges();
        }
        public void UpdatePersonAddress(int personId, Address address)
        {
            //var resAddress = _database.Addresses.FirstOrDefault(x => x.PersonId == personId);
            //if (resAddress != null)
            //{
            //    resAddress = new Address { City = "sadas", Street = "Dadiani", Zipcode = "230" };
            //    _database.SaveChanges();
            //}
            var person = _database.Persons.Include(x => x.Address).FirstOrDefault(x => x.Id == personId);
            if (person != null)
            {
                person.Address.City = address.City;
                person.Address.Street = address.Street;
                person.Address.Zipcode = address.Zipcode;
                _database.SaveChanges();
                return;
            }
            throw new NullReferenceException();
        }
        public void DeletePersonPhoneNumbers(int personId)
        {
            _database.RemoveRange(_database.PhoneNumbers.Where(x => x.PersonId == personId));
            _database.SaveChanges();
        }
        public IEnumerable<Person> GetPersonsByStreet(string street) 
        {
            return _database.Persons.Where(x => x.Address.Street == street);          
        }
        public IEnumerable<Person> GetPersonsByEmail(string emailAddress) 
        {
            return _database.Persons.Where(x => x.Emails.Where(y => y.EmailAddress == emailAddress).Any()).ToList();
        }
        public IEnumerable<Person> GetPersons(string personName) 
        {
            return _database.Persons.Where(x => x.FirstName == personName);
        }
        public IEnumerable<Person> GetPersonsOfAge()
        {
            return _database.Persons.Where(x => x.Age > 18);
        }

    }
}
