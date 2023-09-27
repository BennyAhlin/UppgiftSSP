
//Uppgift sten sax påse 2 players.
using System.Net.NetworkInformation;
using UppgiftSSP;

//För att skapa player objects
Player firstName = new Player();
Player secondName = new Player();
string Option = string.Empty;
string weapon1 = string.Empty;
string weapon2 = string.Empty;
int point1 = 0;
int point2 = 0;

bool game = true;
while (game)
{
    while (true)
    {
        //Welcome text
        Console.WriteLine("Welcome to Rock, Paper Scizzors!");
        Console.WriteLine("You will now have to choose from one of these options below.");
        Console.WriteLine("Please select 1 or 2 and then press enter to continue.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("          1. Player vs Bot.");
        Console.WriteLine();
        Console.WriteLine("          2. Player vs Player.");
        Console.WriteLine();
        Console.WriteLine();
        string? startOption = Console.ReadLine();
        Console.Clear();

        //Start option to play vs bot.
        if (startOption == "1")
        {

            Option = "pve";
            break;
        }
        //Start option player vs player.
        else if (startOption == "2")
        {

            Option = "pvp";
            break;
        }
        //faulty message.
        else
        {
            Console.WriteLine("Sorry this option is not a valid option.");
            Console.WriteLine("Please press enter and try again.");
            Console.ReadLine();
            Console.Clear();
            continue;
        }

    }


    //Player 1 enter name
    Console.WriteLine("Hello player 1, Please enter your name.");
    firstName.name = Console.ReadLine();
    Console.Clear();

    //Player 2 enter name
    Console.WriteLine("Hello " + firstName.name + ". Now please enter the name of player 2.");
    secondName.name = Console.ReadLine();
    Console.Clear();

    //randomize who starts!


    Console.WriteLine("Hello " + firstName.name + " and " + secondName.name + ".");
    Console.WriteLine();
    Console.WriteLine("I hope you are prepared for a game of rock paper scissors!");
    Console.WriteLine("The rules are simple. Do not cheat!");
    Console.WriteLine("And may the best player of 3 rounds wins the game.");

    //Randomize who will begin the game.
    string?[] randomPlayer = { firstName.name, secondName.name };
    Random rnd = new Random();
    int index = rnd.Next(0, randomPlayer.Length);
    string? player1 = randomPlayer[index];


    //player 2.
    string? player2 = string.Empty;

    if (firstName.name == player1)
    {
        player2 = secondName.name;
    }
    else
    {
        player2 = firstName.name;
    }

    Console.WriteLine("Player 1. " + player1 + " starts the game.");
    Console.WriteLine("Player 2. " + player2 + " you will be up next.");
    Console.WriteLine();
    Console.WriteLine("Please press enter to continue.");
    Console.ReadLine();
    Console.Clear();

    while (Option == "pvp")
    {





        //Randomized player får läggas i ny int så att man kan hålla koll på vems tur det är.
        //Console.WriteLine("The player " + player1 + " was randomized to start the game."); // lägg till random namn här

        Console.WriteLine(player1 + " Please chose your weapon from below.");
        Console.WriteLine();
        Console.WriteLine("1. " + Weapons.Rock);
        Console.WriteLine("2. " + Weapons.Paper);
        Console.WriteLine("3. " + Weapons.Scissors);
        weapon1 = Console.ReadLine();
        Console.Clear();

        if (weapon1 != "1" && weapon1 != "2" && weapon1 != "3")
        {
            Console.Clear();
            Console.WriteLine("Sorry you didn't pick a correct weapon, try again!");
            Console.WriteLine();
            Console.WriteLine();
        }

        while (weapon1 == "1" || weapon1 == "2" || weapon1 == "3")
        {
            Console.WriteLine(player2 + " Please chose your weapon from below.");
            Console.WriteLine();
            Console.WriteLine("1. " + Weapons.Rock);
            Console.WriteLine("2. " + Weapons.Paper);
            Console.WriteLine("3. " + Weapons.Scissors);
            weapon2 = Console.ReadLine();
            Console.Clear();

            if (weapon2 != "1" && weapon2 != "2" && weapon2 != "3")
            {
                Console.Clear();
                Console.WriteLine("Sorry you didn't pick a correct weapon, try again!");
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                break;
            }
        }

        //No points if draw.
        if (weapon1 == weapon2)
        {
            Console.WriteLine("Sorry this was a draw. No one was given any points.");
            Console.WriteLine("Try again, but this time try to win. ;) ");
            Console.WriteLine();
            Console.WriteLine(player1 + " Got " + point1 + " points.");
            Console.WriteLine(player2 + " Got " + point2 + " points.");
            Console.WriteLine();
        }

        //This gives player 1 points.
        else if (
            weapon1 == "1" && weapon2 == "3" ||
            weapon1 == "2" && weapon2 == "1" ||
            weapon1 == "3" && weapon2 == "2")
        {
            point1++;
            Console.WriteLine("Good work " + player1 + "!");
            Console.WriteLine();
            Console.WriteLine(player1 + " Got " + point1 + " points.");
            Console.WriteLine(player2 + " Got " + point2 + " points.");
            Console.WriteLine();
            Console.WriteLine();
        }
        //This gives player 2 points.
        else
        {
            point2++;
            Console.WriteLine("Good work " + player2 + "!");
            Console.WriteLine();
            Console.WriteLine(player1 + " Got " + point1 + " points.");
            Console.WriteLine(player2 + " Got " + point2 + " points.");
            Console.WriteLine();
            Console.WriteLine();
        }

        //End game if points reach the goal.
        if (point1 == 2 || point2 == 2)
        {
            Console.Clear();
            break;
        }


        //Reset weapon slots to be able to play again.
        weapon1 = string.Empty;
        weapon2 = string.Empty;


    }

    while (true)
    {
        if (point1 == 2)
        {
            Console.WriteLine();
            Console.WriteLine("Congratulations you just won " + player1 + " The KING!");
        }

        if (point2 == 2)
        {
            Console.WriteLine();
            Console.WriteLine("Congratulations you just won " + player2 + " The KING!");
        }


        //Play again???
        string? playAgain = string.Empty;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Do you wish to play again????");
        Console.WriteLine();
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. Exit");
        playAgain = Console.ReadLine();
        if (playAgain == "2")
        {
            game = false;
            break;
        }
        else if (playAgain == "1")
        {
            point1 = 0;
            point2 = 0;
            Console.Clear();
            break;
        }
        Console.Clear();
    }
}
Console.WriteLine();
Console.WriteLine("Thank you for playing this game. Please subscribe or send me cash :)");