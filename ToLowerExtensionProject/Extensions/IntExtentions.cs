using System.Text.RegularExpressions;

namespace System;

public static class IntExtentions
{
    public static string ToWords(this long num)
    {
        string result = string.Empty;

        string[] numParts = num.ToString("N0").Split(',').Reverse().ToArray();

        for (int i = 0; i < numParts.Length; i++)
        {
            string tResult = string.Empty;

            int lastNum = int.Parse(numParts[i][^1].ToString());
            string numUnitName = numUnitNames[i];

            if (int.Parse(numParts[i]) == 0)
            {
                continue;
            }

            int n = numParts[i].Length == 3 ? int.Parse(numParts[i][^2..]) : int.Parse(numParts[i]);

            if (n >= 20)
            {
                n %= 10;
            }

            // добавление слова тысяч / тысяча / тысячи

            if (i == 1)
            {

                if (n >= 2 && n <= 4)
                {
                    numUnitName += "и";
                }

                if (n == 2 || n == 1)
                {
                    tResult = NumPartToWords(numParts[i][..^1] + "0");
                    if (n == 2)
                    {
                        tResult += " две";
                    }
                    else
                    {
                        numUnitName += "а";
                        tResult += " одна";
                    }
                }
                else
                {
                    tResult = NumPartToWords(numParts[i]);
                }
            }

            // добавление слова миллион и выше
            else if (i >= 2)
            {

                if (n >= 5 || lastNum == 0)
                {
                    numUnitName += "ов";
                }
                else if (n >= 2)
                {
                    numUnitName += "а";
                }

                tResult = NumPartToWords(numParts[i]);
            }
            else
            {
                tResult = NumPartToWords(numParts[i]);
            }


            
            if (!string.IsNullOrWhiteSpace(tResult))
            {
                result = string.IsNullOrWhiteSpace(numUnitName)
                    ? (tResult + " " + result).Trim()
                    : (tResult + " " + numUnitName + " " + result).Trim();
            }

        }

        return result.Trim();
    }

    private static string NumPartToWords(string str)
    {
        var result = string.Empty;

        try
        {
            result = numNamesDictionary3[str[^2..]];
            if (str.Length == 3)
            {
                result = $"{numNamesDictionary0[str[0].ToString()]} {result}";
            }
        }
        catch (Exception)
        {

            _ = str.Length switch
            {
                3 => result = str.Select((ch, i) => numNamesDictionary[i][ch.ToString()])?.Aggregate((x, y) => string.Concat(x, " ", y)),
                2 => result = str.Select((ch, i) => numNamesDictionary[i + 1][ch.ToString()])?.Aggregate((x, y) => string.Concat(x, " ", y)),
                1 => result = numNamesDictionary2[str],
                _ => throw new NotSupportedException()
            };


        }

        return Regex.Replace(result!, @"\s+", " ").Trim();

    }

    private static readonly Dictionary<string, string> numNamesDictionary0 = new Dictionary<string, string>()
    {
        ["0"] = "",
        ["1"] = "сто",
        ["2"] = "двести",
        ["3"] = "триста",
        ["4"] = "четыреста",
        ["5"] = "пятьсот",
        ["6"] = "шестьсот",
        ["7"] = "семьсот",
        ["8"] = "восемьсот",
        ["9"] = "девятьсот",
    };

    private static readonly Dictionary<string, string> numNamesDictionary1 = new Dictionary<string, string>()
    {
        ["0"] = "",
        ["1"] = "",
        ["2"] = "двадцать",
        ["3"] = "тридцать",
        ["4"] = "сорок",
        ["5"] = "пятьдесят",
        ["6"] = "шестьдесят",
        ["7"] = "семьдесят",
        ["8"] = "восемьдесят",
        ["9"] = "девяносто",
    };

    private static readonly Dictionary<string, string> numNamesDictionary2 = new Dictionary<string, string>()
    {
        ["0"] = "",
        ["1"] = "один",
        ["2"] = "два",
        ["3"] = "три",
        ["4"] = "четыре",
        ["5"] = "пять",
        ["6"] = "шесть",
        ["7"] = "семь",
        ["8"] = "восемь",
        ["9"] = "девять",
    };


    private static readonly Dictionary<string, string> numNamesDictionary3 = new Dictionary<string, string>()
    {
        ["10"] = "десять",
        ["11"] = "одиннадцать",
        ["12"] = "двеннадцать",
        ["13"] = "тринадцать",
        ["14"] = "четырнадцать",
        ["15"] = "пятнадцать",
        ["16"] = "шестнадцать",
        ["17"] = "семнадцать",
        ["18"] = "восемнадцать",
        ["19"] = "девятнадцать",
    };



    private static readonly Dictionary<string, string>[] numNamesDictionary = new Dictionary<string, string>[]
    {
        numNamesDictionary0,
        numNamesDictionary1,
        numNamesDictionary2,
        numNamesDictionary3,
    };

    private static string[] numUnitNames = { "", "тысяч", "миллион", "миллиард", "триллион", "квадриллион", "квинтиллион" };
}