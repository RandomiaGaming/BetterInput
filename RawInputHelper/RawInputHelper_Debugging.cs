//Debugging
public static partial class RawInputHelper
{
    public static void DebugRawMouseInput()
    {
        System.Windows.Forms.Application.Run(new RawMouseInputDebugForm());
    }
    public sealed class RawMouseInputDebugForm : System.Windows.Forms.Form
    {
        public RawMouseInputDebugForm()
        {
            RegisterRawMouseInput(Handle);
        }
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (ProcessRawMouseMessage(ref m, DebugRawMouseEvent))
            {
                return;
            }

            base.WndProc(ref m);
        }
    }
    public static void DebugRawKeyboardInput()
    {
        System.Windows.Forms.Application.Run(new RawKeyboardInputDebugForm());
    }
    public sealed class RawKeyboardInputDebugForm : System.Windows.Forms.Form
    {
        public RawKeyboardInputDebugForm()
        {
            RegisterRawKeyboardInput(Handle);
        }
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (ProcessRawKeyboardMessage(ref m, DebugRawKeyboardEvent))
            {
                return;
            }

            base.WndProc(ref m);
        }
    }
    public static void DebugRawMouseEvent(RawInputHeader rawInputHeader, RawMouse rawMouse)
    {
        System.Console.WriteLine("Revieved mouse message:");

        System.Console.Write($"     Header: ");
        System.Console.Write($"Type = {RawInputHeader.TypeToString(rawInputHeader.Type)} \"{rawInputHeader.Type}\", ");
        System.Console.Write($"Size = {rawInputHeader.Size}, ");
        System.Console.Write($"hDevice = {rawInputHeader.hDevice}, ");
        System.Console.Write($"wParam = {rawInputHeader.wParam}.");
        System.Console.WriteLine();

        System.Console.Write($"     Body: ");
        System.Console.Write($"Flags = {RawMouse.FlagsToString(rawMouse.Flags)} \"{rawMouse.Flags}\", ");
        System.Console.Write($"ButtonFlags = {RawMouse.ButtonFlagsToString(rawMouse.ButtonFlags)} \"{rawMouse.ButtonFlags}\", ");
        System.Console.Write($"ButtonData = {RawMouse.SignButtonData(rawMouse.ButtonData)} \"{rawMouse.ButtonData}\", ");
        System.Console.Write($"RawButtons = {rawMouse.RawButtons}, ");
        System.Console.Write($"LastX = {rawMouse.LastX / 65536}, ");
        System.Console.Write($"LastY = {rawMouse.LastY / 65536}, ");
        System.Console.Write($"ExtraInformation = {rawMouse.ExtraInformation}, ");
        System.Console.Write($"Buttons = {RawMouse.ButtonDataAsULong(rawMouse)}.");
        System.Console.WriteLine();

        System.Console.WriteLine();
    }
    public static void DebugRawKeyboardEvent(RawInputHeader rawInputHeader, RawKeyboard rawKeyboard)
    {
        System.Console.WriteLine("Revieved keyboard message:");

        System.Console.Write($"     Header: ");
        System.Console.Write($"hDevice = {rawInputHeader.hDevice}, ");
        System.Console.Write($"Size = {rawInputHeader.Size}, ");
        System.Console.Write($"Type = {RawInputHeader.TypeToString(rawInputHeader.Type)} \"{rawInputHeader.Type}\", ");
        System.Console.Write($"wParam = {rawInputHeader.wParam}.");
        System.Console.WriteLine();

        System.Console.Write($"     Body: ");
        System.Console.Write($"ExtraInformation = {rawKeyboard.ExtraInformation}, ");
        System.Console.Write($"Flags = {RawKeyboard.FlagsToString(rawKeyboard.Flags)} \"{rawKeyboard.Flags}\", ");
        System.Console.Write($"MakeCode = {rawKeyboard.MakeCode}, ");
        System.Console.Write($"Message = {rawKeyboard.Message}, ");
        System.Console.Write($"Reserved = {rawKeyboard.Reserved}, ");
        System.Console.Write($"VKey = {VKNames[rawKeyboard.VKey]} \"{rawKeyboard.VKey}\".");
        System.Console.WriteLine();

        System.Console.WriteLine();
    }
}