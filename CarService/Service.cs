namespace CarService
{
    public class Service
    {
        public string UserId { get; set; }

        public string Description { get; set; }

        public float Cost { get; set; }

        public override string ToString()
        {
            return $"{UserId} {Description} {Cost}";
        }
    }
}
