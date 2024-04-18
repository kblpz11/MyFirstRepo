using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    class Square : Polygon
    {

        // ATTRIBUTES WITH GETTERS AND SETTERS
        public float Size { get; set; }

        // CONSTRUCTOR
        public Square(float size) 
        {
        
            Size = size; // Set value of atttribute to the value of the argument passed into the constructor
            NumberOfSides = 4; // Sets the value of the attribute that was inherited from the parent Polygon class
        } // end constructor


    } // end class

} // end namespace
