namespace iJobsPlace.Entities.Common
{
    public class Address : Location
    {
        public int Id { get; set; }
        public int BuildingNumber { get; set; }
        public int Floor { get; set; }
        public string Street { get; set; }
        public City City { get; set; }
    }
}