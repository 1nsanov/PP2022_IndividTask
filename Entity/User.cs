namespace Vitek
{
    public class User
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public int Age { get; set; }
        public List<Plain> Plains { get; set; } = new();
        public List<Hotels> Hotels { get; set; } = new();
    }
}
