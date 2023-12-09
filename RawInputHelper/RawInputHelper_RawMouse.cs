//RawMouse
public static partial class RawInputHelper
{
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct RawMouse
    {
        //The size of the RawMouse structure in bytes.
        public static int SizeOf = 2/*Flags*/ + 2/*Reserved*/ + 2/*ButtonFlags*/ + 2/*ButtonData*/ + 2/*Reserved2*/ + 8/*RawButtons*/ + 8/*LastX*/ + 8/*LastY*/ + 8/*ExtraInformation*/;

        [System.Flags]
        public enum FlagsValues : ushort
        {
            MoveRelative = 0x00,
            MoveAbsolute = 0x01,
            VirtualDesktop = 0x02,
            AttributesChanged = 0x04,
            MoveNoCoalesce = 0x08
        }

        public const ushort Flags_MoveRelative = 0x00;
        public const ushort Flags_MoveAbsolute = 0x01;
        public const ushort Flags_VirtualDesktop = 0x02;
        public const ushort Flags_AttributesChanged = 0x04;
        public const ushort Flags_MoveNoCoalesce = 0x08;

        public static readonly string[] FlagNames = new string[5]
        {
            "MoveRelative",
            "MoveAbsolute",
            "VirtualDesktop",
            "AttributesChanged",
            "MoveNoCoalesce"
        };

        public static string FlagsToString(ushort flags)
        {
            return InternalFlagsToString(flags, FlagNames);
        }

        [System.Flags]
        public enum ButtonFlagsValues : ushort
        {
            None = 0x0000,
            LeftDown = 0x0001,
            LeftUp = 0x0002,
            RightDown = 0x0004,
            RightUp = 0x0008,
            MiddleDown = 0x0010,
            MiddleUp = 0x0020,
            X1Down = 0x0040,
            X1Up = 0x0080,
            X2Down = 0x0100,
            X2Up = 0x0200,
            Wheel = 0x0400,
            HorizontalWheel = 0x0800
        }

        public const ushort ButtonFlags_None = 0x0000;
        public const ushort ButtonFlags_LeftDown = 0x0001;
        public const ushort ButtonFlags_LeftUp = 0x0002;
        public const ushort ButtonFlags_RightDown = 0x0004;
        public const ushort ButtonFlags_RightUp = 0x0008;
        public const ushort ButtonFlags_MiddleDown = 0x0010;
        public const ushort ButtonFlags_MiddleUp = 0x0020;
        public const ushort ButtonFlags_X1Down = 0x0040;
        public const ushort ButtonFlags_X1Up = 0x0080;
        public const ushort ButtonFlags_X2Down = 0x0100;
        public const ushort ButtonFlags_X2Up = 0x0200;
        public const ushort ButtonFlags_Wheel = 0x0400;
        public const ushort ButtonFlags_HorizontalWheel = 0x0800;

        public static readonly string[] ButtonFlagNames = new string[13]
        {
            "None",
            "LeftDown",
            "LeftUp",
            "RightDown",
            "RightUp",
            "MiddleDown",
            "MiddleUp",
            "X1Down",
            "X1Up",
            "X2Down",
            "X2Up",
            "Wheel",
            "HorizontalWheel"
        };

        public static string ButtonFlagsToString(ushort buttonFlags)
        {
            return InternalFlagsToString(buttonFlags, ButtonFlagNames);
        }

        //Reinterperets the Padding, ButtonFlags, ButtonData, and MorePadding fields of a RawMouse struct as if they were a ulong.
        //This reinterperitation is used by some mouse and pointing devices and is supported by the official API spcification.
        public static ulong ButtonDataAsULong(RawMouse source)
        {
            ulong output = 0;

            output |= ((ulong)source.Reserved) << 0;
            output |= ((ulong)source.ButtonFlags) << 16;
            output |= ((ulong)source.ButtonData) << 32;
            output |= ((ulong)source.Reserved2) << 48;

            return output;
        }

        //Reinterperets the ButtonData field of a RawMouse struct as if it were a signed short.
        //While technically wrong accordint to the API specification this makes it far easier to work with scroll wheel deltas.
        public static short SignButtonData(ushort buttonData)
        {
            byte[] byteArray = System.BitConverter.GetBytes(buttonData);
            return System.BitConverter.ToInt16(byteArray, 0);
        }

        public ushort Flags; //A bitwise combination of the constants above.
        public ushort Reserved; //16 bits of reserved to conform to the API spcification.
        public ushort ButtonFlags; //A bitwise combination of the constants above.
        public ushort ButtonData; //Contains the distance travelled by the scoll wheel if applicable. This data is best interprited as a signed short.
        public ushort Reserved2; //16 more bits of reserved to conform to the API specification.
        public ulong RawButtons; //The raw state of the mouse buttons. This property is not used by the Win32 subsystem.
        public long LastX; //The motion of the mouse on the X axis. Interpritation will depend on Flags.
        public long LastY; //The motion of the mouse on the Y axis. Interpritation will depend on Flags.
        public ulong ExtraInformation; //Extra information specified by the device or driver.
    }
}