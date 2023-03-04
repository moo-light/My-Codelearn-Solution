Console.WriteLine(CodeForceRound277_A(Convert.ToInt64(Console.ReadLine())));
long CodeForceRound277_A(long n)
{
    long s = 0;
    //for(long i = 1; i <= n; i++)
    //{
    //    if (i % 2 == 1) s -= i;
    //    else s+= i;
    //    Console.WriteLine(s + " " +i) ;
    //}
    //return s;
    return n % 2 == 0 ? n / 2 : -(n + 1) / 2;
}