using System;
using System.Windows.Forms;

namespace Yttrium_Executor
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002AAD File Offset: 0x00000CAD
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
