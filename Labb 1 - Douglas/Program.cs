Console.WriteLine("Mata in valfri sträng av nummer, bokstäver och tecken");
string input = Console.ReadLine();
Console.Clear();

string printFirstPart = string.Empty;
string findEqualNumbers = string.Empty;
string printRemainingPart = string.Empty;   

ulong sumOfNumbers = 0;

for (int i = 0; i < input.Length; i++)
{

    for (int j = i; j < input.Length; j++)
    {
        if (!char.IsDigit(input[j]))
        {
            findEqualNumbers = string.Empty;
            break;
        }
        findEqualNumbers += input[j];

        if (input[j] == findEqualNumbers[0] && j != i)
        {

            printRemainingPart = input.Substring(j + 1);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(printFirstPart);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(findEqualNumbers);
            sumOfNumbers += ulong.Parse(findEqualNumbers);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(printRemainingPart);
            Console.ResetColor();
            Console.WriteLine();
            findEqualNumbers = string.Empty;
            break;
        }

    }

    printFirstPart += input[i];
    findEqualNumbers = string.Empty;

}
Console.WriteLine("*****************************");
Console.WriteLine($"\nTotal summa:  {sumOfNumbers}");





















