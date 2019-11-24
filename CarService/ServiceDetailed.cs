
namespace CarService
{
    public class ServiceDetailed
    {
        public User User { get; set; }

        public string Description { get; set; }

        public float Cost { get; set; }

        public override string ToString()
        {
            return $"{User} {Description} {Cost}";
        }
    }
}
