using System;
using System.Runtime.InteropServices;

namespace DiscordRpcDemo
{
	// Token: 0x02000002 RID: 2
	public class DiscordRpc
	{
		// Token: 0x06000001 RID: 1
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
		public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		// Token: 0x06000002 RID: 2
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
		public static extern void RunCallbacks();

		// Token: 0x06000003 RID: 3
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
		public static extern void Shutdown();

		// Token: 0x06000004 RID: 4
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
		public static extern void UpdatePresence(ref DiscordRpc.RichPresence presence);

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		internal static void Initialize(string v1, ref object handlers, bool v2, object p)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000111 RID: 273
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DisconnectedCallback(int errorCode, string message);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000115 RID: 277
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ErrorCallback(int errorCode, string message);

		// Token: 0x0200001D RID: 29
		public struct EventHandlers
		{
			// Token: 0x040000FC RID: 252
			public DiscordRpc.ReadyCallback readyCallback;

			// Token: 0x040000FD RID: 253
			public DiscordRpc.DisconnectedCallback disconnectedCallback;

			// Token: 0x040000FE RID: 254
			public DiscordRpc.ErrorCallback errorCallback;
		}

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000119 RID: 281
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ReadyCallback();

		// Token: 0x0200001F RID: 31
		[Serializable]
		public struct RichPresence
		{
			// Token: 0x040000FF RID: 255
			public string state;

			// Token: 0x04000100 RID: 256
			public string details;

			// Token: 0x04000101 RID: 257
			public long startTimestamp;

			// Token: 0x04000102 RID: 258
			public long endTimestamp;

			// Token: 0x04000103 RID: 259
			public string largeImageKey;

			// Token: 0x04000104 RID: 260
			public string largeImageText;

			// Token: 0x04000105 RID: 261
			public string smallImageKey;

			// Token: 0x04000106 RID: 262
			public string smallImageText;

			// Token: 0x04000107 RID: 263
			public string partyId;

			// Token: 0x04000108 RID: 264
			public int partySize;

			// Token: 0x04000109 RID: 265
			public int partyMax;

			// Token: 0x0400010A RID: 266
			public string matchSecret;

			// Token: 0x0400010B RID: 267
			public string joinSecret;

			// Token: 0x0400010C RID: 268
			public string spectateSecret;

			// Token: 0x0400010D RID: 269
			public bool instance;
		}
	}
}
