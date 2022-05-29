using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitek.Logic
{
    public class HotelManager
    {
        public static User ?User { get; set; }
        public static decimal HotelCheked(Hotels s)
        {
            switch (s.Name)
            {
                case "Курортная":
                    switch (s.Num)
                    {
                        case 1:                            
                              if (s.Variant == true) { s.AllPrice = 1500 * s.Days; }
                              else if(s.Variant == false) { s.AllPrice = 1000 * s.Days; }                           
                            break;
                        case 2:
                              if (s.Variant == true) { s.AllPrice = 2500 * s.Days; }
                              else if (s.Variant == false) { s.AllPrice = 1500 * s.Days; }
                            break;
                    }
                    return s.AllPrice;
                case "Верховина":
                    switch(s.Num)
                    {
                        case 1:
                            if (s.Variant == true) { s.AllPrice = 900 * s.Days; }
                            else if (s.Variant == false) { s.AllPrice = 600 * s.Days; }
                            break;
                        case 2:
                            if (s.Variant == true) { s.AllPrice = 1500 * s.Days; }
                            else if (s.Variant == false) { s.AllPrice = 900 * s.Days; }
                            break;
                    }
                    return s.AllPrice;
                case "Гуцулка":
                    switch (s.Num)
                    {
                        case 1:
                            if (s.Variant == true) { s.AllPrice = 500 * s.Days; }
                            else if (s.Variant == false) { s.AllPrice = 300 * s.Days; }
                            break;
                        case 2:
                            if (s.Variant == true) { s.AllPrice = 800 * s.Days; }
                            else if (s.Variant == false) { s.AllPrice = 450 * s.Days; }
                            break;
                    }
                    return s.AllPrice;
                    default:
                    MessageBox.Show("Такой гостинницы нет");
                    return 0;

            }
        }
        public static void CreateHotel(Hotels s)
        {
            switch (s.Name)
            {
                case "Курортная":
                    switch (s.Num)
                    {
                        case 1:
                            if (s.Variant == true) { s.AllPrice = 1500 * s.Days; }
                            else if (s.Variant == false) { s.AllPrice = 1000 * s.Days; }
                            Inserter(s);
                            break;
                        case 2:
                            if (s.Variant == true) { s.AllPrice = 2500 * s.Days; }
                            else if (s.Variant == false) { s.AllPrice = 1500 * s.Days; }
                            Inserter(s);
                            break;
                    }
                    break;
                case "Верховина":
                    switch (s.Num)
                    {
                        case 1:
                            if (s.Variant == true) { s.AllPrice = 900 * s.Days; }
                            else if (s.Variant == false) { s.AllPrice = 600 * s.Days; }
                            Inserter(s);
                            break;
                        case 2:
                            if (s.Variant == true) { s.AllPrice = 1500 * s.Days; }
                            else if (s.Variant == false) { s.AllPrice = 900 * s.Days; }
                            Inserter(s);
                            break;
                    }
                    break;
                case "Гуцулка":
                    switch (s.Num)
                    {
                        case 1:
                            if (s.Variant == true) { s.AllPrice = 500 * s.Days; }
                            else if (s.Variant == false) { s.AllPrice = 300 * s.Days; }
                            Inserter(s);
                            break;
                        case 2:
                            if (s.Variant == true) { s.AllPrice = 800 * s.Days; }
                            else if (s.Variant == false) { s.AllPrice = 450 * s.Days; }
                            Inserter(s);
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("Такой гостинницы нет");
                    break;

            }
        }
        private static void Inserter(Hotels s)
        {
            using(Bd db = new Bd())
            {
                var Hot = db.Users.OrderBy(z => z.Id == User.Id).First();
                Hot.Hotels.Add(s);
                db.SaveChanges();
            }
        }

    }
}
