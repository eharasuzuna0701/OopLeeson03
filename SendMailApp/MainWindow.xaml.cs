﻿using System;
using System.Collections.Generic;
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
				MailMessage msg = new MailMessage();

				string[] txtMailAddress = tbTo.Text.Split(',');
				foreach (string s in txtMailAddress) {
					msg.To.Add(new MailAddress(s));
				}

				msg.From = new MailAddress("ojsibfosys01@gmail.com");

				if (tbCc.Text != "")
					msg.CC.Add(tbCc.Text);
				if (tbBcc.Text != "")
				msg.Bcc.Add(tbBcc.Text);
				
				msg.Subject = Subject.Text;
				msg.Body = Body.Text;

				SmtpClient sc = new SmtpClient();
				sc.Host = "smtp.gmail.com";
				sc.Port = 587;
				sc.EnableSsl = true;
				sc.Credentials = new NetworkCredential("ojsinfosys01@gmail.com", "ojsInfosys2020");
				sc.SendMailAsync(msg);

			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
		private void BtCansel_Click(object sender, RoutedEventArgs e) {
			//まったくわからん
			sc.SendAsyncCancel();
		}
		private void btConfig_Click(object sender, RoutedEventArgs e) {
			ConfigWindow configWindow = new ConfigWindow();
			configWindow.ShowDialog();

		}
		private void window_Lodedd() {
			
		}
	}
}
