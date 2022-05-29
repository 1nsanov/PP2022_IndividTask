using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitek
{
    public class Plain
    {
        public int Id { get; set; }
        public string ?Town { get; set; }
        public bool ?Vector { get; set; }
        public decimal Price { get; set; }
        public DateTime dateTime { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }

    }
}
