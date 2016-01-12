using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFoUnicode
{
	class Program
	{
		static void Main(string[] args)
		{
			var result = IsAscii(GetTestString());
			var asciistr = PureAscii(GetTestString());
			Console.WriteLine("end a program");
			Console.ReadLine();
		}

		public static string PureAscii(string source, char nil = ' ')
		{
			var min = '\u0000';
			var max = '\u007F';
			return source.Select(c => c < min ? nil : c > max ? nil : c).ToText();
		}
		

		public static bool IsAscii(string str)
		{
			return Encoding.UTF8.GetByteCount(str) == str.Length;
		}

		public static string GetTestString()
		{
			return "0х13";
		}
	}

	public static class StringExtension
	{
		public static string ToText(this IEnumerable<char> source)
		{
			return new string(source.ToArray());
		}
	}
}
