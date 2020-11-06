using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SendMailApp {
	/// <summary>
	/// ConfigWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class ConfigWindow : Window {
		public ConfigWindow() {
			InitializeComponent();
		}

		private void btDeflt_Click(object sender, RoutedEventArgs e) {
			Config cf = (Config.GetInstance()).getDefaltStatus();
			tbSmtp.Text = cf.Smtp;
			tbPort.Text = cf.Port.ToString();
			tbAddress.Text = tbName.Text = cf.MailAddress;
			tbPass.Text = cf.PassWord;
			cbssl.IsChecked = cf.Ssl;
		}

		//private void btApply_Click(object sender, RoutedEventArgs e) {
		//(Config.GetInstance()).Updatestatus(
		//	tbSmtp.Text, tbName.Text, tbPass.Text,int.Parse(tbPort.Text),cbssl
		//}
	}
}
