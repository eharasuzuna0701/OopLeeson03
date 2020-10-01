using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {
	class Program {
		static void Main(string[] args) {
			string code = "12345";

			var message = GetMessage(code) ?? DefaltMessage();
			Console.WriteLine(message);
		}

		private static object DefaltMessage() {
			return "babu";
		}

		private static object GetMessage(string code) {
			return "pien";
		}
	}
}
