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
		//初期設定ボタン
		private void btDeflt_Click(object sender, RoutedEventArgs e) {

			Config cf = (Config.GetInstance()).getDefaltStatus();
			tbSmtp.Text = cf.Smtp;
			tbPort.Text = cf.Port.ToString();
			tbAddress.Text = tbName.Text = cf.MailAddress;
			tbPass.Password = cf.PassWord;
			cbssl.IsChecked = cf.Ssl;
		}

		//適用（更新）ボタン
		private void btApply_Click(object sender, RoutedEventArgs e) {
			//空白の値を探す
			if (!(tbSmtp.Text == ""|| tbName.Text == "" || 
				tbPass.Password == "" || tbPort.Text == "")) {
				try {
					ApplyMthoty();

				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
					
				}
				
			//エラーメッセージ
			} else {
				MessageBox.Show("値が入力されていない項目があります。");
			}

		}
		//更新メソッド
		private void ApplyMthoty(){
		(Config.GetInstance()).Updatestatus(
				tbSmtp.Text,
				tbName.Text,
				tbPass.Password,
				int.Parse(tbPort.Text),
				cbssl.IsChecked ?? false);
			MessageBox.Show("設定が変更されました");
	}
		//キャンセルボタン

		private void btCansel_Click(object sender, RoutedEventArgs e) {

			//変更途中の項目があれば
			if (tbSmtp.Text != (Config.GetInstance()).Smtp ||
				tbName.Text != (Config.GetInstance()).MailAddress||
				tbAddress.Text != (Config.GetInstance()).MailAddress ||
				tbPass.Password != (Config.GetInstance()).PassWord || 
				tbPort.Text != (Config.GetInstance()).Port.ToString()||
				cbssl.IsChecked != (Config.GetInstance()).Ssl) {
				//メッセージボックス
				MessageBoxResult kakunin = MessageBox.Show(
					"保存されていない項目があります。本当に戻りますか？", "確認", MessageBoxButton.YesNo,
					MessageBoxImage.Question);

				if (kakunin == MessageBoxResult.Yes) {
					//「はい」が選択された時
					this.Close();
				}


			} else { this.Close(); }
		}
		//OKボタン
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
