// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// https://www.youtube.com/watch?v=XokGEheMf5Y

public class Solution
{
  public int MinFlipsMonoIncr(string s)
  {
    var zeroCount = 0;
    var oneCount = 0;
    foreach (char c in s) if (c == '0') zeroCount++;
    int ans = zeroCount;
    foreach (char c in s)
    {
      if (c == '0') zeroCount--;
      else if (c == '1') oneCount++;
      ans = Math.Min(ans, zeroCount + oneCount);
    }
    return ans;
  }
}