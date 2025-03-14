using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;


namespace VNC.Core.Xaml.Transitions
{
    public class GlassHelper
    {
        struct MARGINS
        {
            public MARGINS(Thickness t)
            {
                Left = (Int32)t.Left;
                Right = (Int32)t.Right;
                Top = (Int32)t.Top;
                Bottom = (Int32)t.Bottom;
            }
            public Int32 Left;
            public Int32 Right;
            public Int32 Top;
            public Int32 Bottom;
        }

        [DllImport("dwmapi.dll", PreserveSig = false)]
        static extern void DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS margins);

        [DllImport("dwmapi.dll", PreserveSig = false)]
        static extern Boolean DwmIsCompositionEnabled();

        public static Boolean ExtendGlassFrame(Window window, Thickness margin)
        {
            try
            {
                if (!DwmIsCompositionEnabled())
                    return false;

                IntPtr hwnd = new WindowInteropHelper(window).Handle;
                if (hwnd == IntPtr.Zero)
                    throw new InvalidOperationException("The Window must be shown before extending glass.");

                // Set the background to transparent from both the WPF and Win32 perspectives
                window.Background = Brushes.Transparent;
                HwndSource.FromHwnd(hwnd).CompositionTarget.BackgroundColor = Colors.Transparent;

                MARGINS margins = new MARGINS(margin);
                DwmExtendFrameIntoClientArea(hwnd, ref margins);
            }
            catch (Exception )
            {
            }
            return true;
        }
    }
}
