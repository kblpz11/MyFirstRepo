using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    class Decagon : Polygon
    {
        // ATTRIBUTES WITH GETTER AND SETTERS
        public float Size { get; set; }

        // CONTRUCTOR

        public Decagon (float size) 
        { 
        
            Size = size; // Set value of atttribute to the value of the argument passed into the constructor 
            NumberOfSides = 10; // Sets the value of the attribute that was inherited from the parent Polygon class

        } // end constructor


    } // end class

}// end namespace
