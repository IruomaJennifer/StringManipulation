// See https://aka.ms/new-console-template for more information

string text = "Starlight is the light emitted by stars.[1] " +
    "It typically refers to visible electromagnetic radiation from stars other than the Sun," +
    " observable from Earth at night, although a component of starlight is observable from Earth " +
    "during daytime.Sunlight is the term used for the Sun's starlight observed during daytime.[2] During nighttime, albedo describes solar reflections from other Solar System objects, " +
    "including moonlight, planet shine, and zodiacal light.[3]";
string no1a = text.Substring(text.IndexOf("observable")+10, 15);
string no1b = text.Substring(text.IndexOf("zodiacal") - 11, 10);
var no1 = string.Concat(no1a, no1b);
Console.WriteLine("Problem 1");
Console.WriteLine(no1 + "end");//i added end to make the stopping point visible
Console.WriteLine();

Console.WriteLine("Problem 2");
string no2 = text.Replace("Sun", "Solar Emission");
Console.WriteLine(no2);
Console.WriteLine();
List<int> indexes = new List<int> {no2.IndexOf("Solar Emission",0,no2.IndexOf("daytime")), no2.IndexOf("Solar Emission",no2.IndexOf("daytime")),no2.LastIndexOf("Solar Emission") };
Console.WriteLine("The indexes of Solar Emission in the text above is");
foreach (int index in indexes)
{
    Console.WriteLine(index);
}
Console.WriteLine();

Console.WriteLine("Problem 3");
var no3 = text.Split('.');
var newText = string.Concat(no3[0], no3[no3.Length - 1]);
Console.WriteLine(newText);
Console.WriteLine();

Console.WriteLine("Problem 4");
string no4a = text.Remove(text.IndexOf("[1]"), 3);
string no4b = no4a.Remove(no4a.IndexOf("[2]"), 3);
string no4 = no4b.Remove(no4b.IndexOf("[3]"), 3);
Console.WriteLine(no4);
Console.WriteLine();

Console.WriteLine("Problem 5");
string vowels = "aeiou";
string consonants = "bcdfghjklmnpqrstvwxyz";
string numbers = "0123456789";
List<char> textVowels = new List<char>();
List<char> textConsonants = new List<char>();
List<char> textNumbers = new List<char>();
List<char> textSpecialChars = new List<char>();
for (int i = 0; i < text.Length; i++)
{
    if (vowels.Contains(text[i],StringComparison.InvariantCultureIgnoreCase))
    {
        textVowels.Add(text[i]);
    }else if (consonants.Contains(text[i], StringComparison.InvariantCultureIgnoreCase))
    {
        textConsonants.Add(text[i]);
    }else if (numbers.Contains(text[i], StringComparison.InvariantCultureIgnoreCase))
    {
        textNumbers.Add(text[i]);
    }
    else
    {
        textSpecialChars.Add(text[i]);
    }
}
Console.WriteLine();
foreach (var vowel in textVowels)
{
    Console.Write(vowel);
}
Console.WriteLine();
foreach (var consonant in textConsonants)
{
    Console.Write(consonant);
}
Console.WriteLine();
foreach (var number in textNumbers)
{
    Console.Write(number);
}
Console.WriteLine();
foreach (var specialChar in textSpecialChars)
{
    Console.Write(specialChar);
}