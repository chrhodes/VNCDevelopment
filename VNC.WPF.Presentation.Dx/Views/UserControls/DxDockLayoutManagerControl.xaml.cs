﻿using System;
using System.Windows.Controls;

namespace VNC.WPF.Presentation.Dx.Views
{
    public partial class DxDockLayoutManagerControl : UserControl
    {
        public DxDockLayoutManagerControl()
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_CATEGORY);

            InitializeComponent();

            Log.CONSTRUCTOR("Exit", Common.LOG_CATEGORY, startTicks);
        }
    }
}
