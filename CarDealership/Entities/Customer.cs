namespace CarDealership.Entities
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public Requirements Requirements { get; set; }
        public decimal Budget { get; set; }
    }
}