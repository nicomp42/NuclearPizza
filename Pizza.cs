/***************************************************
 * Demonstrate an Interface 
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * Modified in class 10/31/2017 by nicholson
 * *************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuclearPizza {
    class Pizza {
        public int size { get; set; }
        public void Bake() {
            Console.WriteLine("Your pizza is baking");
        }
    }
}
