using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitek.Logic
{
    public class PlaneManager
    {
        public static string[] Cities = new [] {"Киев","Донецк","Харьков","Львов"};
        public static string[] Hotels = new [] { "Курортная", "Верховина", "Гуцулка"};
        public static User ?User { get; set; }

        public static void SelectPlane(Plain b)
        {
            switch (b.Town)
            {
                case "Киев":
                    b.Price = 500;
                    if (b.Vector == true) { b.Price += 250; }
                     CalculatedPlain(b);
                    break;
                case "Харьков":
                    b.Price = 400;
                    if (b.Vector == true) { b.Price += 200; }
                     CalculatedPlain(b);
                    break;
                case "Донецк":
                    b.Price = 350;
                    if (b.Vector == true) { b.Price += 200; }
                     CalculatedPlain(b);
                    break;
                case "Львов":
                    b.Price = 600;
                    if (b.Vector == true) { b.Price += 300; }
                     CalculatedPlain(b);
                    break;
                default:
                    MessageBox.Show("Такого города нет в списке рейсов");
                    break;
            }
        }
        private static void CalculatedPlain(Plain b)
        {
            b = CalculatedPlaneChecked(b);
            using (Bd db = new Bd())
            {
                var Pl = db.Users.OrderBy(z => z.Id == User.Id).First();
                Pl.Plains.Add(b);
                db.SaveChanges();
            }
        }
        public static decimal PlaneChecked(Plain b)
        {
            switch (b.Town)
            {
                case "Киев":
                    b.Price = 500;
                    if(b.Vector == true) { b.Price += 250; }
                    b = CalculatedPlaneChecked(b);
                    return b.Price;
                case "Харьков":
                    b.Price = 400;
                    if (b.Vector == true) { b.Price += 200; }
                    b = CalculatedPlaneChecked(b);
                    return b.Price;
                case "Донецк":
                    b.Price = 350;
                    if (b.Vector == true) { b.Price += 200; }
                    b = CalculatedPlaneChecked(b);
                    return b.Price;
                case "Львов":
                    b.Price = 600;
                    if (b.Vector == true) { b.Price += 300; }
                    b = CalculatedPlaneChecked(b);
                    return b.Price;
                default:
                    MessageBox.Show("Такого города нет в списке рейсов");
                    return 0;
            }
        }
        private static Plain CalculatedPlaneChecked(Plain b)
        {
            var Date = b.dateTime - DateTime.Now;
            if(Date.Days > 45)
            {
                b.Price = b.Price * 0.80m;
            }
            else if(Date.Days > 20)
            {
                b.Price = b.Price * 0.90m;
            }
            return b;
        }
    }
}
