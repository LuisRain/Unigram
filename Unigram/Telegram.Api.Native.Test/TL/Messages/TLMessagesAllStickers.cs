// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages
{
	public partial class TLMessagesAllStickers : TLMessagesAllStickersBase 
	{
		public Int32 Hash { get; set; }
		public TLVector<TLStickerSet> Sets { get; set; }

		public TLMessagesAllStickers() { }
		public TLMessagesAllStickers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesAllStickers; } }

		public override void Read(TLBinaryReader from)
		{
			Hash = from.ReadInt32();
			Sets = TLFactory.Read<TLVector<TLStickerSet>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Hash);
			to.WriteObject(Sets);
		}
	}
}