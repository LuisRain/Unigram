// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLTextConcat : TLRichTextBase 
	{
		public TLVector<TLRichTextBase> Texts { get; set; }

		public TLTextConcat() { }
		public TLTextConcat(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.TextConcat; } }

		public override void Read(TLBinaryReader from)
		{
			Texts = TLFactory.Read<TLVector<TLRichTextBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x7E6260D7);
			to.WriteObject(Texts);
		}
	}
}