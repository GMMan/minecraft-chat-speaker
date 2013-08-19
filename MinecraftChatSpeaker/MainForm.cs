/*
 * Date: 8/8/2013
 * Time: 9:06 AM
 * (C) Yukai Li (GMMan/GMWare)
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;
using SpeechLib;

namespace MinecraftChatSpeaker
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		FileSystemWatcher watcher = new FileSystemWatcher();
		StreamReader sr;
		
		SpVoice speech = new SpVoiceClass();
		Dictionary<string, SpVoice> playerVoices = new Dictionary<string, SpVoice>();
		List<SpObjectToken> voices = new List<SpObjectToken>();
		
		object changeSync = new object();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			watcher.Changed += watcher_Changed;
			
			List<string> approvedVoiceNames = new List<string>();
			foreach (InstalledVoice v in (new SpeechSynthesizer()).GetInstalledVoices())
			{
				if (v.VoiceInfo.Culture.TwoLetterISOLanguageName == "en")
				{
					if (v.VoiceInfo.Name != "VW Paul") approvedVoiceNames.Add(v.VoiceInfo.Name);
				}
			}
			
			foreach (SpObjectToken token in (new SpVoiceClass()).GetVoices("", ""))
			{
				if (approvedVoiceNames.Contains(token.GetAttribute("Name"))) voices.Add(token);
			}
		}
		
		void SelectLogButtonClick(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
			{
				StopButtonClick(this, EventArgs.Empty);
				if (sr != null) sr.Close();
				watcher.Path = Path.GetDirectoryName(openFileDialog1.FileName);
				watcher.Filter = Path.GetFileName(openFileDialog1.FileName);
				logPathLabel.Text = openFileDialog1.FileName;
				sr = new StreamReader(File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
				richTextBox1.Clear();
			}
		}
		
		void StartButtonClick(object sender, EventArgs e)
		{
			if (sr != null) sr.BaseStream.Seek(0, SeekOrigin.End);
			watcher.EnableRaisingEvents = true;
		}

		void watcher_Changed(object sender, FileSystemEventArgs e)
		{
			if (System.Threading.Monitor.TryEnter(changeSync))
			{
				while (sr.BaseStream.Position != sr.BaseStream.Length)
				{
					string line = sr.ReadLine();
					if (MinecraftFormatUtils.IsLineChat(line))
					{
						string stripped = MinecraftFormatUtils.RemoveColorCodes(MinecraftFormatUtils.GetChatContent(line));
						string playerName = MinecraftFormatUtils.GetPlayerName(stripped);
						SpVoice speech;
						if (!playerVoices.TryGetValue(playerName, out speech))
						{
							speech = new SpVoiceClass();
							speech.Voice = voices[(new Random()).Next(voices.Count)];
							playerVoices[playerName] = speech;
						}
						appendTextLineAndScrollToEnd(stripped);
						try
						{
							string trimmed = MinecraftFormatUtils.TrimPlayerName(stripped);
							if (trimmed.StartsWith("<")) trimmed = string.Format("less than sign {0}", trimmed.Substring(1));
							speech.Speak(trimmed, SpeechVoiceSpeakFlags.SVSFlagsAsync);
						}
						catch {}
					}
				}
				System.Threading.Monitor.Exit(changeSync);
			}
		}
		
		void StopButtonClick(object sender, EventArgs e)
		{
			watcher.EnableRaisingEvents = false;
		}
		
		void appendTextLineAndScrollToEnd(string s)
		{
			if (InvokeRequired)
			{
				Invoke(new Action<string>(appendTextLineAndScrollToEnd), s);
			}
			else
			{
				richTextBox1.AppendText(s);
				richTextBox1.AppendText("\n");
				richTextBox1.SelectionStart = richTextBox1.Text.Length;
				richTextBox1.ScrollToCaret();
			}
		}
		
		void TestButtonClick(object sender, EventArgs e)
		{
			string line = speakTestTextBox.Text;
			string stripped = MinecraftFormatUtils.RemoveColorCodes(line);
			string playerName = MinecraftFormatUtils.GetPlayerName(stripped);
			SpVoice speech;
			if (!playerVoices.TryGetValue(playerName, out speech))
			{
				speech = new SpVoiceClass();
				speech.Voice = voices[(new Random()).Next(voices.Count)];
				playerVoices[playerName] = speech;
			}
			appendTextLineAndScrollToEnd(stripped);
			try
			{
				string trimmed = MinecraftFormatUtils.TrimPlayerName(stripped);
				if (trimmed.StartsWith("<")) trimmed = string.Format("less than sign {0}", trimmed.Substring(1));
				speech.Speak(trimmed, SpeechVoiceSpeakFlags.SVSFlagsAsync);
			}
			catch {}
		}
	}
}
