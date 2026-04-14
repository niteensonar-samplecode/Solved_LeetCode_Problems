// See https://aka.ms/new-console-template for more information

Console.WriteLine("Program for finding the longest Palindromic Substring");
Console.WriteLine("------------------------------------------------------Click on X button close the window");
do
{
    Console.WriteLine("Enter the string value: ");
    string s = Console.ReadLine();

    int start = 0; int maxLength = 0;
    for (int i = 0; i < s.Length; i++)
    {
        chekcSubstring(s, i, i, ref start, ref maxLength);
        chekcSubstring(s, i, i + 1, ref start, ref maxLength);
    }
    Console.WriteLine("maxLength " + maxLength + " " + s.Substring(start, maxLength));

} while (true);


static void chekcSubstring(string s, int left, int right, ref int start, ref int maxLength)
{
    while (left >= 0 && right < s.Length && s[left] == s[right])
    {
        int len = right - left + 1;
        if (len > maxLength)
        {
            start = left;
            maxLength = len;
        }
        left--;
        right++;
    }
}