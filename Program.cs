
//Uppgift sten sax påse 2 players.
using UppgiftSSP;

//För att skapa player objects
Player firstName = new();
Player secondName = new();

bool game = true;
while (game)
{
        string Option = string.Empty;
    while (true)
    {
        //Welcome text
        Console.WriteLine("Welcome to Rock, Paper Scizzors!");
        Console.WriteLine("You will now have to choose from one of these options below.");
        Console.WriteLine("Please select 1 or 2 and then press enter to continue.\n\n");
        Console.WriteLine("          1. Player vs Bot.\n");
        Console.WriteLine("          2. Player vs Player.\n\n");
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


    foreach (int i in Enum.GetValues(typeof(Weapons)))
    {

        Console.WriteLine(i + 1);
    }



    //Player 1 enter name
    Console.WriteLine("Hello player 1, Please enter your name.");
    firstName.name = Console.ReadLine();
    Console.Clear();

    if (Option == "pvp")
    {
        Console.WriteLine("Hello " + firstName.name + ". Now please enter the name of player 2.");
        secondName.name = Console.ReadLine();
        Console.Clear();
    }

    Console.WriteLine();
    Console.Write("Hello " + firstName.name);
    //Player 2 enter name
    if (Option == "pvp")
    {
        Console.WriteLine(" and " + secondName.name + ".");
    }
    Console.WriteLine();
    Console.WriteLine("I hope you are prepared for a game of rock paper scissors!");
    Console.WriteLine("The rules are simple. Do not cheat!");
    Console.WriteLine("And may the best player of 3 rounds wins the game.");


    string? player1 = string.Empty;
    //Randomize who will begin the game. Player 1.

    if (Option == "pvp")
    {
        string?[] randomPlayer = { firstName.name, secondName.name };
        Random rnd = new();
        int index = rnd.Next(0, randomPlayer.Length);
        player1 = randomPlayer[index];
    }
    else
    {
        player1 = firstName.name;
    }

    //player 2.
    string? player2 = string.Empty;

    if (firstName.name == player1 && Option == "pvp")
    {
        player2 = secondName.name;
    }
    else if (firstName.name != player1 && Option == "pvp")
    {
        player2 = firstName.name;
    }
    else
    {
        player2 = "Bot2000";
    }

    Console.WriteLine();
    Console.WriteLine("Player 1. " + player1 + " starts the game.");
    Console.WriteLine("Player 2. " + player2 + " you will be up next.");
    Console.WriteLine();
    Console.WriteLine("Please press enter to continue.");
    Console.ReadLine();
    Console.Clear();

    while (Option == "pvp")
    {

        Console.WriteLine(player1 + " Please chose your weapon from below.");
        Console.WriteLine();
        Console.WriteLine("1. " + Weapons.Rock);
        Console.WriteLine("2. " + Weapons.Paper);
        Console.WriteLine("3. " + Weapons.Scissors);
        firstName.weapon = Console.ReadLine();
        Console.Clear();

        if (firstName.weapon != "1" && firstName.weapon != "2" && firstName.weapon != "3")
        {
            Console.Clear();
            Console.WriteLine("Sorry you didn't pick a correct weapon, try again!");
            Console.WriteLine();
            Console.WriteLine();
            continue;
        }

        while (firstName.weapon == "1" || firstName.weapon == "2" || firstName.weapon == "3")
        {
            Console.WriteLine(player2 + " Please chose your weapon from below.");
            Console.WriteLine();
            Console.WriteLine("1. " + Weapons.Rock);
            Console.WriteLine("2. " + Weapons.Paper);
            Console.WriteLine("3. " + Weapons.Scissors);
            secondName.weapon = Console.ReadLine();
            Console.Clear();

            if (secondName.weapon != "1" && secondName.weapon != "2" && secondName.weapon != "3")
            {
                Console.Clear();
                Console.WriteLine("Sorry you didn't pick a correct weapon, try again!");
                Console.WriteLine();
                Console.WriteLine();
                continue;
            }
            else
            {
                break;
            }
        }

        //No points if draw.
        if (firstName.weapon == secondName.weapon)
        {
            Console.WriteLine("Sorry this was a draw. No one was given any points.");
            Console.WriteLine("Try again, but this time try to win. ;) ");
            Console.WriteLine();
            Console.WriteLine(player1 + " Got " + firstName.point + " points.");
            Console.WriteLine(player2 + " Got " + secondName.point + " points.");
            Console.WriteLine();
        }

        //This gives player 1 points.
        else if (
            firstName.weapon == "1" && secondName.weapon == "3" ||
            firstName.weapon == "2" && secondName.weapon == "1" ||
            firstName.weapon == "3" && secondName.weapon == "2")
        {
            firstName.point++;
            Console.WriteLine("Good work " + player1 + "!");
            Console.WriteLine();
            Console.WriteLine(player1 + " Got " + firstName.point + " points.");
            Console.WriteLine(player2 + " Got " + secondName.point + " points.");
            Console.WriteLine();
            Console.WriteLine();
        }
        //This gives player 2 points.
        else
        {
            secondName.point++;
            Console.WriteLine("Good work " + player2 + "!");
            Console.WriteLine();
            Console.WriteLine(player1 + " Got " + firstName.point + " points.");
            Console.WriteLine(player2 + " Got " + secondName.point + " points.");
            Console.WriteLine();
            Console.WriteLine();
        }

        //End game if points reach the goal.
        if (firstName.point == 2 || secondName.point == 2)
        {
            Console.Clear();
            break;
        }

        //Reset weapon slots to be able to play again.
        firstName.weapon = string.Empty;
        secondName.weapon = string.Empty;
    }

    //PLAY vs a bot.
    while (Option == "pve")
    {

        Console.WriteLine(player1 + " Please chose your weapon from below.");
        Console.WriteLine();
        Console.WriteLine("1. " + Weapons.Rock);
        Console.WriteLine("2. " + Weapons.Paper);
        Console.WriteLine("3. " + Weapons.Scissors);
        firstName.weapon = Console.ReadLine();
        Console.Clear();

        if (firstName.weapon != "1" && firstName.weapon != "2" && firstName.weapon != "3")
        {
            Console.Clear();
            Console.WriteLine("Sorry you didn't pick a correct weapon, try again!");
            Console.WriteLine();
            Console.WriteLine();
            continue;
        }

        while (firstName.weapon == "1" || firstName.weapon == "2" || firstName.weapon == "3")
        {
            //BOT ska random välja vapen
            Random RND = new();
            int botChoice = RND.Next(1, 4);

            Console.WriteLine(player2 + " Please chose your weapon from below.");
            Console.WriteLine();
            Console.WriteLine("1. " + Weapons.Rock);
            Console.WriteLine("2. " + Weapons.Paper);
            Console.WriteLine("3. " + Weapons.Scissors);
            secondName.weapon = botChoice.ToString();
            Console.Clear();

            break;
        }

        //No points if draw.
        if (firstName.weapon == secondName.weapon)
        {
            Console.WriteLine("Sorry this was a draw. No one was given any points.");
            Console.WriteLine("Try again, but this time try to win. ;) ");
            Console.WriteLine();
            Console.WriteLine(player1 + " Got " + firstName.point + " points.");
            Console.WriteLine(player2 + " Got " + secondName.point + " points.");
            Console.WriteLine();
        }

        //This gives player 1 points.
        else if (
            firstName.weapon == "1" && secondName.weapon == "3" ||
            firstName.weapon == "2" && secondName.weapon == "1" ||
            firstName.weapon == "3" && secondName.weapon == "2")
        {
            firstName.point++;
            Console.WriteLine("Good work " + player1 + "!");
            Console.WriteLine();
            Console.WriteLine(player1 + " Got " + firstName.point + " points.");
            Console.WriteLine(player2 + " Got " + secondName.point + " points.");
            Console.WriteLine();
            Console.WriteLine();
        }
        //This gives player 2 points.
        else
        {
            secondName.point++;
            Console.WriteLine("Good work " + player2 + "!");
            Console.WriteLine();
            Console.WriteLine(player1 + " Got " + firstName.point + " points.");
            Console.WriteLine(player2 + " Got " + secondName.point + " points.");
            Console.WriteLine();
            Console.WriteLine();
        }

        //End game if points reach the goal.
        if (firstName.point == 2 || secondName.point == 2)
        {
            Console.Clear();
            break;
        }

        //Reset weapon slots to be able to play again.
        firstName.weapon = string.Empty;
        secondName.weapon = string.Empty;

    }

    while (true)
    {
        if (firstName.point == 2)
        {
            Console.WriteLine();
            Console.WriteLine("Congratulations you just won " + player1 + " The KING!");
        }

        if (secondName.point == 2)
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
            firstName.point = 0;
            secondName.point = 0;
            Console.Clear();
            break;
        }
        Console.Clear();
    }
}

Console.WriteLine();
Console.WriteLine("Thank you for playing this game.");
Console.WriteLine("Please subscribe or send me some cash");