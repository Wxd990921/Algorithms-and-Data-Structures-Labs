using System.Linq
// 1.List<int> MaxNumbersInLists(List<List<int>>) accepts as a parameter a List of Lists of Integers.
// It returns a new list with each element representing the maximum number found in the corresponding original list. 

List<int> aryList1 = new List<int> { 1, 5, 3 };
List<int> aryList2 = new List<int> { 9, 7, 3, -2 };
List<int> aryList3 = new List<int> { 2, 1, 2 };
List<List<int>> aryList4 = new List<List<int>> { aryList1, aryList2, aryList3 };

List<int> maxNumbersInLists(List<List<int>> p1)
{
    return p1.Select(list => list.Max()).ToList();
}

List<int> result = maxNumbersInLists(aryList4);
int count = result.Count;
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"List {i + 1} has a maximum of {result[i]}.");
}

// 2.String HighestGrade(List<List<int>>) accepts a list of number grades among students in different courses
// (where each list represents a single course),
// between 0 and 100. It returns the highest grade among all students in all courses.

List<int> highestGrade(List<List<int>> p2)
{
    List<int> result = new List<int>();
    foreach (var temp in p2)
    {
        result.Add(temp.Max());
    }
    return result;
}

List<List<int>> classGrade = new List<List<int>>
{
    new List<int> { 85, 92, 67, 94, 94 },
    new List<int> { 50, 60, 57, 95 },
    new List<int> { 95 }
};

Console.WriteLine($"The highest grade is {highestGrade(classGrade).Max()}");


// 3.List<int> OrderByLooping (List<int>) orders a list of integers, from least to greatest,
// using only basic control statements (ie. if/else, for/while).

List<int> OrderByLooping(List<int> p3)
{
    for (int i = 0; i < p3.Count; i++)
    {
        for (int j = i + 1; j < p3.Count; j++)
        {
            if (p3[i] > p3[j])
            {
                int temp = p3[i];
                p3[i] = p3[j];
                p3[j] = temp;
            }
        }
    }
    return p3;
}

List<int> orderByLooping = new List<int> { 6, -2, 5, 3 };
orderByLooping = OrderByLooping(orderByLooping);
Console.WriteLine(string.Join(",", orderByLooping));