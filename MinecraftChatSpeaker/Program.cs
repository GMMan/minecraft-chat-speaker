/*
 * Date: 8/8/2013
 * Time: 9:06 AM
 * (C) Yukai Li (GMMan/GMWare)
 */
using System;
using System.Windows.Forms;

namespace MinecraftChatSpeaker
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
