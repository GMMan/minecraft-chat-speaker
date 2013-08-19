/*
 * Date: 8/8/2013
 * Time: 9:35 AM
 * (C) Yukai Li (GMMan/GMWare)
 */
using System;
using System.Text;

namespace MinecraftChatSpeaker
{
	/// <summary>
	/// Description of MinecraftFormatUtils.
	/// </summary>
	public static class MinecraftFormatUtils
	{
		public static string RemoveColorCodes(string input)
		{
			StringBuilder sb = new StringBuilder();
			int lastColorCodeLoc = 0;
			int prevColorCodeLoc = 0;
			while ((lastColorCodeLoc = input.IndexOf('§', prevColorCodeLoc)) != -1)
			{
				sb.Append(input.Substring(prevColorCodeLoc, lastColorCodeLoc - prevColorCodeLoc));
				prevColorCodeLoc = lastColorCodeLoc + 2;
			}
			sb.Append(input.Substring(prevColorCodeLoc));
			return sb.ToString();
		}
		
		public static bool IsLineChat(string input)
		{
			// HACK: Should actually parse the string
			return input.Contains("[CLIENT] [INFO] [CHAT]") && input.Contains("<") && input.Contains(">");
		}
		
		public static string GetChatContent(string input)
		{
			int indexOfChat = input.IndexOf("[CLIENT] [INFO] [CHAT]") + 23;
			return input.Substring(indexOfChat);
		}
		
		public static string GetPlayerName(string chatLine)
		{
			int indOpenBracket = chatLine.IndexOf('<');
			int indCloseBracket = chatLine.IndexOf('>');
			if (indOpenBracket == -1 || indCloseBracket == -1) return string.Empty;
			return chatLine.Substring(indOpenBracket + 1, indCloseBracket - indOpenBracket - 1);
		}
		
		public static string TrimPlayerName(string chatLine)
		{
			return chatLine.Substring(chatLine.IndexOf('>') + 2);
		}
	}
}
