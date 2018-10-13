using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Cats
    {
        private string name;
        private string color;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
            }
        }

        //Constructor
        public Cats()
        {
            Console.Write("Cat's name: ");
            name = Console.ReadLine();
            Console.Write("Cat's color: ");
            color = Console.ReadLine();
            // Alternatively
           // this.name = "Puffy";
           // this.color = "white";
        }

        // constructor with parameters
        public Cats(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        // method
        public void SayMiauuuu()
        {
            Console.WriteLine("Cat {0} with color {1} said: Miauuuuu!", name, color);
        }
    }
}
