using System.Runtime.InteropServices;
using System.Text;



unsafe
{
	IntPtr ptr = Marshal.AllocHGlobal(80);
	
	var sBytes = BitConverter.GetBytes((short)1000);
	var iBytes = BitConverter.GetBytes(500000);
	
	Marshal.Copy(sBytes, 0, ptr, sBytes.Length);
	Marshal.Copy(iBytes, 0, ptr, iBytes.Length);
	
	byte* vPtr = (byte*)ptr.ToPointer();
	
	///////////
	
	
	Span<byte> span = new Span<byte>(vPtr, 80);
	Span<byte> shortBytes = span.Slice(0, 2);
	
	var rawBytesArray = shortBytes.ToArray();


	Console.WriteLine(BitConverter.ToInt16(rawBytesArray));
	
	Marshal.FreeHGlobal(ptr);
}