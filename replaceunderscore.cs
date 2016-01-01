using System;

namespace ReplaceUnderscore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dönüştürülecek metni giriniz: ");
            string data = Console.ReadLine();

            System.Console.WriteLine(ReplaceUnderscoreWithSpace(data));
            Console.ReadKey();
  
         }

        static char[] ReplaceUnderscoreWithSpace(string str)
        {
            char[] char_list = str.ToCharArray();

            for (int i = 1; i < char_list.Length - 1; i++)
            {
                if (char_list[i] == '_')
                    char_list[i] = ' ';
            }

            return char_list;
        }

    }

}
