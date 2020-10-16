
using Section01;
using Section02;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Chapter7 {
	class Program {
		static void Main(string[] args) {
			
			var text = "Cozy lummox gives smart squid who asks for job pen";
			Exercise1_1(text);
		}
		static void Exercise1_1(string text) {
			var dict = new Dictionary<char, int>();

			foreach (var item in text) {
				char key = char.ToUpper(item);
				if (item == ' ') {
					continue;
				} else {
					if ('A' <= key && key <= 'Z') {
						if (dict.ContainsKey(key)) {
							dict[key]++;
						} else {
							dict.Add(key, 1);
						}
					}
				}
			}
			foreach (var item in dict.OrderBy(x => x.Key)) {
				Console.WriteLine("{0}:{1}",item.Key,item.Value);
			}
			
		}
	}
}
