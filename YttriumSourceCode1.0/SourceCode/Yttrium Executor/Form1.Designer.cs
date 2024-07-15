namespace Yttrium_Executor
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002220 File Offset: 0x00000420
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002258 File Offset: 0x00000458
		private void InitializeComponent()
		{
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(840, 43);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 23f);
			this.label2.ForeColor = global::System.Drawing.Color.Red;
			this.label2.Location = new global::System.Drawing.Point(151, 8);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(51, 35);
			this.label2.TabIndex = 1;
			this.label2.Text = "\ud83d\udeab";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Broadway", 20f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(133, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Yttrium";
			this.button2.Font = new global::System.Drawing.Font("Myanmar Text", 10f);
			this.button2.ForeColor = global::System.Drawing.Color.FromArgb(200, 125, 0);
			this.button2.ImageAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.button2.Location = new global::System.Drawing.Point(767, 12);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(32, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "—";
			this.button2.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.Font = new global::System.Drawing.Font("Wingdings 2", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 2);
			this.button1.ForeColor = global::System.Drawing.Color.FromArgb(200, 0, 0);
			this.button1.Location = new global::System.Drawing.Point(805, 12);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(23, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.richTextBox1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new global::System.Drawing.Font("Courier New", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = global::System.Drawing.Color.Green;
			this.richTextBox1.Location = new global::System.Drawing.Point(18, 49);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(799, 370);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			this.button3.Font = new global::System.Drawing.Font("Leelawadee UI", 10f);
			this.button3.Location = new global::System.Drawing.Point(98, 425);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(76, 35);
			this.button3.TabIndex = 2;
			this.button3.Text = "Inject";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.Font = new global::System.Drawing.Font("Leelawadee UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.Location = new global::System.Drawing.Point(12, 425);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(80, 35);
			this.button4.TabIndex = 3;
			this.button4.Text = "Execute ";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f);
			this.button5.Location = new global::System.Drawing.Point(180, 425);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(36, 35);
			this.button5.TabIndex = 4;
			this.button5.Text = "\ud83d\udcbe";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f);
			this.button6.Location = new global::System.Drawing.Point(222, 425);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(36, 35);
			this.button6.TabIndex = 5;
			this.button6.Text = "\ud83d\udcc2";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
			base.ClientSize = new global::System.Drawing.Size(840, 466);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form1";
			this.Text = "Yttrium Executor";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Button button6;
	}
}
