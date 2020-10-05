using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
	class Program {
		static void Main(string[] args) {
			var numbar = Enumerable.Repeat(-1, 20).ToArray();
			foreach (var item in numbar) {
				Console.WriteLine(item);
			}
		}
	}
}
