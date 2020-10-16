﻿
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

			
			Console.WriteLine("**********************\n* 辞書登録プログラム *\n**********************");
			Console.WriteLine("1.登録 2.内容表示");
			Console.Write(">");
			string n = Console.ReadLine();
			while (n == "1" || n == "2") {
				DuplicateKeySample();
			};

			//var lines = File.ReadAllLines("sample.txt");
			//var we = new WordsExtractor(lines);
			//foreach (var word in we.Extract()) {
			//	Console.WriteLine(word);
			//}

			//var dict = new Dictionary<MontDay, string> {
			//	{ new MontDay(3,5),"珊瑚の日"},
			//	{ new MontDay(8,4),"箸の日"},
			//	{ new MontDay(10,3),"登山の日"},
			//};
			//var md = new MontDay(8, 4);
			//var s = dict[md];
			//Console.WriteLine(s);

		}

		static public void DuplicateKeySample() {
			// ディクショナリの初期化
			var dict = new Dictionary<string, List<string>>() {
			   //{ "PC", new List<string> { "パーソナル コンピュータ", "プログラム カウンタ", } },
			   //{ "CD", new List<string> { "コンパクト ディスク", "キャッシュ ディスペンサー", } },
			};

			// ディクショナリに追加
			Console.Write("KEYを入力:");
			var key = Console.ReadLine();
			Console.Write("VALUEを入力:");
			var value = Console.ReadLine();
			Console.WriteLine("登録しました!");
			if (dict.ContainsKey(key)) {
				dict[key].Add(value);
			} else {
				dict[key] = new List<string> { value };
			}

			// ディクショナリの内容を列挙
			foreach (var item in dict) {
				foreach (var term in item.Value) {
					Console.WriteLine("{0} : {1}", item.Key, term);
				}
			}
		}

	}
}
