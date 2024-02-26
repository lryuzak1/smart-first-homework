namespace smart_first_homework.Entites
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        //relation
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
