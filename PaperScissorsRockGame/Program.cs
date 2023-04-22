using System.ComponentModel.Design;
char answer, result;
bool alwaysRun = false;
int computerscore = 0;
int userscore = 0;

do
{
    char play;
    Console.WriteLine("WELCOME TO -PAPER -SCISSORS -ROCK CHOOSE ONE ENTER CHARACTER");
    Console.WriteLine("Please Enter Character");
    answer = char.Parse(Console.ReadLine().ToUpper());
    Random rnd = new Random();
    char[] array1 = { 'P', 'R', 'S' };
    int sayı = rnd.Next(0, 2);
    result = (array1[sayı]);
    if (answer == 'P' && result == 'R' || answer == 'R' && result == 'S' || answer == 'S' && result == 'P')
    {
        Console.Clear();
        Console.WriteLine("You Win");
        userscore = userscore + 1;
        Console.WriteLine("Do you wanna play one time Please enter Y or N");
        play = char.Parse(Console.ReadLine());
        if (play == 'Y')
        {

            Console.Clear();
            Console.WriteLine("Computer Scoreboard: " + computerscore + " User Scoreboard: " + userscore);
            alwaysRun = true;
        }
        else
        {
            alwaysRun = true;
        }

    }
    else if (answer == result)
    {
        Console.WriteLine("DRAW");
        alwaysRun = true;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("You Lost");
        computerscore = computerscore + 1;
        Console.WriteLine("Do you wanna play one time Please enter Y or N");
        play = char.Parse(Console.ReadLine());
        if (play == 'Y')
        {

            Console.Clear();
            Console.WriteLine("Computer Scoreboard: " + computerscore + " User Scoreboard: " + userscore);
            alwaysRun = true;
        }
        else
        {
            alwaysRun = true;
        }


    }



}
while (alwaysRun == true);
{

    Console.Clear();
    Console.WriteLine("Computer Scoreboard: " + computerscore + " User Scoreboard: " + userscore);
    Console.WriteLine("we will miss you very much.are u sure");


}



Console.ReadLine();
