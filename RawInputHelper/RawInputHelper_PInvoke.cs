//PInvoke
public static partial class RawInputHelper
{
    #region GetRawInputData
    //Get the raw data from the RawInput structure.
    private const uint GetRawInputData_uiCommand_Input = 0x10000003;
    //Get the header information from the RawInput structure.
    private const uint GetRawInputData_uiCommand_Header = 0x10000005;

    //Retrieves the raw input from the specified device.
    //Return: If data is null and the function is successful, the return value is 0. If data is not null and the function is successful, the return value is the number of bytes copied into data. If there is an error, the return value is -1.
    [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
    private static extern uint GetRawInputData(
        System.IntPtr rawInput, //A handle to the RawInput structure. This comes from the lParam in WM_INPUT.
        uint uiCommand, //The command flag. This parameter can be one of the constants above.
        System.IntPtr data, //A pointer to the data that comes from the RawInput structure. This depends on the value of uiCommand. If data is NULL, the required size of the buffer is returned in size.
        ref uint size, //The size, in bytes, of the data in data.
        uint sizeHeader //The size, in bytes, of the RawInputHeader structure.
        );
    #endregion
    #region RegisterRawInputDevices
    //Registers the devices that supply the raw input data.
    //Return: True if the function succeeds; otherwise, false. If the function fails, call GetLastError for more information.
    [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
    private static extern bool RegisterRawInputDevices(
        System.IntPtr rawInputDevices, //An array of RawInputDevice structures that represent the devices that supply the raw input.
        uint uiNumDevices, //The number of RawInputDevice structures pointed to by rawInputDevices.
        uint cbSize //The size, in bytes, of a RawInputDevice structure.
        );
    #endregion
}