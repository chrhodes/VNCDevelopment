using System.Drawing;
using System.Windows;

namespace VNC.WPF.Presentation
{
    public class LoggingUIConfigVNCARCH : LoggingUIConfig
    {
        public LoggingUIConfigVNCARCH()
        {
            Name = "VNCARCH Capture Filter";

            // TODO(crhodes)
            // Need updated colors here

            Info00 = new LoggingLevel { Label = "Info00", ToolTip = "Info00 / APPLICATION_START / APPLICATION_END / 100" };

            Arch00 = new LoggingLevel { Label = "CONSTRUCTOR", LabelColor = Color.Plum, Color = Color.Plum, ToolTip = "CONSTRUCTOR / Arch00 / 9000" };

            Arch01 = new LoggingLevel { Label = "EVENT", LabelColor = Color.FromArgb(255, 255, 0), Color = Color.FromArgb(255, 255, 0), ToolTip = "EVENT / Arch01 / 9001" };
            Arch101 = new LoggingLevel { Label = "EVENT_LOW", LabelColor = Color.FromArgb(255, 255, 0), Color = Color.FromArgb(255, 255, 0), ToolTip = "EVENT_LOW / Arch101 / 9101" };

            Arch02 = new LoggingLevel { Label = "EVENT_HANDLER", LabelColor = Color.Red, Color = Color.Red, ToolTip = "EVENT_HANDLER / Arch02 / 9002" };
            Arch102 = new LoggingLevel { Label = "EVENT_HANDLER_LOW", LabelColor = Color.Red, Color = Color.Red, ToolTip = "EVENT_HANDLER_LOW / Arch102 / 9102" };

            Arch03 = new LoggingLevel { Label = "APPLICATION_INITIALIZE", LabelColor = Color.LightGray, Color = Color.LightGray, ToolTip = "APPLICATION_INITIALIZE / Arch03 / 9003" };
            Arch103 = new LoggingLevel { Label = "APPLICATION_INITIALIZE_LOW", LabelColor = Color.LightGray, Color = Color.LightGray, ToolTip = "APPLICATION_INITIALIZE_LOW / Arch103 / 9103" };

            Arch04 = new LoggingLevel { Label = "CORE", LabelColor = Color.FromArgb(190, 190, 190), Color = Color.FromArgb(190, 190, 190), ToolTip = "CORE / Arch04 / 9004" };
            Arch05 = new LoggingLevel { Label = "MODULE", LabelColor = Color.Fuchsia, Color = Color.Fuchsia, ToolTip = "MODULE / Arch05 / 9005" };
            Arch06 = new LoggingLevel { Label = "MODULE_INITIALIZE", LabelColor = Color.LightGray, Color = Color.LightGray, ToolTip = "MODULE_INITIALIZE / Arch06 / 9006" };
            Arch07 = new LoggingLevel { Label = "DEVICE_INITIALIZE", LabelColor = Color.LightGray, Color = Color.LightGray, ToolTip = "DEVICE_INITIALIZE / Arch07 / 9007" };

            Arch10 = new LoggingLevel { Label = "APPLICATION", Color = Color.FromArgb(100, 240, 100), ToolTip = "APPLICATION / Arch10 / 9010" };
            Arch110 = new LoggingLevel { Label = "APPLICATION_LOW", Color = Color.FromArgb(100, 240, 100), ToolTip = "APPLICATION_LOW / Arch110 / 9110" };

            Arch11 = new LoggingLevel { Label = "APPLICATIONSERVICES", Color = Color.FromArgb(100, 240, 100), ToolTip = "APPLICATIONSERVICES / Arch11 / 9011" };
            Arch111 = new LoggingLevel { Label = "APPLICATIONSERVICES_LOW", Color = Color.FromArgb(100, 240, 100), ToolTip = "APPLICATIONSERVICES / Arch111 / 9111" };

            Arch12 = new LoggingLevel { Label = "DOMAIN", Color = Color.FromArgb(255, 180, 0), ToolTip = "DOMAIN / Arch12 / 9012" };
            Arch112 = new LoggingLevel { Label = "DOMAIN_LOW", Color = Color.FromArgb(255, 180, 0), ToolTip = "DOMAIN_LOW / Arch112 / 9112" };

            Arch13 = new LoggingLevel { Label = "DOMAINSERVICES", Color = Color.FromArgb(255, 180, 0), ToolTip = "DOMAINSERVICES / Arch13 / 9013" };
            Arch113 = new LoggingLevel { Label = "DOMAINSERVICES_LOW", Color = Color.FromArgb(255, 180, 0), ToolTip = "DOMAINSERVICES_LOW / Arch113 / 9113" };

            Arch14 = new LoggingLevel { Label = "INFRASTRUCTURE", Color = Color.White, ToolTip = "INFRASTRUCTURE / Arch14 / 9014" };
            Arch114 = new LoggingLevel { Label = "INFRASTRUCTURE_LOW", Color = Color.White, ToolTip = "INFRASTRUCTURE_LOW / Arch114 / 9114" };

            Arch15 = new LoggingLevel { Label = "PERSISTENCE", Color = Color.FromArgb(160, 115, 225), ToolTip = "PERSISTENCE / Arch15 / 9015" };
            Arch115 = new LoggingLevel { Label = "PERSISTENCE_LOW", Color = Color.FromArgb(160, 115, 255), ToolTip = "PERSISTENCE_LOW / Arch115 / 9115" };

            Arch16 = new LoggingLevel { Label = "PRESENTATION", Color = Color.FromArgb(0, 220, 220), ToolTip = "PRESENTATION / Arch16 / 9016" };
            Arch116 = new LoggingLevel { Label = "PRESENTATION_LOW", Color = Color.FromArgb(0, 220, 220), ToolTip = "PRESENTATION / Arch116 / 9016" };

            Arch17 = new LoggingLevel { Label = "VIEW", Color = Color.FromArgb(0, 220, 220), ToolTip = "VIEW / Arch17 / 9017" };
            Arch117 = new LoggingLevel { Label = "VIEW_LOW", Color = Color.FromArgb(0, 220, 220), ToolTip = "VIEW_LOW / Arch117 / 9117" };

            Arch18 = new LoggingLevel { Label = "VIEWMODEL", Color = Color.FromArgb(90, 255, 255), ToolTip = "VIEWMODEL / Arch18 / 9018" };
            Arch118 = new LoggingLevel { Label = "VIEWMODEL_LOW", Color = Color.FromArgb(90, 255, 255), ToolTip = "VIEWMODEL_LOW / Arch118 / 9118" };

            Arch19 = new LoggingLevel { Label = "Arch19", LabelColor = Color.FromArgb(150, 150, 150), Color = Color.FromArgb(200, 200, 200), ToolTip = "Arch19 / 9019" };
        }
    }
}