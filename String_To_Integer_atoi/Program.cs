// See https://aka.ms/new-console-template for more information

Console.WriteLine("Program for String to String to Integer (atoi)");
Console.WriteLine("------------------------------------------------------Click on X button close the window");
do
{
    Console.WriteLine("Enter the string value: ");
    string s = Console.ReadLine();
    int result = MyAtoi(s );
    Console.WriteLine("Result: " + result);
} while (true);



int MyAtoi(string s )
{
    bool fChar = true;
    bool isMinus = false;
    long retNum = 0;
    bool bFoundChar = false;

    foreach(char ch in s)
    {
        int a = ch;
        if (a == 32 && fChar)
            continue;

        if ((!((a >= 48 && a <= 57) || a == 43 || a == 45)) && fChar == true)
            return 0;

        if (a == 32 && bFoundChar == false)
            return 0;
        else if (a == 45 && fChar)
            isMinus = true;
        else if(a==43 && fChar)
        {
            fChar = false;
            continue;
        }
        else
        {
            if (ch >= 48 && ch <= 57)
            {
                bFoundChar = true;
                retNum = retNum * 10 + Convert.ToInt16(ch.ToString());

                if (!isMinus)
                {
                    if (retNum > int.MaxValue)
                    {
                        retNum = int.MaxValue;
                        break;
                    }
                }
                else
                {
                    if (retNum < int.MinValue)
                    {
                        retNum = int.MinValue;
                        retNum = Math.Abs(retNum);
                        break;
                    }
                }
            }
            else
                break;
        }
        fChar = false;
    }
    if (isMinus)
        retNum = retNum * -1;

    if (retNum > int.MaxValue)
        retNum = int.MaxValue;

    if (retNum < int.MinValue)
        retNum = int.MinValue;
    return (int)retNum;
}

