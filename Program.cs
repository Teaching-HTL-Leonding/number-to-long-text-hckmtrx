string input;
bool quit;
do
{
    Console.Write("Enter a number: ");
    input = Console.ReadLine()!.ToLower();
    quit = input == "q";
    bool inputIsValid = int.TryParse(input, out int number) || quit;

    if (!inputIsValid) { Console.WriteLine("Invalid input. Try again..."); }
    else if (!quit) { Console.WriteLine($"DigitIntoLongText: {DigitIntoLongText(number)}"); }
} while (!quit);

string DigitIntoLongText(int number)
{
    return number switch
    {
        0 => "zero",
        1 => "one",
        2 => "two",
        3 => "three",
        4 => "four",
        5 => "five",
        6 => "six",
        7 => "seven",
        8 => "eigth",
        9 => "nine",
        _ => "not a digit"
    };
}