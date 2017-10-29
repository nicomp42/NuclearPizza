/***************************************************
 * Demonstrate an Interface
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * *************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuclearPizza {
    /// <summary>
    /// Inherits from a base class and also implements an interface
    /// </summary>
    class NuclearPizza : Pizza, NuclearPowerPlant {
        public int Kw { get; set; }
        public bool EmergencyShutdown() {
            bool resultOfShutdownAttempt = false;
            // The shutdown will fail 1/2 the time. 
            if ((new Random()).Next() % 2 == 1) { resultOfShutdownAttempt = true; }

            return resultOfShutdownAttempt;
        }

    }
}
