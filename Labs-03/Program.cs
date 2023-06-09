//1.We have a list of integers where elements appear either once or twice. Find the elements that appeared twice in O(n) time.
//example: { 1, 2, 3, 4, 7, 9, 2, 4}    returns{ 2, 4}

int[] ary = { 1, 2, 3, 4, 7, 9, 2, 4 };
HashSet<int> set = new HashSet<int>();
HashSet<int> result = new HashSet<int>();
foreach (int i in ary)
{
    if (!set.Add(i))
    {
        result.Add(i);
    }
}
Console.WriteLine(string.Join(",", result));


//2.We have two sorted int arrays which could be with different sizes. We need to merge them in a third array while keeping this result array sorted. Can you do that in O(n) time? Don't use any extra structures like Sets or Dictionaries
//example: { { 1, 2, 3, 4, 5}, { 2, 5, 7, 9, 13} }  returns{ 1, 2, 2, 3, 4, 5, 5, 7, 9, 13}

int[,] ary = new int[,] { { 1, 2, 3, 4, 5 }, { 2, 5, 7, 9, 13 } };
List<int> newList = new List<int>();

for (int i = 0; i < ary.GetLength(0); i++)
{
    for (int j = 0; j < ary.GetLength(1); j++)
    {
        newList.Add(ary[i, j]);

    }
}

for (int i = 0; i < newList.Count; i++)
{
    for (int j = i + 1; j < newList.Count; j++)
    {
        if (newList[i] > newList[j])
        {
            int temp = newList[i];
            newList[i] = newList[j];
            newList[j] = temp;
        }
    }
}

foreach (int c in newList)
{
    Console.Write(c + " ");
}
Console.WriteLine();


//3.Given an integer, reverse the digits of that integer, e. g. input is 3415, output is 5143.
//what is the time complexity of your solution?

Console.WriteLine("Please enter a number:");
string number = Console.ReadLine();
char[] ary = number.ToCharArray();
char[] newary = new char[ary.Length];
for (int i = 0; i < ary.Length; i++)
{
    newary[i] = ary[ary.Length - i - 1];
}
Console.Write("The reversed number is: ");
foreach (char c in newary)
{
    Console.Write(c);
}