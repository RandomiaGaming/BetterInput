using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BetterInputExample
{
    public static class WndProcInjector
    {
        private const int GWLP_WNDPROC = -4;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, WndProcDelegate newWndProc);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallWindowProc(IntPtr lpPrevWndFunc, IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        private delegate IntPtr WndProcDelegate(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        // Custom window procedure
        private static IntPtr CustomWndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
        {
            // Handle specific messages
            if (msg == WM_MY_CUSTOM_EVENT)
            {
                // Your custom handling for this message
                Console.WriteLine("Custom event received!");
                return IntPtr.Zero; // Message handled, return zero
            }

            // Call the original window procedure for other messages
            //  return CallWindowProc(originalWndProc, hWnd, msg, wParam, lParam);
            return IntPtr.Zero;
        }

        private const uint WM_MY_CUSTOM_EVENT = 0x8001; // Use your custom message ID

        // Original window procedure
        private static WndProcDelegate originalWndProc;

        static void SobMain()
        {
            // Find the target window (adjust parameters as needed)
            IntPtr hWnd = FindWindow(null, "Target Window Title");

            if (hWnd != IntPtr.Zero)
            {
                // Store the original window procedure
                //originalWndProc = (WndProcDelegate)GetWindowLongPtr(hWnd, GWLP_WNDPROC);

                // Set the custom window procedure
                SetWindowLongPtr(hWnd, GWLP_WNDPROC, CustomWndProc);

                // Send a custom message to the window (optional)
                //SendMessage(hWnd, WM_MY_CUSTOM_EVENT, IntPtr.Zero, IntPtr.Zero);

                // Allow the program to run
                Console.ReadLine();

                // Restore the original window procedure before exiting
                SetWindowLongPtr(hWnd, GWLP_WNDPROC, originalWndProc);
            }
            else
            {
                Console.WriteLine("Window not found.");
            }
        }
    }
}