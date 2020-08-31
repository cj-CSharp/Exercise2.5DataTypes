using System;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            string aliceString = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?";
            Console.WriteLine("Please enter search value: ");
            string searchValue = Console.ReadLine();

            bool hasSearchValue = false;
            if (aliceString.ToLower().Contains(searchValue.ToLower()))
            {
                hasSearchValue = true;
            }

            Console.WriteLine(hasSearchValue);
            if(hasSearchValue)
            {
                int indexOfSearchValue = aliceString.ToLower().IndexOf(searchValue.ToLower());
                int lengthOfSearchValue = searchValue.Length;
                Console.WriteLine("Index is: " + indexOfSearchValue);
                Console.WriteLine("Length of search value is: " + lengthOfSearchValue);
                aliceString = aliceString.Remove(indexOfSearchValue, lengthOfSearchValue).Trim();
                Console.WriteLine(aliceString);
            }
        }
    }
}
