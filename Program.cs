// diceroll game
using DiceRoll.Game;
using DiceRoll.UserCommunication;



// create new seed for app
using System.Runtime.InteropServices;

var random = new Random();

// create new dice for game
var dice = new Dice(random);

// create a new game
var guessingGame = new GuessingGame(dice);

// play the game!
var gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);


public class GuessingGame
{
    private readonly Dice _dice;
    private const int NUMBER_OF_GUESSES = 3;
    public GuessingGame(Dice dice)
    {
            _dice = dice;
    }

    public GameResult Play()
    {
        System.Console.WriteLine("Dice Roll Game!");
        System.Console.WriteLine(Environment.NewLine);
        System.Console.WriteLine($"You have {NUMBER_OF_GUESSES} chances to guess the roll!"); 
        var currentRoll = _dice.RollDie();
        int userGuess;
        int guessesUsed = 0;
        while (guessesUsed < NUMBER_OF_GUESSES)
        {
            System.Console.WriteLine("Enter Guess:");
            System.Console.WriteLine($"actual roll is {currentRoll}");
            userGuess = UserInput.ReadInteger("Enter a number:");
            if (userGuess == currentRoll)
            {
                return GameResult.Victory;
            }
            System.Console.WriteLine("Wrong guess!");
            guessesUsed++;
        }
        return GameResult.Loss;

    System.Console.WriteLine("You Lose :(");
    }

    public static void PrintResult(GameResult gameResult)
    {
        Console.WriteLine(gameResult == 
            GameResult.Victory ? "You Win" : "You lose!");
    }
  

}


