// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program for finding the median of 2 array");
Console.WriteLine("------------------------------------------------------Click on X button close the window");
do
{
    Console.WriteLine("( 1st array ) Enter the numbers by space seperated like 12 23 343 45: ");
    int[] num1 = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

    Console.WriteLine("( 2nd array ) Enter the numbers by space seperated like 12 23 343 45: ");
    int[] num2 = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

    double result = findMedian(num1, num2);
    Console.WriteLine($"The median of the two arrays is: {result}");
} while (true);

double findMedian(int[] num1, int[] num2)
{
    int[] mergedArray = num1.Concat(num2).OrderBy(x => x).ToArray();
    
    int n = mergedArray.Length;
    if (n % 2 == 0)
    {
        return (mergedArray[n / 2 - 1] + mergedArray[n / 2]) / 2.0;
    }
    else
    {
        return mergedArray[n / 2];
    }
}

