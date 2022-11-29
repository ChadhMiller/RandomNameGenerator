Random r = new Random();
string[] Firstnames = new string[10] { "Tim", "June", "Bob", "Greg", "Wil", "Richard", "Eleanor", "Tori", "Leon", "Johnny" };
string[] Middlenames = new string[10] { " Lee", " Jean", " Hart", " Richard", " Carlyle", " Timothy", " Powell", " Palmer", " Diana", " Dawn" };
string[] Lastnames = new string[10] { " Wallace", " Price", " Singleton", " Allred", " Swain", " Tanner", " Womack", " Winterton", " Wheelwright", " Manning", };

int num = GetNum("How many random names do you want to generate?");

for (int x = 0; x < num; x++)
{
    int randNum1 = r.Next(0, 9);
    int randNum2 = r.Next(0, 9);
    int randNum3 = r.Next(0, 9);
    string Peoplesnames = Firstnames[randNum1] + Middlenames[randNum2] + Lastnames[randNum3];
    Console.WriteLine($" Name: {Peoplesnames}  ");
}

int GetNum(string prompt)
{
    Console.WriteLine(prompt);
    while (true)
    {
        try
        {
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        catch
        {
        }
        Console.WriteLine("Not a valid input try again!");
    }
}