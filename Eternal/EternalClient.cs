using System;
using System.Net;

namespace Eternal
{
	// Token: 0x02000004 RID: 4
	public class EternalClient : WebClient
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00004AC8 File Offset: 0x00002CC8
		protected override WebRequest GetWebRequest(Uri address)
		{
			HttpWebRequest request = base.GetWebRequest(address) as HttpWebRequest;
			request.UserAgent = "Eternal-Client";
			return request;
		}
	}
}
