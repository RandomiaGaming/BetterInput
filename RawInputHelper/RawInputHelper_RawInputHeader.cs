//RawInputHeader
public static partial class RawInputHelper
{
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct RawInputHeader
    {
        //The size of the RawInputHeader structure in bytes.
        public static int SizeOf = 4/*Type*/ + 4/*Size*/ + PtrSize/*hDevice*/ + PtrSize/*wParam*/;

        public enum TypeValues : uint
        {
            Mouse = 0,
            Keyboard = 1,
            HID = 2
        }

        public const uint Type_Mouse = 0;
        public const uint Type_Keyboard = 1;
        public const uint Type_HID = 2;

        public static readonly string[] TypeNames = new string[3]
        {
            "Mouse",
            "Keyboard",
            "HID"
        };

        public static string TypeToString(uint type)
        {
            return InternalIndexToString(type, TypeNames);
        }

        public uint Type; //The type of the device from one of constants above.
        public uint Size; //The size of the entire input packet including the header and payload.
        public System.IntPtr hDevice; //A handle to the raw input device coorisponding input.
        public System.IntPtr wParam; //The wParam of the window message representing this input.
    }
}