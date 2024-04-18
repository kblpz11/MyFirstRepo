using Module2CodingChallenge;
using System.Runtime.CompilerServices;

// CREATING A POLYGON OBJECT
Polygon polygon = new Polygon(3); // this is a triangle

// DISPLAYING THE TYPE OF POLYGON BASED ON THE NUMBER OF SIDES
Console.WriteLine($"This polygon has {polygon.NumberOfSides} sides. Therefore it is a triangle.");

// CREATING A SQUARE OBJECT
Square square = new Square(4.5f); // this is a square
// DISPLAYING THE TYPE OF POLYGON BASED ON THE NUMBER OF SIDES AND PRINTING ITS SIZE
Console.WriteLine($"This polygon has {square.NumberOfSides} sides. Therefore it is a square. Size: {square.Size} units.");

// CREATING A HEXAGON OBJECT
Polygon hexagon = new Polygon(6); // this is a hexagon
Console.WriteLine($"This polygon has {hexagon.NumberOfSides} sides. Therefore it is a hexagon.");

// CREATING A HEXAGON OBJECT
Polygon octagon = new Polygon(8); // this is an octagon
Console.WriteLine($"This polygon has {octagon.NumberOfSides} sides. Therefore it is a octagon.");

//CREATING A DECAGON OBJECT
Decagon decagon = new Decagon(10.0f); // this is a decagon

// GRABBING THE SIZE OF THE DECAGON AND DISPLAYING THE SIZE OF THE DECAGON
float decagonSize = decagon.Size;
Console.WriteLine($"The size of this decagon is {decagonSize} units. A decagon has {decagon.NumberOfSides} sides.");

// CHANGING THE SIZE OF THE DECAGON AND DISPLAYING NEW SIZE TO THE USER
decagon.Size = 20.5f; 
decagonSize = decagon.Size;
Console.WriteLine($"The decagon's new size is {decagonSize}");


// CREATING A NEW PLAYER
Player player = new Player("Frankie", 1);
string player1 = player.GetName(); // GETTING THE NAME 
player.AddPoints(100); // ADDING POINTS TO THE PLAYER


// DISPLAYING THE PLAYER'S CHARACTER NAME, SCORE AND LIVES LEFT 
Console.WriteLine("Welcome to the game " + player1 + "! " + "Your score is: " + player.GetScore() + 
    " You have " + player.GetLivesLeft() + " lives left!");

//KILL OFF THE PLAYER'S CHARACTER
player.Kill();

//LETTING THE PLAYER KNOW THAT THEIR CHARACTER WAS KILLED
Console.WriteLine("An orc attacks you " + player1 + ". Sorry, you were killed. You have " +
    player.GetLivesLeft() + " lives left!");

// CREATING A NEW PLAYER
Player player2 = new Player("Marcie", 3, 100);
string p2 = player2.GetName(); // GETTING THE NAME BASED ON THE OBJECT player2
int p2Stamina = player2.GetStamina(); // GETTING THE STAMINA BASED ON THE OBJECT player2
int p2LivesLeft = player2.GetLivesLeft(); // GETTING THE LIVES BASED ON THE OBJECT player2

// DISPLAYING THE PLAYER'S CHARACTER NAME, LIVES LEFT, AND STAMINA
Console.WriteLine($"Welcome to the game {p2}!" +
    $" Lives: {p2LivesLeft}. Stamina {p2Stamina} %");