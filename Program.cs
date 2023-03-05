Console.WriteLine(ElectronicScreen("01110110010111110000010101111101"));
string ElectronicScreen(string s)
{
    Dictionary<string, int> dict = new()
    {
        { "00000101", 1 },
        { "01110110", 2 },
        { "01110101", 3 },
        { "00101101", 4 },
        { "01111001", 5 },
        { "01111011", 6 },
        { "01000101", 7 },
        { "01111111", 8 },
        { "01111101", 9 },
        { "01011111", 0 }
    };
    string res = "";
    for (int i = 0; i * 8 < s.Length; i++)
    {
        int j = i * 8;
        res += dict[s.Substring(j,  8)];
    }
    return res;
}