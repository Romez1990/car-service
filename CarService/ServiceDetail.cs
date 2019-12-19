using System;

namespace CarService
{
    public class ServiceDetail
    {
        public int Id { get; set; }

        public User User { get; set; }

        public string CarModel { get; set; }

        public string Description { get; set; }

        public float Cost { get; set; }

        public DateTime Datetime { get; set; }

        public override string ToString()
        {
            return $"{User} {Description} {Cost}";
        }
    }
}
