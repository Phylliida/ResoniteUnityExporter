using System;

namespace LZ4
{

	[Flags]
	public enum LZ4StreamFlags
	{
		None = 0,
		InteractiveRead = 1,
		HighCompression = 2,
		IsolateInnerStream = 4,
		Default = 0
	}
}