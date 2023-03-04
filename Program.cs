using System.Text.RegularExpressions;

Console.WriteLine( GroupedBits(1000));
int GroupedBits(int n)
{
    if (n == 0) return 0;
    string res = "";
    while ((n) > 0)
    {
        res+= n%2==1?'1':'0';
        n /= 2;

    }
    return Regex.Split(res, "1+").Length;
}