using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module2CodingChallenge
{
     class Polygon
    {
        // ATTRIBUTES WITH GETTERS AND SETTERS
        public int NumberOfSides {  get; set; }

        // CONSTRUCTORS
        public Polygon() 
        {
            NumberOfSides = 0;

        } // end constructor

        public Polygon(int numberOfSides) 
        { 
        
            NumberOfSides = numberOfSides;

        } // end constructor

    } // end class
} // end namespace
