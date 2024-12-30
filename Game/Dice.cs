// diceroll game


namespace DiceRoll.Game;


public class Dice
{
    private Random _random;
    
    private const int NUMBER_OF_SIDES = 6;

    public Dice(Random random)
    {
       _random = random; 
    }
    
    public int RollDie()
    {
        return _random.Next(1, NUMBER_OF_SIDES + 1);
    }

    public string Describe()
    {
        return $"This is a die with {NUMBER_OF_SIDES} sides.";
    }

}

