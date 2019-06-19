using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UE4_MakeFolderColorList
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		// ボタン：参照 1
		private void BtnRef1_Click(object sender, EventArgs e)
		{
			// FolderBrowserDialogクラスのインスタンスを作成
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			// 上部に表示する説明テキストを指定する
			fbd.Description = "Contentフォルダを指定してください。";
			// ルートフォルダを指定する
			// デフォルトでDesktop
			fbd.RootFolder = Environment.SpecialFolder.Desktop;
			// 最初に選択するフォルダを指定する
			// RootFolder以下にあるフォルダである必要がある
			fbd.SelectedPath = @"C:\Windows";
			// ユーザーが新しいフォルダを作成できるようにする
			fbd.ShowNewFolderButton = false;

			// ダイアログを表示する
			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				// 選択されたフォルダを表示する
				this.tbPath1.Text = fbd.SelectedPath;
			}
		}
		// ボタン：参照 2
		private void BtnRef2_Click(object sender, EventArgs e)
		{
			// FolderBrowserDialogクラスのインスタンスを作成
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			// 上部に表示する説明テキストを指定する
			fbd.Description = "カラーを設定したいフォルダを指定してください。";
			// ルートフォルダを指定する
			// デフォルトでDesktop
			fbd.RootFolder = Environment.SpecialFolder.Desktop;
			// 最初に選択するフォルダを指定する
			// RootFolder以下にあるフォルダである必要がある
			fbd.SelectedPath = @"C:\Windows";
			// ユーザーが新しいフォルダを作成できるようにする
			fbd.ShowNewFolderButton = false;

			// ダイアログを表示する
			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				// 選択されたフォルダを表示する
				this.tbPath2.Text = fbd.SelectedPath;
			}
		}

		// ボタン：リストアップ
		private void BtnOK_Click(object sender, EventArgs e)
		{
			// フォルダパスが有効か判定する
			if (!Directory.Exists(tbPath1.Text))
			{
				MessageBox.Show("Contentフォルダが見つかりません");
				return;
			}
			// フォルダパスが有効か判定する
			if (!Directory.Exists(tbPath2.Text))
			{
				MessageBox.Show("設定したい対象フォルダが見つかりません");
				return;
			}

			// 対象フォルダ以下のサブフォルダをすべて取得する
			string[] subFolders = Directory.GetDirectories(
				tbPath2.Text, "*", SearchOption.AllDirectories);

			// 結果出力を一旦初期化
			tbResult.Text = "";

			// [PathColor] を先頭に追加
			tbResult.AppendText(@"[PathColor]" + "\r\n");

			try
			{
				// 結果を表示する
				foreach (var item in subFolders)
				{
					string s = Path.GetFileName(item);
					string value;

					value = MakeText(s, tbFolde1.Text, item, pnlColor1.BackColor);
					if (value != null)
					{
						tbResult.AppendText(value + "\r\n");
					}

					value = MakeText(s, tbFolde2.Text, item, pnlColor2.BackColor);
					if (value != null)
					{
						tbResult.AppendText(value + "\r\n");
					}

					value = MakeText(s, tbFolde3.Text, item, pnlColor3.BackColor);
					if (value != null)
					{
						tbResult.AppendText(value + "\r\n");
					}

					value = MakeText(s, tbFolde4.Text, item, pnlColor4.BackColor);
					if (value != null)
					{
						tbResult.AppendText(value + "\r\n");
					}

					value = MakeText(s, tbFolde5.Text, item, pnlColor5.BackColor);
					if (value != null)
					{
						tbResult.AppendText(value + "\r\n");
					}

					value = MakeText(s, tbFolde6.Text, item, pnlColor6.BackColor);
					if (value != null)
					{
						tbResult.AppendText(value + "\r\n");
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Contentフォルダのパスが正しいか確認してください");
			}
		}

		// 関数：出力するテキストに整形
		private string MakeText(string folderName, string keyword, string item, Color c)
		{
			string value = null;

			if (folderName == keyword)
			{
				value = item.Replace(tbPath1.Text, @"/Game");
				value = value.Replace(@"\", @"/");
				value += "=(" + ColorCombert(c) + ")";
			}

			return value;
		}

		// 関数：カラー値を指定の形式に変換
		private string ColorCombert(Color c)
		{
			string s1, s2, s3;

			double fR = (double)c.R;
			fR = fR / 255;
			fR = Math.Pow(fR, 2.2);
			s1 = fR.ToString("F6");

			double fG = (double)c.G;
			fG = fG / 255;
			fG = Math.Pow(fG, 2.2);
			s2 = fG.ToString("F6");

			double fB = (double)c.B;
			fB = fB / 255;
			fB = Math.Pow(fB, 2.2);
			s3 = fB.ToString("F6");

			string result;
			result = "R=" + s1 + ",G=" + s2 + ",B=" + s3 + ",A=1.000000";

			return result;
		}

		// クリック：カラー設定
		private void PnlColor1_Click(object sender, EventArgs e)
		{
			// カラー設定ダイアログを表示する
			if (colorDialog1.ShowDialog() != DialogResult.Cancel)
			{
				// フォームに反映
				this.pnlColor1.BackColor = colorDialog1.Color;
			}
		}
		private void PnlColor2_Click(object sender, EventArgs e)
		{
			// カラー設定ダイアログを表示する
			if (colorDialog1.ShowDialog() != DialogResult.Cancel)
			{
				// フォームに反映
				this.pnlColor2.BackColor = colorDialog1.Color;
			}
			
		}
		private void PnlColor3_Click(object sender, EventArgs e)
		{
			// カラー設定ダイアログを表示する
			if (colorDialog1.ShowDialog() != DialogResult.Cancel)
			{
				// フォームに反映
				this.pnlColor3.BackColor = colorDialog1.Color;
			}
		}
		private void PnlColor4_Click(object sender, EventArgs e)
		{
			// カラー設定ダイアログを表示する
			if (colorDialog1.ShowDialog() != DialogResult.Cancel)
			{
				// フォームに反映
				this.pnlColor4.BackColor = colorDialog1.Color;
			}
		}
		private void PnlColor5_Click(object sender, EventArgs e)
		{
			// カラー設定ダイアログを表示する
			if (colorDialog1.ShowDialog() != DialogResult.Cancel)
			{
				// フォームに反映
				this.pnlColor5.BackColor = colorDialog1.Color;
			}
		}
		private void PnlColor6_Click(object sender, EventArgs e)
		{
			// カラー設定ダイアログを表示する
			if (colorDialog1.ShowDialog() != DialogResult.Cancel)
			{
				// フォームに反映
				this.pnlColor6.BackColor = colorDialog1.Color;
			}
		}

		// Ctrl + A
		private void TbResult_KeyDown(object sender, KeyEventArgs e)
		{
			// テキスト全選択
			if (e.Control && e.KeyCode == Keys.A)
			{
				tbResult.SelectAll();
				e.SuppressKeyPress = true;
			}
		}
	}
}
