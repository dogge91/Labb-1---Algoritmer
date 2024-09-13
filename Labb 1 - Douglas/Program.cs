Console.WriteLine("Mata in valfri sträng av nummer, bokstäver och tecken");
string input = Console.ReadLine();
Console.Clear();

string printFirstPart = string.Empty;
string connectEqualNumbers = string.Empty;
string printRemainingPart = string.Empty;   

ulong sumOfNumbers = 0;

for (int i = 0; i < input.Length; i++)
{

    for (int j = i; j < input.Length; j++)
    {
        if (!char.IsDigit(input[j]))
        {
            connectEqualNumbers = string.Empty;
            break;
        }
        connectEqualNumbers += input[j];

        if (input[j] == connectEqualNumbers[0] && j != i)
        {

            printRemainingPart = input.Substring(j + 1);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(printFirstPart);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(connectEqualNumbers);
            sumOfNumbers += ulong.Parse(connectEqualNumbers);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(printRemainingPart);
            Console.ResetColor();
            Console.WriteLine();
            connectEqualNumbers = string.Empty;
            break;
        }

    }

    printFirstPart += input[i];
    connectEqualNumbers = string.Empty;

}
Console.WriteLine("*****************************");
Console.WriteLine($"\nTotal summa:  {sumOfNumbers}");





















