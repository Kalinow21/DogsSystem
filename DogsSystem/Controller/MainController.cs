using DogsSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsSystem.Controller
{
    class MainController
    {
        public List<Dog> GetAllDogs()
        {
            using (DogsDBEntities1 db = new DogsDBEntities1())
            {
                return db.Dogs.ToList();
            }
        }
    }
}
