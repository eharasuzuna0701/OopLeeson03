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
			tbPass.Password = cf.PassWord;
			cbssl.IsChecked = cf.Ssl;
		}

		private void btApply_Click(object sender, RoutedEventArgs e) {
			(Config.GetInstance()).Updatestatus(
				tbSmtp.Text,
				tbName.Text,
				tbPass.Password,
				int.Parse(tbPort.Text),
				cbssl.IsChecked ?? false );
		}

		private void btCansel_Click(object sender, RoutedEventArgs e) {
			
			this.Close();
		}

		private void btOK_Click(object sender, RoutedEventArgs e) {
			btApply_Click(sender, e);
			this.Close();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e) {
			tbSmtp.Text = (Config.GetInstance()).Smtp;
			tbPort.Text = (Config.GetInstance()).Port.ToString();
			tbName.Text = (Config.GetInstance()).MailAddress;
			tbPass.Password = (Config.GetInstance()).PassWord;
			cbssl.IsChecked = (Config.GetInstance()).Ssl;
			tbAddress.Text = (Config.GetInstance()).MailAddress;
		}
	}
}
