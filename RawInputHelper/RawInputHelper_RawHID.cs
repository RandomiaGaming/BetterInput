//RawHID
public static partial class RawInputHelper
{
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct RawHID
    {
        //The size of the RawHID structure minus RawData in bytes.
        public static int SizeOf = 4/*SizeHid*/ + 4/*Count*/;

        public uint SizeHID; //The number of bytes each HID input takes up within bRawData.
        public uint Count; //The number of HID inputs within bRawData.
        public byte[] RawData; //The raw binary data of the HID inputs.
    }
}