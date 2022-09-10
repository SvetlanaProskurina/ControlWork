// Console.WriteLine("Hello, World!");

void PrintArray(string[] inputArray)
{

    int i = 0;
    while (i < inputArray.Length)
    {
        if (i < inputArray.Length && i != inputArray.Length - 1)
        {
            Console.Write($"{inputArray[i]} ,");
        }
        else Console.Write($"{inputArray[i]}");
        i++;
    }
}

string[] MassiveNew(string[] MassiveInput) //massive with string elements which have length less then 3
{
    int LengthMassiveOut = 0;

    for (int i = 0; i < MassiveInput.Length; i++)
    {
        if (MassiveInput[i].Length <= 3)
        {
            LengthMassiveOut++;
        }
    }

    string[] MassiveOutput = new string[LengthMassiveOut];
    int j = 0;

    for (int i = 0; i < MassiveInput.Length; i++)
    {
        if (MassiveInput[i].Length <= 3)
        {
            MassiveOutput[j] = MassiveInput[i];
            j++;
        }
    }

    return MassiveOutput;
}

//string [] MassiveInput = new string [] { "hello", "2", "word", ":-)" };
Console.WriteLine("введите массив из строк через запятую");
string input = Console.ReadLine();
string[] MassiveInput = input.Split(',');
Console.Write("Исходный массив: [");
PrintArray(MassiveInput);
Console.Write(" ]");
Console.WriteLine("");
Console.Write("Массив с элементами, длина которых меньше трёх: ");
Console.Write("[ ");
PrintArray(MassiveNew(MassiveInput));
Console.WriteLine(" ]");