namespace CarService
{
    public class Service
    {
        public string User { get; set; }

        public string CarModel { get; set; }

        public string Description { get; set; }

        public float Cost { get; set; }

        public override string ToString()
        {
            return $"{User} {Description} {Cost}";
        }
    }
}
