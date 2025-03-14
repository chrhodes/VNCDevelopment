using System;

namespace VNC.WPF.Presentation
{
    public class Common : VNC.Core.Common
    {
        public new const string LOG_CATEGORY = "VNCPresentation";

        public const Int32 DEFAULT_WINDOW_WIDTH_XLARGE = 1800;
        public const Int32 DEFAULT_WINDOW_HEIGHT_XLARGE = 1200;

        public const Int32 DEFAULT_WINDOW_WIDTH_LARGE = 1350;
        public const Int32 DEFAULT_WINDOW_HEIGHT_LARGE = 900;

        public const Int32 DEFAULT_WINDOW_WIDTH = 900;
        public const Int32 DEFAULT_WINDOW_HEIGHT = 600;

        public const Int32 DEFAULT_WINDOW_WIDTH_SMALL = 450;
        public const Int32 DEFAULT_WINDOW_HEIGHT_SMALL = 300;

        // These values are added to the dimensions of a hosting window if the
        // hosted User_Control specifies values for MinWidth/MinHeight.
        // They have not been thought through but do seem to "work".

        public const Int32 WINDOW_HOSTING_USER_CONTROL_WIDTH_PAD = 30;
        public const Int32 WINDOW_HOSTING_USER_CONTROL_HEIGHT_PAD = 75;
    }
}
