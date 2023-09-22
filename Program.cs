 // BUild Dice Game
Console.WriteLine("_____Simple Dice Game_______ \nType'Start' or'S'to roll the dice:");
string startGame = Console.ReadLine()!;

if (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase)|| startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
{   
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Invalid keyword provided:");
    Console.ResetColor();
    Console.WriteLine("To stat this game enter Start");
    Console.ResetColor();
    startGame = Console.ReadLine()!;
    return;
}

Random rand = new Random();
int diceOne = rand.Next(1, 7);
int diceTwo = rand.Next(1, 7);
int diceThree = rand.Next(1, 7);
int originalScore = diceOne + diceTwo + diceThree;

const int  DOUBLE_POINT = 2;
const int TRIPLE_POINT = 6;
int totalPoint = originalScore;  

if (diceOne == diceTwo && diceTwo == diceThree)
{
    totalPoint += TRIPLE_POINT;

    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou rolled a triple! You have a total of{totalPoint} points");

}

if (diceOne == diceTwo || diceTwo == diceThree|| diceOne == diceThree)
{
    totalPoint += DOUBLE_POINT;

    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou rolled a double! You have a total of: {totalPoint} points");
    }
 if (diceOne == 10 || diceOne == 13 && diceTwo == diceOne && diceOne == diceThree)
{
    Console.WriteLine( "Congratulations! You won a reward of ballon!" );
}

if (totalPoint <= 14 || totalPoint <= 16)
{
    Console.WriteLine("Congratulations, You won an Excercise book.");

}
if (totalPoint == 17)

{
    Console.WriteLine("you won a POWERBANK");

}
if (totalPoint >= 18)

{
    Console.WriteLine("Congratulations, you just won a big Silverbed Concert!!");
}
if (totalPoint == 21)
{
    Console.WriteLine("Hey there! You just won Samsung A21 brand new phone");
}

if (totalPoint == 23)
{
    Console.WriteLine("You Won all Items");
}