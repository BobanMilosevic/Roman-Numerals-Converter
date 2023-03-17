// Create a dictionary of Roman numeral
Dictionary<int, string> romanDict = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

// Ask the user to input an Arabic number
Console.WriteLine("Geben Sie eine Arabische Zahl ein: ");
int arabicNum = Convert.ToInt32(Console.ReadLine());

// Convert the Arabic number to a Roman numeral using the dictionary
string romanNum = "";
foreach (KeyValuePair<int, string> pair in romanDict)
{
    while (arabicNum >= pair.Key)
    {
        romanNum += pair.Value;
        arabicNum -= pair.Key;
    }
}

// Output the result
Console.WriteLine("Die Römische Zahl ist: " + romanNum);