//asks the user to input an arabic number
Console.WriteLine("Geben Sie eine Arabische Zahl ein: ");
//converts string to integer
int arabicNum = Convert.ToInt32(Console.ReadLine());
//roman number output
string romanNum = "";
//while loop for converter output
while (arabicNum > 0)
{//if the arabic num is bigger or equal to 1000 output M
    if (arabicNum >= 1000)
    {
        romanNum += "M";
        arabicNum -= 1000;
    }//if the arabic number is bigger or equal to 900 output CM 
    else if (arabicNum >= 900)
    {
        romanNum += "CM";
        arabicNum -= 900;
    }//if the arabic number is bigger or equal to 500 output D
    else if (arabicNum >= 500) 
    {
        romanNum += "D";
        arabicNum -= 500;
    }//if the arabic number is bigger or equal to 40000 output CD
    else if (arabicNum >= 400)
    {
        romanNum += "CD";
        arabicNum -= 400;
    }//if the arabic number is bigger or equal to 100 output C
    else if (arabicNum >= 100)
    {
        romanNum += "C";
        arabicNum -= 100;
    }//if the arabic number is bigger or equal to 90 output XC
    else if (arabicNum >= 90)
    {
        romanNum += "XC";
        arabicNum -= 90;
    }//if the arabic number is bigger or equal to 50 output L
    else if (arabicNum >= 50)
    {
        romanNum += "L";
        arabicNum -= 50;
    }//if the arabic number is bigger or equal to 40 output XL
    else if (arabicNum >= 40)
    {
        romanNum += "XL";
        arabicNum -= 40;
    }//if the arabic number is bigger or equal to 10 output X
    else if (arabicNum >= 10)
    {
        romanNum += "X";
        arabicNum -= 10;
    }//if the arabic number is bigger or equal to 9 output IX
    else if (arabicNum >= 9)
    {
        romanNum += "IX";
        arabicNum -= 9;
    }//if the arabic number is bigger or equal to 5 output V
    else if (arabicNum >= 5)
    {
        romanNum += "V";
        arabicNum -= 5;
    }//if the arabic number is bigger or equal to 4 output IV
    else if (arabicNum >= 4)
    {
        romanNum += "IV";
        arabicNum -= 4;
    }//if the arabic number is bigger or equal to 1 output I
    else
    {
        romanNum += "I";
        arabicNum -= 1;
    }
}//outputs the result
Console.WriteLine("Die Römische Zahl ist: " + romanNum);