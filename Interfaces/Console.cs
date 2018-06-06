using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	class Console:Iprint
	{
		public void Print(string s) {
			System.Console.WriteLine(s);
		}
		public void PrintAll(string[] strings) {
			foreach (string str in strings) {
				Print(str);
			}
		}
	}
}
