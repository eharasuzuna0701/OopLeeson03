
using Section01;
using Section02;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7 {
	class Program {
		static void Main(string[] args) {
			var lines = File.ReadAllLines("sample.txt");
			var we = new WordsExtractor(lines);
			foreach (var word in we.Extract()) {
				Console.WriteLine(word);
			}
			
			//var dict = new Dictionary<MontDay, string> {
			//	{ new MontDay(3,5),"珊瑚の日"},
			//	{ new MontDay(8,4),"箸の日"},
			//	{ new MontDay(10,3),"登山の日"},
			//};
			//var md = new MontDay(8, 4);
			//var s = dict[md];
			//Console.WriteLine(s);
		}
		
	}
}
