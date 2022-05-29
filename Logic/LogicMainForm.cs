using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Vitek.Logic
{
    public class LogicMainForm
    {
        public static bool Register(User b)
        {
            using(Bd db = new Bd())
            {
                if (!db.Users.Any(u => u.Name == b.Name && u.Age == b.Age))
                {             
                    db.Users.Add(b);
                    db.SaveChanges();
                    return true;
                }
                else
                    MessageBox.Show($"Пользователь:{b.Name} возрастом:{b.Age} уже существует ");
                return false;
            }
        }
        public static bool Auth(User b)
        {
            using (Bd db = new Bd())
            {
                
                if (db.Users.Any(u => u.Name == b.Name && u.Age == b.Age))
                {
                    MessageBox.Show("Вы успешно авторезировались");
                    PlaneManager.User = b;
                    HotelManager.User = b;
                    return true;
                }
                else
                    MessageBox.Show($"Пользователя:{b.Name} возрастом:{b.Age} не существует");
                return false;
            }
        }
    }
}
