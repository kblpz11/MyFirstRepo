using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    // CLASS DECLARATION
    internal class Player
    {
        // CREATING ATTRIBUTES (INSTANCE VARIABLES) THAT BELONG TO THE Player OBJECT
        private string name;

        private int score;

        private int livesLeft;

        private int stamina; // added new property stamina 

        // CONSTRUCTORS (GENERATES A NEW OBJECT)
       
        public Player(string name)
        {
            this.name = name;
        } // end method

        // OVERLOADING METHODS
        public Player(string name, int startingLives) 
        {
            this.name = name;
            
            livesLeft = startingLives;
        } // end method

        // OVERLOADING METHOD WITH STAMINA ADDED TO ITS SIGNATURE
        public Player (string name, int livesLeft, int stamina) 
        {
            this.name = name;
            this.livesLeft = livesLeft;
            this.stamina = stamina;
        
        } // end method


        // ADDING METHODS

        // returning the name of the player when the GetName() method is called
        public string GetName() 
        {

           return this.name = name;

        } //end method

        // returning the stamina of the player
        public int GetStamina() 
        { 
            return this.stamina; 
        
        } // end method

        public int GetScore() 
        { 
            return score; 
        
        } // end method

        public void AddPoints(int totalPoints) 
        { 
            score += totalPoints;

        }  // end method

        public void Kill() 
        {

            // Ensuring that we don't get negative lives
            if (livesLeft > 0) 
            {
                livesLeft--;
            }

        }  // end method

        public int GetLivesLeft() 
        {
        
            return livesLeft;

        }  // end method


    } // end class

   
} // end namespace
