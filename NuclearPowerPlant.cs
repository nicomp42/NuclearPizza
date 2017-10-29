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
    /// The Interface that will be implemented in the NuclearPizza class
    /// </summary>
    interface NuclearPowerPlant {
        /// <summary>
        /// The Kilowatt rating of the Nuclear Pizza.
        /// </summary>
        int Kw { get; set; }
        /// <summary>
        /// Try to shut down the Nuclear Pizza.
        /// </summary>
        /// <returns>True if the shutdown succeeded, false otherwise.</returns>
        bool EmergencyShutdown();
    }
}
