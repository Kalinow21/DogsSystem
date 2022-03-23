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
        //Read
        public List<Dog> GetAllDogs()
        {
            using (DogsDBEntities1 db = new DogsDBEntities1())
            {
                return db.Dogs.ToList();
            }
        }

        //CREATE - TEAM LEADER
        public void AddDog(Dog dog)
        {
            using (DogsDBEntities1 db = new DogsDBEntities1())
            {
                dog.Id = db.Dogs.ToList().LastOrDefault().Id + 1;
                db.Dogs.Add(dog);
                db.SaveChanges();
            }
        }

        public void UpdateDog(int id, Dog dog)
        {
            using (DogsDBEntities1 db = new DogsDBEntities1())
            {
                var dogToUpdate = db.Dogs.Where(g => g.Id == id).FirstOrDefault();
                if (dogToUpdate != null)
                {
                    dogToUpdate.Id = id;
                    dogToUpdate.Name = dog.Name;
                    dogToUpdate.Age = dog.Age;
                    db.SaveChanges();
                }
            }
        }


    }
}
