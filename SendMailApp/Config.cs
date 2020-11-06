using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
			Smtp = "smtp.gmail.com";
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
		public bool Updatestatus(Config cf) {
			this.Smtp = "smtp.gmail.com";
			this.MailAddress = "ojsinfosys01@gmail.com";
			this.PassWord = "ojsInfosys2020";
			this.Port = 587;
			this.Ssl = true;
			return true;
		}
		
	}
}
