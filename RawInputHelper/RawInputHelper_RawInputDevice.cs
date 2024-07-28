//RawInputDevice
public static partial class RawInputHelper
{
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct RawInputDevice
    {
        //The size of the RawInputDevice structure in bytes.
        public static int SizeOf = 2/*UsagePage*/ + 2/*Usage*/ + 4/*Flags*/ + PtrSize/*hwndTarget*/;

        [System.Flags]
        public enum Flags_Values
        {
            Remove = 0x00000001,
            Include = 0x00000010,
            PageOnly = 0x00000020,
            NoLegacy = 0x00000030,
            InputSink = 0x00000100,
            CaptureMouse = 0x00000200,
            NoHotKeys = 0x00000200,
            AppKeys = 0x00000400,
            ExInputSink = 0x00001000,
            DevNotify = 0x00002000
        }

        public const uint Flags_Remove = 0x00000001;
        public const uint Flags_Include = 0x00000010;
        public const uint Flags_PageOnly = 0x00000020;
        public const uint Flags_NoLegacy = 0x00000030;
        public const uint Flags_InputSink = 0x00000100;
        public const uint Flags_CaptureMouse = 0x00000200;
        public const uint Flags_NoHotKeys = 0x00000200;
        public const uint Flags_AppKeys = 0x00000400;
        public const uint Flags_ExInputSink = 0x00001000;
        public const uint Flags_DevNotify = 0x00002000;

        public ushort UsagePage; //The usage page for the desired HID device.
        public ushort Usage; //The Usage for the desired HID device.
        public uint Flags; //A bitwise combination of the constants above.
        public System.IntPtr hwndTarget; //Specifies which window will recieve events related to this device. If null then events will be sent to the window with focus. 

        public enum HIDTarget : uint
        {
            Mouse = 0x00010002, //Usages of 0001 or 0002
            Controller = 0x00010004, //Usages of 0004 or 0005
            Keyboard = 0x00010006, //Usages of 0006 or 0007
            FlightModeSwitch = 0x0001000C,
            SystemControls = 0x00010080,
            ConsumerControls = 0x000C0001,
            ExternalPen = 0x000D0001,
            InternalPen = 0x000D0002,
            TouchScreen = 0x000D0004,
            PrecisionTouchpad = 0x000D0005,
            Sensors = 0x00200000, //Usages varry by device see HID specification for each sensor.
            UPSBattery = 0x00840004,
            BarcodeScanner = 0x008C0002
        }

        public struct HIDTargetInfo
        {
            public ushort Usage;
            public ushort UsagePage;
        }

        public static HIDTargetInfo GetHIDTargetInfo(HIDTarget hidTarget)
        {
            uint deviceTargetCast = (uint)hidTarget;
            HIDTargetInfo output = new HIDTargetInfo();
            output.Usage = (ushort)deviceTargetCast;
            output.UsagePage = (ushort)(deviceTargetCast >> 16);
            return output;
        }
    }
}