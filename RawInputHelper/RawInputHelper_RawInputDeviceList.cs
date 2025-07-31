//RawInputDeviceList
public static partial class RawInputHelper
{
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct RawInputDeviceList
    {
        //The size of the RawInputDeviceList structure in bytes.
        public static int SizeOf = PtrSize/*hwndTarget*/ + 4/*Type*/;

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

        public System.IntPtr hDevice; //A handle to the raw input device.
        public uint Type; //The type of the device from one of constants above.
    }
}