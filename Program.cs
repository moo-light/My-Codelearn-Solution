Console.WriteLine(FindNumber(438));
int FindNumber(int n)
{
    string s = n.ToString();
    if (s.Length <= 2) return n;
    bool tang = false;
    if (s[0] < s[1]) tang = true;
    while (true)
    {
        bool kt = true;
        s = n.ToString();
        int i = 0;
        for (i = 2; i < s.Length; i++)
        {
            if (s[i] == s[i - 1]) continue;
            if ((s[i - 1] < s[i]) != tang)
            {
                kt = !kt;
                break;
            }
        }
        if (kt) break;
        char[] chars = s.ToCharArray();
        if (tang)
        {
            if (chars[i - 2] >= chars[i-1]) chars[i - 1]++;
            for (i = i; i < s.Length; i++)
                chars[i] = chars[i - 1];
        }
        else
        {
            chars[i - 1]++;
            for (i = i; i < s.Length; i++) chars[i] = '0';
        }
        s = new string(chars);
        n = Convert.ToInt32(s);
    }
    return n;
}

