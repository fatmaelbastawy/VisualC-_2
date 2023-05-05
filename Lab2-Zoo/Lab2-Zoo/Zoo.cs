using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Zoo
{
    internal class Zoo
    {
        public List<Animal> animals { get; set; }
        public IReadOnlyCollection<Animal> Birds
        {
            get
            {
                List<Animal> bird = new List<Animal>();
                foreach (Animal item in animals)
                {
                    if (item.IsBird == true)
                        bird.Add(item);
                }
                return bird;

                //get { return animals.Where(an => an.IsBird == true).ToList(); 
            }
        }

        public IReadOnlyCollection<Animal> Mammels
        {
            get { List<Animal> Mammels = new List<Animal>(); 
            List<Animal> mammel = new List<Animal>();
                foreach (Animal item in animals)
                {
                    if (item.IsMammel == true)
                        mammel.Add(item);
                }
                return mammel;
            //get { return animals.Where(an => an.IsMammel == true).ToList();
            }
        }
        public Zoo()
        {
            animals = new List<Animal>();
        }
        public void Add(Animal animal)
            
            
        {
            animals.Add(animal);
        }
    }
}
