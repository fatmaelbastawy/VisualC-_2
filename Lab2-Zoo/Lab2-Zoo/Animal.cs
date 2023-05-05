using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Zoo
{
    internal class Animal
    {
        public string Name { get; set; }
        public bool IsMammel { get; set; }
        public bool IsBird { get; set; }

    }



    class Lion: Animal
    {
        public Lion()
      { 
        Name="Lion";
        IsMammel = true;
        IsBird = false;
      }

    }


    class Sparrow : Animal
    {
        public Sparrow()
        {
            Name = "Sparrow";
            IsMammel = false;
            IsBird = true;
        }

    }


    class Elephant : Animal
    {
        public Elephant ()
        {
            Name = "Elephant";
            IsMammel = true;
            IsBird = false;
        }

    }


    class Pigeon : Animal
    {
        public Pigeon()
        {
            Name = "Pigeon";
            IsMammel = false;
            IsBird = true;
        }

    }
}   
