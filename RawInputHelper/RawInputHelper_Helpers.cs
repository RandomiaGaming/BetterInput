//Helpers
using System.Drawing;
using System.Runtime.InteropServices;
using System;

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
        RawInputDevice[] rawInputDevices = new RawInputDevice[1];

        RawInputDevice.HIDTargetInfo hidTargetInfo = RawInputDevice.GetHIDTargetInfo(RawInputDevice.HIDTarget.Keyboard);

        rawInputDevices[0].UsagePage = hidTargetInfo.UsagePage;
        rawInputDevices[0].Usage = hidTargetInfo.Usage;
        rawInputDevices[0].Flags = RawInputDevice.Flags_NoLegacy;
        rawInputDevices[0].hwndTarget = hwndTarget;

        if (!RegisterRawInputDevices(rawInputDevices, 1, (uint)RawInputDevice.SizeOf))
        {
            int error = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
            throw new System.ComponentModel.Win32Exception(error);
        }
    }
    //Returns true if the message was a raw input keyboard event else false.
    public static unsafe bool ProcessRawKeyboardMessage(ref System.Windows.Forms.Message m, RawKeyboardEvent callback)
    {
        if (m.Msg is 0x00FF /*WM_INPUT*/)
        {
            uint size = 0;
            uint result = GetRawInputData(m.LParam, GetRawInputData_uiCommand_Input, System.IntPtr.Zero, ref size, (uint)RawInputHeader.SizeOf);

            if (result == uint.MaxValue)
            {
                int error = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
                if (error != 0)
                {
                    throw new System.ComponentModel.Win32Exception(error);
                }
            }

            byte[] data = new byte[size];

            fixed (byte* dataPtr = data)
            {
                result = GetRawInputData(m.LParam, GetRawInputData_uiCommand_Input, (System.IntPtr)(*dataPtr), ref size, (uint)RawInputHeader.SizeOf);
            }

            if (result != size)
            {
                int error = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
                if (error != 0)
                {
                    throw new System.ComponentModel.Win32Exception(error);
                }
            }





            /* uint bytesRead = 0;
             void* data = stackalloc byte[(int)size];

             bytesRead = GetRawInputData(m.LParam, GetRawInputData_uiCommand_Input, data, &size, (uint)RawInputHeader.SizeOf);

             if (bytesRead != size)
             {
                 throw new System.Exception("What");
             }

             RawInputHeader header = System.Runtime.InteropServices.Marshal.PtrToStructure<RawInputHeader>((System.IntPtr)data);

             if (header.Type == RawInputHeader.Type_Keyboard)
             {
                 RawKeyboard inputPayload = System.Runtime.InteropServices.Marshal.PtrToStructure<RawKeyboard>(dataPtr + RawInputHeader.SizeOf);

                 callback?.Invoke(header, inputPayload);

            return true;
            }*/
        }

        return false;
    }
    #endregion
}