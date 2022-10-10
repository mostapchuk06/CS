//Task 3
string A = "";
string B = "";

Console.WriteLine($"A = {A}");
A = Console.ReadLine();
int AA = Convert.ToInt32(A);
Console.WriteLine($"A = " + AA);

Console.WriteLine($"B = {B}");
B = Console.ReadLine();
int BB = Convert.ToInt32(B);
Console.WriteLine($"B = " + BB);

if (AA < BB)
{
    for (int i = AA; i <= BB - AA; i++)
    {
        while (AA != BB + 1)
        {
            for (int j = 0; j <= AA - 1; j++)
            {
                Console.Write(AA + " ");
            }
            Console.WriteLine("");
            AA++;
        }
    }
}

//Task 1

Console.WriteLine("Enter characters,finish with a period \".\"");
char ch;
int spaces = 0;
do
{
    ch = (char)Console.Read();
    if (ch == ' ')
    {
        spaces++;
    }
} while (ch != '.');

Console.WriteLine("Number of spaces = {0}", spaces);

//Task 4
Console.WriteLine("Enter your number :: ");
string N = Console.ReadLine();
char[] input = N.ToCharArray();
Array.Reverse(input);
string output = new string(input);
Console.WriteLine(output);

//Task 2

//Console.Write("Enter ticket :: ");
//string str = Console.ReadLine();
//char[] ch = new char[str.Length];
//ch = str.ToCharArray();
//int[] ticket = ch.Select(s => int.Parse(s.ToString())).ToArray();
//if (ch.Length == 6)
//{
//    int left_n = 0;
//    int right_n = 0;

//    for (int i = 0; i < ch.Length; i++)
//    {
//        if (i < 3)
//        {
//            left_n += ticket[i];
//        }

//        else right_n  += ticket[i];
//    }
//    if (left_n == right_n)
//    {
//        Console.WriteLine("You have lucky ticket!!! :: {0} = {1}", left_n, right_n);
//    }
//    else 
//        Console.WriteLine("You have not lucky ticket :: {0} != {1}", left_n, right_n);
//}
//else Console.WriteLine("Incorect number");

Console.Read();