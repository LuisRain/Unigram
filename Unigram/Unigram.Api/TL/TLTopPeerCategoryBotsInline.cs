// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLTopPeerCategoryBotsInline : TLTopPeerCategoryBase 
	{
		public TLTopPeerCategoryBotsInline() { }
		public TLTopPeerCategoryBotsInline(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.TopPeerCategoryBotsInline; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x148677E2);
		}
	}
}