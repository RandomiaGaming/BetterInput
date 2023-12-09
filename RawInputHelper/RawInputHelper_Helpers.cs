//Helpers
public static partial class RawInputHelper
{
    #region Event Delegates
    public delegate void RawMouseEvent(RawInputHeader rawInputHeader, RawMouse rawMouse);
    public delegate void RawKeyboardEvent(RawInputHeader rawInputHeader, RawKeyboard rawKeyboard);
    #endregion
    #region Helper Methods
    //Registers a window handle to recieve raw input mouse events.
    public static void RegisterRawMouseInput(System.IntPtr hwnd)
    {
        /*RawInputDevice[] rawInputDevices = new RawInputDevice[1];

        ushort[] usagePageAndUsage = RawInputDevice.DeviceTargetToUsage(RawInputDevice.DeviceTarget.Mouse);

        rawInputDevices[0].UsagePage = usagePageAndUsage[0];
        rawInputDevices[0].Usage = usagePageAndUsage[1];
        rawInputDevices[0].Flags = 0;
        rawInputDevices[0].hwndTarget = hwnd;

        RegisterRawInputDevices(rawInputDevices, (uint)rawInputDevices.Length, (uint)Marshal.SizeOf(typeof(RawInputDevice)));*/
    }
    //Returns true if the message was a raw input mouse event else false.
    public static bool ProcessRawMouseMessage(ref System.Windows.Forms.Message m, RawMouseEvent callback)
    {
        /*if (m.Msg is WM_INPUT)
        {
            uint size = 0;
            GetRawInputData(m.LParam, GetRawInputData_uiCommand_Header, ref _, ref size, (uint)Marshal.SizeOf(typeof(RawInputHeader)));

            RawInputHeader header = Marshal.PtrToStructure<RawInputHeader>(pDataHeader);

            if (header.Type == RawInputHeader.Type_Mouse)
            {
                size = 0;
                GetRawInputData(m.LParam, GetRawInputData_uiCommand_InputPayload, out IntPtr pDataInputPayload, ref size, (uint)Marshal.SizeOf(typeof(RawInputHeader)));

                RawMouse inputPayload = Marshal.PtrToStructure<RawMouse>(pDataInputPayload);

                callback?.Invoke(header, inputPayload);

                return true;
            }
        }*/

        return false;
    }
    //Registers a window handle to recieve raw input keyboard events.
    public static void RegisterRawKeyboardInput(System.IntPtr hwndTarget)
    {
        RawInputDevice rawInputDevice = new RawInputDevice();

        RawInputDevice.HIDTargetInfo hidTargetInfo = RawInputDevice.GetHIDTargetInfo(RawInputDevice.HIDTarget.Keyboard);

        rawInputDevice.UsagePage = hidTargetInfo.UsagePage;
        rawInputDevice.Usage = hidTargetInfo.Usage;
        rawInputDevice.Flags = RawInputDevice.Flags_NoLegacy;
        rawInputDevice.hwndTarget = hwndTarget;

        System.IntPtr rawInputDevicesPtr = System.Runtime.InteropServices.Marshal.AllocHGlobal(RawInputDevice.SizeOf);

        System.Runtime.InteropServices.Marshal.StructureToPtr(rawInputDevice, rawInputDevicesPtr, true);

        bool result = RegisterRawInputDevices(rawInputDevicesPtr, 1, (uint)RawInputDevice.SizeOf);

        if (result is false)
        {
            System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(System.Runtime.InteropServices.Marshal.GetLastWin32Error());
        }
    }
    //Returns true if the message was a raw input keyboard event else false.
    public static bool ProcessRawKeyboardMessage(ref System.Windows.Forms.Message m, RawKeyboardEvent callback)
    {
        if (m.Msg is 0x00FF /*WM_INPUT*/)
        {
            uint size = 0;
            uint statusCode1 = GetRawInputData(m.LParam, GetRawInputData_uiCommand_Input, System.IntPtr.Zero, ref size, (uint)RawInputHeader.SizeOf);

            System.IntPtr dataPtr = System.Runtime.InteropServices.Marshal.AllocHGlobal((int)size);
            uint statusCode2 = GetRawInputData(m.LParam, GetRawInputData_uiCommand_Input, dataPtr, ref size, (uint)RawInputHeader.SizeOf);

            RawInputHeader header = System.Runtime.InteropServices.Marshal.PtrToStructure<RawInputHeader>(dataPtr);

            if (header.Type == RawInputHeader.Type_Keyboard)
            {
                RawKeyboard inputPayload = System.Runtime.InteropServices.Marshal.PtrToStructure<RawKeyboard>(dataPtr + RawInputHeader.SizeOf);

                callback?.Invoke(header, inputPayload);

                return true;
            }
        }

        return false;
    }
    #endregion
}