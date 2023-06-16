Console.WriteLine("Please enter a number:");
int number = int.Parse(Console.ReadLine());

while (number <= 0)
{
    Console.WriteLine("Sorry,please enter a positive value.");
    number = Int32.Parse(Console.ReadLine());
}

Console.WriteLine("Please enter " + number + " words:");

string[] words = new string[number];

for (int n = 0; n < number; n++)
{
    Console.WriteLine($"Please enter word {n + 1}");
    string word = Console.ReadLine();

    while (word.Length < 1)
    {
        Console.WriteLine("Sorry,your word must have at least one character");
        word = Console.ReadLine();
    }

    words[n] = word;
}

Console.WriteLine("You enter these words:");
foreach (string s in words)
{
    Console.WriteLine(s);
};


Console.WriteLine("Please enter a character:");
char letter = char.Parse(Console.ReadLine());

if (char.IsLetter(letter))
{
    string joinedWords = string.Join("", words).ToLower();
    int count = 0;
    for (int i = 0; i < joinedWords.Length; i++)
    {
        if (joinedWords[i] == letter)
        {
            count++;
        }
    }
    if (count == 0)
    {
        Console.WriteLine("The letter you entered does not appear");
    }
    else
    {
        double per = Convert.ToDouble(count) / Convert.ToDouble(joinedWords.Length);

        if (per > 0.25)
        {
            Console.WriteLine("The letter " + letter + " appears " + count + " times in the array. This letter makes up more than 25 % of the total number of characters.");
        }
        else
        {
            Console.WriteLine("The letter " + letter + " appears " + count + " times in the array. This letter makes up less than 25 % of the total number of characters.");
        }
    }


}
else
{
    Console.WriteLine("Incorrect letter format entered,Please enter again:");
    letter = char.Parse(Console.ReadLine());
}
