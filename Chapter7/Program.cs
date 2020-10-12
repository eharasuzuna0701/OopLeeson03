
using Section01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7 {
	class Program {
		static void Main(string[] args) {
			//var employeeDict = new Dictionary<int, Employee>(){
			//	{ 100,new Employee(100,"清水遼久")},
			//	{ 112,new Employee(112,"芹沢洋和")},
			//	{ 125,new Employee(125,"岩瀬奈央子")},
			//};

			//var eployees = employeeDict.Where(emp => emp.Value.Id % 2== 0);
			//foreach (var item in eployees) {
			//	Console.WriteLine($"{item.Value.Name}");
			//}
			//リスト
			var employee = new List<Employee>() {
				new Employee(100,"清水遼久"),
				new Employee(112,"芹沢洋和"),
				new Employee(125,"岩瀬奈央子"),
				new Employee(143,"山田太郎"),
				new Employee(148,"池田太郎"),
				new Employee(152,"高田太郎"),
				new Employee(155,"石川幸也"),
				new Employee(161,"中沢信成"),
			};
			var employeeDict = employee.ToDictionary(emp => emp.Id).ToList();

			foreach (KeyValuePair< int,Employee> item in employeeDict) {
				Console.WriteLine($"{item.Value.Id} {item.Value.Name}");
			}
		}
		
	}
}
