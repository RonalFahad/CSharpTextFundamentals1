using System;

namespace CSharpTextFundamentals
{
    class Program
    {
        static void Main( string[] args )
        {
            // Strings can be of Various Languages Using Unicode
            string english = "Software Engineering";
            string arabic = "هندسة البرمجيات";
            string bangla = "সফ্টওয়্যার প্রকৌশল";
            string japanese = "ソフトウェア工学";
            string greek = "Μηχανική Λογισμικού";
            Console.WriteLine($"English: {english}\n" +
                              $"Arabic: {arabic}\n" +
                              $"Bangla: {bangla}\n" +
                              $"Japanese: {japanese}\n" +
                              $"Greek: {greek}\n");

            // Difference between string and char
            string dummyString = "Bangladesh!"; // Double Quotation " "
            char dummyChar = ' '; // Single Quotation ' '
            Console.WriteLine($"String: {dummyString}\n" +
                              $"Character: {dummyChar}\n");

            // string index
            dummyChar = dummyString[0]; // index 0, 1st char
            Console.WriteLine($"First Character of " +
                              $"{dummyString}: {dummyChar}");
            dummyChar = dummyString[10]; // index 10, 11th char
            Console.WriteLine($"Last Character of " +
                              $"{dummyString}: {dummyChar}\n");

            // string Declaration
            string greeting = "Hello";
            string name = "Ronal";
            int favoriteNumber = 9;

            // string Concatenation
            string concatenation1 = greeting + " " + name + " "
                                  + favoriteNumber;

            /* How Concatenation Operates Here:
             * (((((((greeting + " ") + name) + " ") 
             * + favoriteNumber) + favoriteNumber) 
             * + favoriteNumber) + favoriteNumber) */
            string concatenation2 = greeting + " " + name + " "
                                  + favoriteNumber + favoriteNumber
                                  + favoriteNumber + favoriteNumber;

            /* How Concatenation Operates Here:
             * (((((((favoriteNumber + favoriteNumber) 
             * + favoriteNumber) + favoriteNumber)
             * + " ") + greeting) + " ") + name) */
            string concatenation3 = favoriteNumber + favoriteNumber
                                  + favoriteNumber + favoriteNumber
                                  + " " + greeting + " " + name;

            Console.WriteLine($"{concatenation1}\n" +
                              $"{concatenation2}\n" +
                              $"{concatenation3}\n");

            // string.Format to Avoid Errors Caused by Concatenation
            string output = string.Format("{0}", concatenation1,
                                          "{1}", concatenation2,
                                          "{3}", concatenation3);
            Console.WriteLine(output);

            // Console.WriteLine can also be Utilized to Avoid Concatenation
            Console.WriteLine("{0}", concatenation1,
                              "{1}", concatenation2,
                              "{3}", concatenation3);
            Console.WriteLine();

            // Quote as a char in string.Format
            char quote = '"';
            string techQuote1 = string.Format(quote + "Software is the" +
                                " magic thing whose importance only goes" +
                                " up over time" + quote + " - Bill Gates");
            Console.WriteLine(techQuote1);

            // Backslash (\) or Escape Character to Ignore Double Quotes
            string techQuote2 = "\"Engineering is the closest thing to" +
                                " magic that exists in the world\" - Elon" +
                                " Musk";
            Console.WriteLine(techQuote2);

            // Unicode for Representing Double Quotes
            string techQuote3 = "\u0022If Alibaba cannot become a Microsoft" +
                                " and Walmart, I will regret it for the rest" +
                                " of my life\u0022 - Jack Ma";
            Console.WriteLine(techQuote3);

            // Backslash (\) to Ignore Backslash
            string techQuote4 = "\u0022I've always been at the intersection" +
                                " of computers and\\or whatever they can" +
                                " revolutionize\u0022 - Jeff Bezos";
            Console.WriteLine(techQuote4);

            // Verbatim String Literal Starts with @ Sign
            // Verbatim String Literal Ignores Escape Character
            string techQuote5 = @"""Stay hungry, and\or stay foolish"" - Steve Jobs";
            Console.WriteLine(techQuote5);

            // Verbatim String Literal Ignores Escape Character with Unicode
            string techQuote6 = @"""Everything is going to be connected to cloud and data...
                                All of this will be mediated by software\u0022 - Satya Nadella";
            Console.WriteLine(techQuote6);
        }
    }
}