

using HackerRank.WarmupChanllenges;
using HackerRank.JumpingontheClouds;
using HackerRank.RepeatedString;
using System.Text.RegularExpressions;

#region Counting Valleys
Console.WriteLine("Counting Valleys");
int valley = CountingValleys.countingValleys(10, "DUDDDUUDUU");
Console.WriteLine($"Total of Valleys {valley}");

#endregion

/*
Console.WriteLine("\n -------------------------------");
Console.WriteLine("Jumping on Clouds");
string path = "0 0 1 0 0 1 0";
string paath = path.Replace(" ", "");
//"0010010 expect 4";
List<int> clouds = new List<int>();
Console.WriteLine(paath);
foreach(char cloud in paath)
{
    clouds.Add(cloud - '0');
}

int jumps = jumpingOnClouds.jumpingOnTheClouds(clouds);

Console.WriteLine($"Jumps {jumps}");
Console.ReadKey();
*/

Console.WriteLine("\n -------------------------------");
Console.WriteLine("Repeated String");

string s = "cfimaakj";
long n = 554045874191;
var result = RepeatedString.repeatedString(s, n);
Console.WriteLine(result);
Console.ReadKey();