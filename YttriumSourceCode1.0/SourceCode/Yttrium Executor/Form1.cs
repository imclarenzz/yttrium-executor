using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CeleryAPI;

namespace Yttrium_Executor
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(Form1.CreateRoundRectRgn(0, 0, base.Width, base.Height, 25, 25));
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000209E File Offset: 0x0000029E
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseLocation = new Point(-e.X, -e.Y);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020BC File Offset: 0x000002BC
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				Point mousePose = Control.MousePosition;
				mousePose.Offset(this.mouseLocation.X, this.mouseLocation.Y);
				base.Location = mousePose;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002109 File Offset: 0x00000309
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002113 File Offset: 0x00000313
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000211E File Offset: 0x0000031E
		private void button3_Click(object sender, EventArgs e)
		{
			ExploitApi.Inject();
			this.label2.ForeColor = Color.Green;
			this.label2.Text = "✅";
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002149 File Offset: 0x00000349
		private void button4_Click(object sender, EventArgs e)
		{
			ExploitApi.Execute(this.richTextBox1.Text, false);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002160 File Offset: 0x00000360
		private void button5_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.DefaultExt = "*.lua";
			saveFileDialog.Filter = "Lua Files|*.lua";
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0;
			if (flag)
			{
				this.richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000021C0 File Offset: 0x000003C0
		private void button6_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.DefaultExt = "*.lua";
			openFileDialog.Filter = "Lua Files|*.lua";
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Length > 0;
			if (flag)
			{
				this.richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
			}
		}

		// Token: 0x04000001 RID: 1
		public Point mouseLocation;
	}
}
