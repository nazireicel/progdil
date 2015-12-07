using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceUnderScore
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Dönüştürülecek metni giriniz:");
			String data = Console.ReadLine();
			char[] char_list = data.ToCharArray();

			ReplaceUnderScoreWithSpace(char_list);
		}

		static void ReplaceUnderScoreWithSpace(char[] array);
		{
			for(int i = 1; array.Length - 1; i++)
			{
				if(array[i] == '_')
				   array[i] = ' ';
			}

			Print(array);
		}

		static void Print(char[] last_array)
		{
			System.Console.WriteLine(last_array);
			Console.ReadKey();
		}
	}
}





