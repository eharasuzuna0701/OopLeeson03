using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SendMailApp {
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window {
		SmtpClient sc = new SmtpClient();

		public MainWindow() {
			InitializeComponent();
			sc.SendCompleted += Sc_SendCompleted;

		}
		private void Sc_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
			if (e.Cancelled) {
				MessageBox.Show("送信はキャンセルされました");
			} else {
				MessageBox.Show(e.Error?.Message ?? "送信完了");
			}
		}
		private void BtOK_Click(object sender, RoutedEventArgs e) {
			try {
				Config ctf = Config.GetInstance();
				MailMessage msg = new MailMessage(ctf.MailAddress, tbTo.Text);

				if (tbCc.Text != "")
					msg.CC.Add(tbCc.Text);
				if (tbBcc.Text != "")
					msg.Bcc.Add(tbBcc.Text);

				msg.Subject = Subject.Text;
				msg.Body = Body.Text;

				//添付ファイル
				foreach (var item in lbfile.Items) {
					msg.Attachments.Add(new Attachment(item.ToString()));
					
				}

				sc.Host = ctf.Smtp;
				sc.Port = ctf.Port;
				sc.EnableSsl = ctf.Ssl;
				sc.Credentials = new NetworkCredential(ctf.MailAddress, ctf.PassWord);
				sc.SendMailAsync(msg);

			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
		private void BtCansel_Click(object sender, RoutedEventArgs e) {
			sc.SendAsyncCancel();
		}

		private void btConfig_Click(object sender, RoutedEventArgs e) 
			{
			ConfigWindowShow();

		}
		
		//設定画面呼び出しメソッド
		private static void ConfigWindowShow() {
			ConfigWindow configWindow = new ConfigWindow();
			configWindow.ShowDialog();
		}

		private void Window_Lodedd(object sender, RoutedEventArgs e) {
			try {
				Config.GetInstance().DeSelealise();//逆シリアル化メソッド
			}
			//エラーメッセージ
			catch (FileNotFoundException) {
				//ファイルが存在しないので設定画面を表示
				ConfigWindowShow();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void Window_Closed(object sender, EventArgs e) {
			try {
				Config.GetInstance().Selealise();//シリアル化メソッド
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
			
		}
		//添付ファイル追加
		private void btAdd_Click(object sender, RoutedEventArgs e) {
			var ofd = new OpenFileDialog();

			if (ofd.ShowDialog() == true) {
				lbfile.Items.Add(ofd.FileNames);
			}
		}
		//添付ファイル削除
		private void btcDel_Click(object sender, RoutedEventArgs e) {
			lbfile.Items.Remove(lbfile.SelectedItem);
		}
	}
	
}
