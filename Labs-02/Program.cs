//01.A program that produces an array of all of the characters
//that appear more than once in a string.

string str = "Programmatic Python";
HashSet<char> newStr = new HashSet<char>();
for (int i = 0; i < str.Length; i++)
{
    for (int j = i + 1; j < str.Length; j++)
    {
        if (str[i] == str[j])
        {
            newStr.Add(str[i]);
        }
    }
}
foreach (char item in newStr)
{
    Console.WriteLine(item);
}


//02.A program returns an array of strings that are unique words found in the argument.

string str = "To be or not to be";
string[] str2 = str.ToLower().Split(' ');

List<string> newStr = new List<string>();

foreach (string item in str2)
{
    if (newStr.Contains(item))
    {
        continue;

    }
    else
    {

        newStr.Add(item);
    }
}

foreach (string item in newStr)
{
    Console.Write(item + ' ');
}


//03.A program that reverses a provided string 

string str = "Programmatic";
char[] str2 = str.ToCharArray();
Array.Reverse(str2);
Console.WriteLine(new string(str2));


//04.A program that finds the longest unbroken word in a string and prints it.

string str = "Tiptoe through the tulips";
string[] ary = str.Split(' ');
string max = ary[0];
for (int i = 1; i < ary.Length; i++)
{
    max = Math.Max(max, ary[i], StringComparer.OrdinalIgnoreCase);
}
Console.WriteLine(max);