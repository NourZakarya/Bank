namespace Task3
{
    internal class Program
    {
        static bool Vowels(string s)
        {
            foreach (char c in s)
            {
                if (IsVowel(c))
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsVowel(char c)
        {
            char vow = char.ToLower(c);
            return vow == 'a' || vow == 'e'|| vow == 'i'|| vow == 'o' || vow == 'u';
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a string:");
                string s = Console.ReadLine();
                if (!Vowels(s))
                {
                    throw new Exception("The string must contain vowels.");
                }

                Console.WriteLine("String contains vowels.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}