namespace UE4_MakeFolderColorList
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tbPath1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelLabel = new System.Windows.Forms.Panel();
			this.btnRef1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPath2 = new System.Windows.Forms.TextBox();
			this.btnRef2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.tbFolde1 = new System.Windows.Forms.TextBox();
			this.pnlColor1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbFolde2 = new System.Windows.Forms.TextBox();
			this.pnlColor2 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbFolde3 = new System.Windows.Forms.TextBox();
			this.pnlColor3 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.tbFolde4 = new System.Windows.Forms.TextBox();
			this.tbFolde5 = new System.Windows.Forms.TextBox();
			this.tbFolde6 = new System.Windows.Forms.TextBox();
			this.pnlColor4 = new System.Windows.Forms.Panel();
			this.pnlColor5 = new System.Windows.Forms.Panel();
			this.pnlColor6 = new System.Windows.Forms.Panel();
			this.btnOK = new System.Windows.Forms.Button();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label16 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbPath1
			// 
			this.tbPath1.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.tbPath1.Location = new System.Drawing.Point(75, 36);
			this.tbPath1.Name = "tbPath1";
			this.tbPath1.Size = new System.Drawing.Size(378, 27);
			this.tbPath1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(15, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(337, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "① プロジェクトのContentフォルダを入力してください";
			// 
			// panelLabel
			// 
			this.panelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
			this.panelLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelLabel.Location = new System.Drawing.Point(0, 396);
			this.panelLabel.Name = "panelLabel";
			this.panelLabel.Size = new System.Drawing.Size(819, 5);
			this.panelLabel.TabIndex = 8;
			// 
			// btnRef1
			// 
			this.btnRef1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnRef1.Location = new System.Drawing.Point(19, 36);
			this.btnRef1.Name = "btnRef1";
			this.btnRef1.Size = new System.Drawing.Size(49, 27);
			this.btnRef1.TabIndex = 9;
			this.btnRef1.TabStop = false;
			this.btnRef1.Text = "参照";
			this.btnRef1.UseVisualStyleBackColor = true;
			this.btnRef1.Click += new System.EventHandler(this.BtnRef1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(15, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(390, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "② フォルダカラーを設定したい対象フォルダを入力してください";
			// 
			// tbPath2
			// 
			this.tbPath2.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.tbPath2.Location = new System.Drawing.Point(75, 102);
			this.tbPath2.Name = "tbPath2";
			this.tbPath2.Size = new System.Drawing.Size(378, 27);
			this.tbPath2.TabIndex = 2;
			// 
			// btnRef2
			// 
			this.btnRef2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnRef2.Location = new System.Drawing.Point(19, 102);
			this.btnRef2.Name = "btnRef2";
			this.btnRef2.Size = new System.Drawing.Size(49, 27);
			this.btnRef2.TabIndex = 9;
			this.btnRef2.TabStop = false;
			this.btnRef2.Text = "参照";
			this.btnRef2.UseVisualStyleBackColor = true;
			this.btnRef2.Click += new System.EventHandler(this.BtnRef2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(20, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "フォルダ名";
			// 
			// tbFolde1
			// 
			this.tbFolde1.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.tbFolde1.Location = new System.Drawing.Point(24, 57);
			this.tbFolde1.Name = "tbFolde1";
			this.tbFolde1.Size = new System.Drawing.Size(69, 27);
			this.tbFolde1.TabIndex = 3;
			// 
			// pnlColor1
			// 
			this.pnlColor1.BackColor = System.Drawing.Color.White;
			this.pnlColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlColor1.Location = new System.Drawing.Point(100, 57);
			this.pnlColor1.Name = "pnlColor1";
			this.pnlColor1.Size = new System.Drawing.Size(38, 27);
			this.pnlColor1.TabIndex = 10;
			this.pnlColor1.Click += new System.EventHandler(this.PnlColor1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(108, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(22, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "色";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(20, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "フォルダ名";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label6.Location = new System.Drawing.Point(108, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(22, 20);
			this.label6.TabIndex = 6;
			this.label6.Text = "色";
			// 
			// tbFolde2
			// 
			this.tbFolde2.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.tbFolde2.Location = new System.Drawing.Point(24, 119);
			this.tbFolde2.Name = "tbFolde2";
			this.tbFolde2.Size = new System.Drawing.Size(69, 27);
			this.tbFolde2.TabIndex = 4;
			// 
			// pnlColor2
			// 
			this.pnlColor2.BackColor = System.Drawing.Color.White;
			this.pnlColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlColor2.Location = new System.Drawing.Point(100, 119);
			this.pnlColor2.Name = "pnlColor2";
			this.pnlColor2.Size = new System.Drawing.Size(38, 27);
			this.pnlColor2.TabIndex = 10;
			this.pnlColor2.Click += new System.EventHandler(this.PnlColor2_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label7.Location = new System.Drawing.Point(20, 160);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "フォルダ名";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label8.Location = new System.Drawing.Point(108, 160);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(22, 20);
			this.label8.TabIndex = 6;
			this.label8.Text = "色";
			// 
			// tbFolde3
			// 
			this.tbFolde3.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.tbFolde3.Location = new System.Drawing.Point(24, 183);
			this.tbFolde3.Name = "tbFolde3";
			this.tbFolde3.Size = new System.Drawing.Size(69, 27);
			this.tbFolde3.TabIndex = 5;
			// 
			// pnlColor3
			// 
			this.pnlColor3.BackColor = System.Drawing.Color.White;
			this.pnlColor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlColor3.Location = new System.Drawing.Point(100, 183);
			this.pnlColor3.Name = "pnlColor3";
			this.pnlColor3.Size = new System.Drawing.Size(38, 27);
			this.pnlColor3.TabIndex = 10;
			this.pnlColor3.Click += new System.EventHandler(this.PnlColor3_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label9.Location = new System.Drawing.Point(161, 34);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 20);
			this.label9.TabIndex = 6;
			this.label9.Text = "フォルダ名";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label10.Location = new System.Drawing.Point(161, 96);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(74, 20);
			this.label10.TabIndex = 6;
			this.label10.Text = "フォルダ名";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label11.Location = new System.Drawing.Point(161, 160);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(74, 20);
			this.label11.TabIndex = 6;
			this.label11.Text = "フォルダ名";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label12.Location = new System.Drawing.Point(249, 34);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(22, 20);
			this.label12.TabIndex = 6;
			this.label12.Text = "色";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label13.Location = new System.Drawing.Point(249, 96);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(22, 20);
			this.label13.TabIndex = 6;
			this.label13.Text = "色";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label14.Location = new System.Drawing.Point(249, 160);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(22, 20);
			this.label14.TabIndex = 6;
			this.label14.Text = "色";
			// 
			// tbFolde4
			// 
			this.tbFolde4.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.tbFolde4.Location = new System.Drawing.Point(165, 57);
			this.tbFolde4.Name = "tbFolde4";
			this.tbFolde4.Size = new System.Drawing.Size(69, 27);
			this.tbFolde4.TabIndex = 6;
			// 
			// tbFolde5
			// 
			this.tbFolde5.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.tbFolde5.Location = new System.Drawing.Point(165, 119);
			this.tbFolde5.Name = "tbFolde5";
			this.tbFolde5.Size = new System.Drawing.Size(69, 27);
			this.tbFolde5.TabIndex = 7;
			// 
			// tbFolde6
			// 
			this.tbFolde6.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.tbFolde6.Location = new System.Drawing.Point(165, 183);
			this.tbFolde6.Name = "tbFolde6";
			this.tbFolde6.Size = new System.Drawing.Size(69, 27);
			this.tbFolde6.TabIndex = 8;
			// 
			// pnlColor4
			// 
			this.pnlColor4.BackColor = System.Drawing.Color.White;
			this.pnlColor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlColor4.Location = new System.Drawing.Point(241, 57);
			this.pnlColor4.Name = "pnlColor4";
			this.pnlColor4.Size = new System.Drawing.Size(38, 27);
			this.pnlColor4.TabIndex = 10;
			this.pnlColor4.Click += new System.EventHandler(this.PnlColor4_Click);
			// 
			// pnlColor5
			// 
			this.pnlColor5.BackColor = System.Drawing.Color.White;
			this.pnlColor5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlColor5.Location = new System.Drawing.Point(241, 119);
			this.pnlColor5.Name = "pnlColor5";
			this.pnlColor5.Size = new System.Drawing.Size(38, 27);
			this.pnlColor5.TabIndex = 10;
			this.pnlColor5.Click += new System.EventHandler(this.PnlColor5_Click);
			// 
			// pnlColor6
			// 
			this.pnlColor6.BackColor = System.Drawing.Color.White;
			this.pnlColor6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlColor6.Location = new System.Drawing.Point(241, 183);
			this.pnlColor6.Name = "pnlColor6";
			this.pnlColor6.Size = new System.Drawing.Size(38, 27);
			this.pnlColor6.TabIndex = 10;
			this.pnlColor6.Click += new System.EventHandler(this.PnlColor6_Click);
			// 
			// btnOK
			// 
			this.btnOK.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.btnOK.Location = new System.Drawing.Point(344, 326);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(109, 50);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "リストアップ";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// tbResult
			// 
			this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbResult.Location = new System.Drawing.Point(473, 36);
			this.tbResult.Multiline = true;
			this.tbResult.Name = "tbResult";
			this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbResult.Size = new System.Drawing.Size(326, 340);
			this.tbResult.TabIndex = 10;
			this.tbResult.WordWrap = false;
			this.tbResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbResult_KeyDown);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label15.Location = new System.Drawing.Point(473, 13);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(322, 20);
			this.label15.TabIndex = 6;
			this.label15.Text = "⑤ EditorPerProjectUserSettings.ini に貼り付けます";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.pnlColor6);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.pnlColor3);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.pnlColor5);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.pnlColor2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.pnlColor4);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.pnlColor1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.tbFolde6);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.tbFolde3);
			this.groupBox1.Controls.Add(this.tbFolde1);
			this.groupBox1.Controls.Add(this.tbFolde5);
			this.groupBox1.Controls.Add(this.tbFolde4);
			this.groupBox1.Controls.Add(this.tbFolde2);
			this.groupBox1.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.groupBox1.Location = new System.Drawing.Point(19, 148);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(306, 228);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " ③ フォルダ名と対応する色を入力してください ";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label16.Location = new System.Drawing.Point(340, 305);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(117, 20);
			this.label16.TabIndex = 0;
			this.label16.Text = "④ 押してください";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(819, 401);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tbResult);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnRef2);
			this.Controls.Add(this.btnRef1);
			this.Controls.Add(this.tbPath2);
			this.Controls.Add(this.panelLabel);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbPath1);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(835, 440);
			this.Name = "Form1";
			this.Text = "UE4のフォルダカラー設定のリスト作成ツール";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPath1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelLabel;
		private System.Windows.Forms.Button btnRef1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbPath2;
		private System.Windows.Forms.Button btnRef2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbFolde1;
		private System.Windows.Forms.Panel pnlColor1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbFolde2;
		private System.Windows.Forms.Panel pnlColor2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbFolde3;
		private System.Windows.Forms.Panel pnlColor3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox tbFolde4;
		private System.Windows.Forms.TextBox tbFolde5;
		private System.Windows.Forms.TextBox tbFolde6;
		private System.Windows.Forms.Panel pnlColor4;
		private System.Windows.Forms.Panel pnlColor5;
		private System.Windows.Forms.Panel pnlColor6;
		public System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox tbResult;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label16;
	}
}

