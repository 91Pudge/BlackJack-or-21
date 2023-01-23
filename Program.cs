// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


const double initialMoney = 100.00;
int firstCardScore, secondCardScore, totalCardScore, thirdCardScore;
double playerMoney = initialMoney;
string favoriteCard = "Ace of Hearts";
int totalGamesPlayed = 0;
string playerNickName = "";
string? name = "Unnamed";
string playerSkillLevel = "Beginner";
string playerRole = "Player";
int age = 0;

Console.WriteLine("Please insert name and press enter?");
name = Console.ReadLine();


Console.WriteLine("Please insert age and press enter?");
age = int.Parse(Console.ReadLine());

Console.WriteLine("Please insert nickname and press enter?");
playerNickName = Console.ReadLine();


Console.WriteLine("Enter how many games played and press enter?");
totalGamesPlayed = int.Parse(Console.ReadLine());

if (playerNickName == "")
{
    playerNickName = "No nickname";

}

if (totalGamesPlayed < 50)
{
    playerSkillLevel = "Beginner";
}
else if (totalGamesPlayed < 100)
{
    playerSkillLevel = "Intermediate";
}
else if (totalGamesPlayed < 150)
{
    playerSkillLevel = "Master";
}
else
{
    playerSkillLevel = "Expert";
}



Console.WriteLine($"My name is  {name}   and the favorite card is  + {favoriteCard} and my age is {age}");
Console.Title = "BlackJackLight";
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(" . ------------.");
Console.WriteLine(" /------------/ |");
Console.WriteLine("/.-----------/| |");
Console.WriteLine("| ♥      ♥  | | |");
Console.WriteLine("| BlackJack | | |");
Console.WriteLine("|           | | |");
Console.WriteLine("|     ♥     | | |");
Console.WriteLine("|           | | |");
Console.WriteLine("| The Game  | | |");
Console.WriteLine("| ♥      ♥  | / /");
Console.WriteLine("\\ ----------/ ");
Console.WriteLine("");
Console.ResetColor();
Console.WriteLine("--------------------------------------------------");
Console.WriteLine($"| {playerSkillLevel} | {playerRole} | {name} {age}| {playerNickName} ");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("1. New Game");
Console.WriteLine("2. Reset Stats");
Console.WriteLine("3. Player Stats");
Console.WriteLine("4. Credits");
Console.WriteLine("5. Exit");



// Console.WriteLine("1. New game");
// Console.WriteLine("2. Continue");

Console.WriteLine("\nPlease type in menu option number and press enter");
string selectedMenuOption = Console.ReadLine();

switch (selectedMenuOption)
{
    case "1":
        Console.WriteLine("1");
        Console.WriteLine("Shuffling the deck...");
        Console.WriteLine("Shuffled the deck..");
        Console.WriteLine("Dealing the cards.");

        var randomGenerator = new Random();
        firstCardScore = randomGenerator.Next(1, 10);
        secondCardScore = randomGenerator.Next(1, 10);
        thirdCardScore = 0;
        int total = firstCardScore + secondCardScore;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Your first card score is: {firstCardScore}");
        Console.WriteLine($"Your second card score is: {secondCardScore}");
        Console.WriteLine($"Your total card score is: {total} ");
        Console.ResetColor();

        Console.WriteLine($"Would you like to get another card? \n1. Yes \n2. No");


        var shouldDeal = Console.ReadLine();

        if (shouldDeal == "1")
        {
            thirdCardScore = randomGenerator.Next(1, 10);
            Console.WriteLine($"Your third card score is: {thirdCardScore}");

        }

        totalCardScore = firstCardScore + secondCardScore + thirdCardScore;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Your total card score is {totalCardScore}");
        Console.ResetColor();

        if (totalCardScore > 21)
        {
            Console.WriteLine($"Over 21- Game over... \n Press any key to quit");
            Console.ReadKey();
            return;

        }

        var dealerCard1 = randomGenerator.Next(1, 10);
        var dealerCard2 = randomGenerator.Next(1, 10);
        var dealerThird = randomGenerator.Next(1, 10);
        int dealerHand = dealerCard1 + dealerCard2;
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine($"-Dealer 1st card is {dealerCard1}, dealer 2nd card is {dealerCard2}");
        Console.WriteLine($"-Dealer total {dealerHand}");

        Console.ResetColor();
        if (dealerHand < 15 || dealerHand > totalCardScore)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"-Dealer takes another card");
            Console.WriteLine($"The 3rd card is {dealerThird}");
            Console.ResetColor();

            dealerHand += dealerThird;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"-Dealer1 hand is {dealerHand}");
        Console.ResetColor();

        if (totalCardScore <= dealerHand)
        {
            Console.WriteLine($"-Dealer hand is {dealerHand}, Dealer wins... \n Press any key to quit");
            Console.ReadKey();
            return;
        }

        if (totalCardScore == 21)
        {
            Console.WriteLine("You won with 21");
        }


        if (dealerHand > 21 || dealerHand > total)
        {
            Console.WriteLine($"-Dealer hand is {dealerHand}, You won with {totalCardScore}... \n Press any key to quit");
            Console.ReadKey();
            return;
        }
        else if (dealerHand == totalCardScore)
        {
            Console.WriteLine($"Both players cards equal the same, Draw... \n Press any key to quit");
            Console.ReadKey();
        }

        if (totalCardScore > dealerHand && totalCardScore < 22)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Player{name} wins, your hand is {totalCardScore} \n Press any key to quit");
            Console.ResetColor();
            Console.ReadKey();
        }


        break;
    case "2":
        Console.WriteLine("-Are you sure you want to reset your stats? \n1. Yes \n2. No");
        string promptAnswer = Console.ReadLine();
        if (promptAnswer == "1" | promptAnswer == "Yes")
        {
            totalGamesPlayed = 0;
            playerMoney = initialMoney;
            playerSkillLevel = "Beginner";

            Console.WriteLine("Stats were reset");

        }
        break;
    case "3":
        Console.WriteLine($"Name: {name}");

        Console.WriteLine($"Intial Money: {initialMoney}");
        Console.WriteLine($"age: {age}");
        Console.WriteLine($"playerSkillLevel: {playerSkillLevel}");
        Console.WriteLine($"Games played: {totalGamesPlayed}");



        break;
}
