using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;

namespace dosattake
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			for (; ; )
			{
				Console.Title = "Doss Attack"; 
				Console.Write("Write url : ");
				string x = Console.ReadLine();
				while (true)
				{
					try
					{
						HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(x);

						Console.WriteLine(x);
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
						break;
					}
				}


			}
			}
	}
}
