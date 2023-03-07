
Console.WriteLine(CountPower(new int[] { 4, 2, 0, 4, 4, 0 }, 4));
int CountPower(int[] arr, int k)
{
    long result = 0;
    Solve(arr, Convert.ToInt32(Math.Pow(2, k)), ref result);
    return (int)(result % 1000000007);
}
void Solve(int[] a, int k, ref long result)
{
    int[] arr = a.Where(x => x != -1).ToArray().Clone() as int[];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 0)
        {
            arr[i] = 2; Solve(arr, k, ref result);
            arr[i] = 4; Solve(arr, k, ref result);
            return;
        }
    }
    Console.Write(" "  );
    PrintArray(arr);

    for (int i = 0; i < arr.Length; i++)
    {
        if (i + 1 == arr.Length || arr[i] == -1) continue;
        //for (int j = i+1; j < arr.Length; j++)
            if (arr[i] != arr[i+1]) continue;
            arr[i+1] += arr[i];
            arr[i] = -1;
    PrintArray(arr);
            i = 0;
        break;

    }
    if (arr.Contains(-1)) Solve(arr, k, ref result);
    else
    {
        if (arr.Where(x => x >= k).Count() > 0) result++;
    }
    Console.WriteLine();
}

void PrintArray<T>(T[] arr)
{
    arr.ToList().ForEach(x => Console.Write(x + " "));
    Console.WriteLine();
}