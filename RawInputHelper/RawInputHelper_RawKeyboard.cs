//RawKeyboard
public static partial class RawInputHelper
{
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct RawKeyboard
    {
        //The size of the RawKeyboard structure in bytes.
        public static int SizeOf = 2/*MakeCode*/ + 2/*Flags*/ + 2/*Reserved*/ + 2/*VKey*/ + 4/*Message*/ + 8/*ExtraInformation*/;

        [System.Flags]
        public enum FlagsValues : ushort
        {
            Down = 0,
            Up = 1,
            E0Prefix = 2,
            E1Prefix = 4
        }

        public const ushort Flags_Down = 0;
        public const ushort Flags_Up = 1;
        public const ushort Flags_E0Prefix = 2;
        public const ushort Flags_E1Prefix = 4;

        public static readonly string[] FlagNames = new string[4]
        {
            "Down",
            "Up",
            "E0Prefix",
            "E1Prefix"
        };

        public static string FlagsToString(ushort flags)
        {
            return InternalFlagsToString(flags, FlagNames);
        }

        public ushort MakeCode; //The scan code of the associated key.
        public ushort Flags; //A bitwise combination of the constants above.
        public ushort Reserved; //Must be zero.
        public ushort VKey; //The virtual key code of the associated key.
        public uint Message; //The keyboard window message corresponding to this event.
        public ulong ExtraInformation; //Extra information specified by the device or driver.
    }
}