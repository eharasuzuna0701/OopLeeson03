
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

            #region 7-1
            //	var text = "Cozy lummox gives smart squid who asks for job pen";
            //	Exercise1_1(text);
            //}
            //static void Exercise1_1(string text) {
            //	var dict = new Dictionary<char, int>();

            //	foreach (var item in text) {
            //		char key = char.ToUpper(item);
            //		if (item == ' ') {
            //			continue;
            //		} else {
            //			if ('A' <= key && key <= 'Z') {
            //				if (dict.ContainsKey(key)) {
            //					dict[key]++;
            //				} else {
            //					dict.Add(key, 1);
            //				}
            //			}
            //		}
            //	}
            //	foreach (var item in dict.OrderBy(x => x.Key)) {
            //		Console.WriteLine("{0}:{1}",item.Key,item.Value);
            //	}
            #endregion
            // コンストラクタ呼び出し
            var abbrs = new Abbreviations();
            
            // Addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");
            //7.2.3
            Console.WriteLine(abbrs.Count);
            
            //7.2.4

            // インデクサの利用例
            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach (var name in names) {
                var fullname = abbrs[name];
                if (fullname == null)
                    Console.WriteLine("{0}は見つかりません", name);
                else
                    Console.WriteLine("{0}={1}", name, fullname);
            }
            Console.WriteLine();

            // ToAbbreviationメソッドの利用例
            var japanese = "東南アジア諸国連合";
            var abbreviation = abbrs.ToAbbreviation(japanese);
            if (abbreviation == null)
                Console.WriteLine("{0} は見つかりません", japanese);
            else
                Console.WriteLine("「{0}」の略語は {1} です", japanese, abbreviation);
            Console.WriteLine();

            // FindAllメソッドの利用例
            foreach (var item in abbrs.FindAll("国際")) {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();
        }
    }
}
