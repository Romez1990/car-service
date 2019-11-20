namespace CarService
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{Id} {FirstName} {MiddleName} {LastName}";
        }
    }
}
