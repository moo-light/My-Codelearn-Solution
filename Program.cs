Console.WriteLine(ExtrapolateRanges("5,53,4,49,31,8,9,8,7,3,31,53"));
string ExtrapolateRanges(string str)
{
    var a = str.Split(',').Select(x => Convert.ToInt32(x)).Distinct().ToArray();

    for (int i = 0; i < a.Length - 1; i++)
        for (int j = i + 1; j < a.Length; j++)
        {
            if (a[j] < 0) return "undefined";
            if (a[i] > a[j])
            {
                var t = a[i]; a[i] = a[j]; a[j] = t;
            }
        }
    var res = "";
    for (int i = 0; i < a.Length; i++)
    {
        string @short = a[i].ToString();
        if (i + 1 < a.Length && a[i + 1] == a[i] + 1)
        {
            while (i + 1 < a.Length && a[i + 1] == a[i] + 1) i++;
            @short += "-" + a[i];
        }
        if (res == "") res = @short;else
        res = res + "," + @short;
    }
    return res;
}