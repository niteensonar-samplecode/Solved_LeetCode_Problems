// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program for Reverse Integer");
Console.WriteLine("------------------------------------------------------Click on X button or press Ctrl + C close the window");
do
{
    Console.WriteLine("Enter the number: ");
    string? input = Console.ReadLine();

    if (!int.TryParse(input, out int x))
    {
        Console.WriteLine("Invalid integer. Please enter a valid 32-bit signed integer.");
        continue;
    }


    int resukt = Reverse(x);
    Console.WriteLine("Reverse number is: " + resukt);
} while (true);

int Reverse(int x)
{
    int result = 0;
    int carry = 0;

    while (x != 0)
    {
        carry = x % 10;
        x /= 10;
        if (result > int.MaxValue / 10)
        {
            return 0;
        }
        if (result < int.MinValue / 10)
        {
            return 0;
        }
        result = result * 10 + carry;
    }
    return result;
}