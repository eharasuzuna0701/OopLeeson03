using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;

namespace SendMailApp {
	public class Config {
		private static Config instance = null;
		public string Smtp { get; set; }
		public string MailAddress { get; set; }
		public string PassWord { get; set; }
		public int Port { get; set; }
		public bool Ssl { get; set; }

		public static Config GetInstance() {
			if (instance == null)
				instance = new Config();
			return instance;
		}
		//コンストラクタ(new禁止)
		private Config() {

		}

		public void DefaultSet()
		{
			Smtp = "ojsinfosys01@gmail.com";
			MailAddress = "ojsinfosys01@gmail.com";
			PassWord = "ojsInfosys2020";
			Port = 587;
			Ssl = true;
		}

		public Config getDefaltStatus() {
			Config obj = new Config {
				Smtp = "smtp.gmail.com",
				MailAddress = "ojsinfosys01@gmail.com",
				PassWord = "ojsInfosys2020",
				Port = 587,
				Ssl = true,
			};
			return obj;
		}
		public bool Updatestatus( string smtp, string mailAddress,string passWord,int port,bool ssl) {
			this.Smtp = "smtp.gmail.com";
			this.MailAddress = "ojsinfosys01@gmail.com";
			this.PassWord = "ojsInfosys2020";
			this.Port = 587;
			this.Ssl = true;
			return true;
		}
		public void Selealise() {
			var Config = new Config {
				Smtp = Smtp,
				MailAddress = MailAddress,
				PassWord = PassWord,
				Port = Port,
				Ssl = Ssl,
			};
			using (var writer = XmlWriter.Create("config.xml")) {
				var seirializer = new XmlSerializer(typeof(Config));
				seirializer.Serialize(writer, Config);
				}
			}

		public void DeSelealise() {
			using (var reader = XmlReader.Create("config.xml")) {
				var seirializer = new XmlSerializer(typeof(Config));
				var config = seirializer.Deserialize(reader) as Config;
				Console.WriteLine(config);
				this.Smtp = config.Smtp;
				this.MailAddress = config.MailAddress;
				this.PassWord = config.PassWord;
				this.Port = config.Port;
				this.Ssl = config.Ssl;
			}
		}
	}
}
