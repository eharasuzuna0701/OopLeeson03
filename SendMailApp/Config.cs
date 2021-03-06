﻿using System;
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

		public void DefaultSet() {
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

		//設定データを更新
		public bool Updatestatus(string smtp, string mailAddress, string passWord, int port, bool ssl) {
			this.Smtp = smtp;
			this.MailAddress = mailAddress;
			this.PassWord = passWord;
			this.Port = port;
			this.Ssl = ssl;
			return true;
		}

		//シリアル化
		public void Selealise() {
			using (var writer = XmlWriter.Create("config.xml")) {
				var seirializer = new XmlSerializer(typeof(Config));
				seirializer.Serialize(writer, instance);
			} 
		}

		//逆シリアル化
		public void DeSelealise() {
			using (var reader = XmlReader.Create("config.xml")) {
				var seirializer = new XmlSerializer(typeof(Config));
				instance = seirializer.Deserialize(reader) as Config;
			}
		}
	}
}
