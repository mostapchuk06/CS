using System;
using System.Text.RegularExpressions;

class RegularExpressions
{
    static void Main(string[] args)
    {
        string[] str = { "asd123zxc456", "bnm567hjk890", "ssss435ggg095", "BMP", "RTF", "RTC" };
        string[] digits = { "1899", "2040", "2100","98264" };

        // 1
        Console.WriteLine("Check for four-digit numbers ::");
        foreach (string s in digits)
        {
            Console.WriteLine("{0} {1} a valid digit.", s,
            IsValidNumber(s) ? "is" : "is not");
        }
        // 2
        Console.WriteLine("\nCheck for string example(asd123zxc456) ::");
        foreach (string s in str)
        {
            Console.WriteLine("{0} {1} a valid.", s,
            isValidString(s) ? "is" : "is not");
        }   
        // 3
        Console.WriteLine("\nCheck for abbreviation ::");
        foreach (string s in str)
        {
            Console.WriteLine("{0} {1} a valid.", s,
            isAbbreviation(s) ? "is" : "is not");
        }
        // 4
        Console.WriteLine("\nCheck for date ::");
        foreach (string s in digits)
        {
            Console.WriteLine("{0} {1} a valid.", s,
            IsValidDate(s) ? "is" : "is not");
        }
    }
    // 4
    public static bool IsValidDate(string date)
    {
        string dateRegex = @"^(19|20)\d{2}$";

        Regex re = new Regex(dateRegex);
        if (re.IsMatch(date))
            return (true);
        else
            return (false);
    }
    // 3
    public static bool isAbbreviation(string inputText)
    {
        string strRegex = @"^[A-Z]{3}$";

        Regex re = new Regex(strRegex);
        if (re.IsMatch(inputText))
            return (true);
        else
            return (false);
    }
    // 2
    public static bool isValidString(string inputString)
    {
        string strRegex = @"^\w{3}\d{3}\w{3}\d{3}";

        Regex re = new Regex(strRegex);
        if (re.IsMatch(inputString))
            return (true);
        else
            return (false);
    }
    // 1
    public static bool IsValidNumber(string inputNumm)
    {
        string fourNummRegex = @"(^[0-9]{4}$)";

        Regex re = new Regex(fourNummRegex);
        if (re.IsMatch(inputNumm))
            return (true);
        else
            return (false);
    }
}