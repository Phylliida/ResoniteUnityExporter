namespace LZ4
{

	public interface IBufferAllocator
	{
		byte[] GetBuffer(int minSize);

		void ReturnBuffer(byte[] buffer);
	}
}
