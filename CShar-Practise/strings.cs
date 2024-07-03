using System;

public  class Strings
{
/*
 ### Basic Programs

**Concatenation**

Write a C# program to concatenate two strings and display the result.

**Substring Extraction**

Write a C# program to extract a substring from a given string based on start index and length.

** String Length**

Write a C# program to calculate and display the length of a string.

**String Comparison**

Write a C# program to compare two strings for equality and inequality.

** String Case Conversion**

Write a C# program to convert a string to uppercase and lowercase.

** String Splitting**

Write a C# program to split a sentence into words and display each word.

**Character Count**

Write a C# program to count occurrences of a specific character in a string.

** Palindrome Check**

Write a C# program to check if a given string is a palindrome (reads the same backward as forward).

---

### Intermediate Programs

**String Reversal**

Write a C# program to reverse a given string.

** String Replace**

Write a C# program to replace a specific substring with another substring in a string.

**String Padding**

Write a C# program to pad a string with spaces or any specified character to a certain length.

** String Trimming**

Write a C# program to remove leading and trailing whitespace characters from a string.

**String Searching**

Write a C# program to search for the first occurrence of a substring in a string.

** String Formatting**

Write a C# program to format strings using placeholders (string.Format) or interpolated strings ($"" syntax).

**String Builder**

Write a C# program to use StringBuilder class for efficient string manipulation, especially for large strings.

** Anagram Check**

Write a C# program to check if two strings are anagrams (contain the same characters in any order).

---

### Advanced Programs

**Regular Expression Matching**

Write a C# program to use regular expressions to validate a string pattern (e.g., email format, phone number).

**String Compression**

Write a C# program to compress a string using techniques like run-length encoding.

** Levenshtein Distance**

Write a C# program to calculate the minimum number of single-character edits required to change one string into another.

**Longest Common Subsequence**

Write a C# program to find the longest sequence that can be derived from two strings.

**String Permutations**

Write a C# program to generate all permutations of characters in a string.

** String Interpolation**

Write a C# program to implement custom string interpolation logic beyond the built-in C# features.

**Unicode Handling**

Write a C# program to handle Unicode characters and strings, including normalization and comparison.

** String Parsing**

Write a C# program to parse structured data (e.g., CSV, JSON) from string format into objects.

**String Encryption**

Write a C# program to encrypt and decrypt strings using cryptographic algorithms.
*/
    public static void Concatenation()
    {
        Console.WriteLine(nameof(Concatenation));

        string firstName = "Zeeshan";
        string middleName = " ";//string.Empty;
        string lastName = "Rehman";

        // using + operator 
        string fullName = firstName + middleName + lastName;
        Console.WriteLine($"{nameof(fullName)} {fullName}");


        // using string method 
        string fullNameByMethod = string.Concat(firstName, middleName, lastName);
        Console.WriteLine($"{nameof(fullNameByMethod)} {fullNameByMethod}");
        Console.WriteLine(Environment.NewLine);

    }



    public static void SubstringExtraction()
    {
        Console.WriteLine(nameof(SubstringExtraction));
        
        string firstName = "Zeeshan";
        string middleName = string.Empty;
        string lastName = "Rehman";

        // using string method 
        string fullNameByMethod = string.Concat(firstName, middleName, lastName);
        int indexOfR = fullNameByMethod.IndexOf("R");
        
        string newExtractedString = fullNameByMethod.Substring(indexOfR);
        string newExtractedStringWithLimit  = fullNameByMethod.Substring(indexOfR,3);
        
        Console.WriteLine($"{nameof(newExtractedString)} {newExtractedString}");
        Console.WriteLine($"{nameof(newExtractedStringWithLimit)} {newExtractedStringWithLimit}");
        Console.WriteLine(Environment.NewLine);

    }

    public static void StringLength()
    {
        Console.WriteLine(nameof(StringLength));

        string firstName = "Zeeshan";
        string middleName = string.Empty;
        string lastName = "Rehman";

        // using string method 
        string fullNameByMethod = string.Concat(firstName, middleName, lastName);
        int lenght = fullNameByMethod.Length;

        Console.WriteLine($"{nameof(lenght)} : {lenght}");
        Console.WriteLine(Environment.NewLine);

    }

    
    public static void StringComparison()
    {
        Console.WriteLine(nameof(StringComparison));

        string firstName = "Zeeshan";
        string middleName = string.Empty;
        string lastName = "Rehman";

        // using string method 
        Console.WriteLine($"FN=MN: {firstName.Equals(middleName)}");
        Console.WriteLine($"FN=LN: {firstName.Equals(lastName)}");

        Console.WriteLine(Environment.NewLine);

    }    
    
    public static void StringCaseConversion()
    {
        Console.WriteLine(nameof(StringCaseConversion));

        string firstName = "Zeeshan";
        string middleName = string.Empty;
        string lastName = "Rehman";
        string fullNameByMethod = string.Concat(firstName, middleName, lastName);

        // using string method 
        Console.WriteLine($"UpperCase : {fullNameByMethod.ToUpper()}");
        Console.WriteLine($"LowerCase : {fullNameByMethod.ToLower()}");

        Console.WriteLine(Environment.NewLine);

    }

    
    public static void StringSplitting()
    {
        Console.WriteLine(nameof(StringSplitting));

        //string firstName = "A quick brown fox jumps";
        //string middleName = " ";
        //string lastName = "over the lazy dog!";
        //string fullNameByMethod = string.Concat(firstName, middleName, lastName);

        //string[] splittedString = fullNameByMethod.Split(' ');   
        //// using string method 
        //Console.WriteLine($"splittedString : {splittedString}");
        //foreach(string splittedString2 in splittedString)
        //{
        //    Console.WriteLine($"{nameof(splittedString2)} : {splittedString2}");
        //}
        //Console.WriteLine(Environment.NewLine);

        int i, j, k = 1;
        for (i = 1; i <= 10; i++)
        {
            for (j = 1; j < i + 1; j++)
            {
                Console.Write(k++ + " ");
            }

            Console.Write("\n");
        }
        Console.ReadLine();
    }
}
