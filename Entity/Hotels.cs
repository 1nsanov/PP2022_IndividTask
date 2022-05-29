

namespace Vitek
{
    public class Hotels
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public byte Lvl { get; set; }
        public int Num { get; set; }
        public bool ?Variant { get; set; }
        public int Days { get; set; }
        public decimal AllPrice { get; set; }

        public int UserId { get; set; }
        public User ?User { get; set; } 
    }
}
