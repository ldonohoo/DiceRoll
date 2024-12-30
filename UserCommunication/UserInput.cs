// diceroll game



namespace DiceRoll.UserCommunication;

using System.IO.Pipelines;

static class UserInput
{
    public static int ReadInteger(string message)
    {
        int result;
        do
        {
            Console.WriteLine(message);
        }
        while (!int.TryParse(Console.ReadLine(), out result));
        return result;
    }

}



