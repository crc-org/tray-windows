using System;
using System.Drawing;
using System.Windows.Forms;

namespace CRCTray.Helpers
{
    class TrayIcon : IDisposable    
    {
        //tray Icon
        private static NotifyIcon notifyIcon;

        public TrayIcon(Bitmap icon, string name)
        {
            notifyIcon = new NotifyIcon
            {
                Icon = Icon.FromHandle(icon.GetHicon()),
                Visible = true
            };
            notifyIcon.Text = name;
            notifyIcon.MouseClick += NotifyIcon_MouseClick;
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            ShowContextMenu();
        }

        public static void NotifyError(string message)
        {
            if (String.IsNullOrEmpty(message))
                message = "Error occurred";
            Notification(message, ToolTipIcon.Error);
        }

        public static void NotifyWarn(string message)
        {
            Notification(message, ToolTipIcon.Warning);
        }

        public static void NotifyInfo(string message)
        {
            Notification(message, ToolTipIcon.Info);
        }

        private static void Notification(string msg, ToolTipIcon toolTipIcon)
        {
            if (notifyIcon == null)
                return;     // prevent use before being created

            notifyIcon.BalloonTipIcon = toolTipIcon;
            notifyIcon.BalloonTipText = msg;

            notifyIcon.ShowBalloonTip(3);
        }

        public void ShowContextMenu()
        {
            typeof(NotifyIcon).GetMethod("ShowContextMenu", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(notifyIcon, null);
        }

        public void Dispose()
        {
            notifyIcon.Dispose();
        }

        public ContextMenuStrip ContextMenuStrip
        {
            set
            {
                notifyIcon.ContextMenuStrip = value;
            }
            get
            {
                return notifyIcon.ContextMenuStrip;
            }
        }

        public bool Visible
        {
            set
            {
                notifyIcon.Visible = value;
            }
            get
            {
                return notifyIcon.Visible;
            }
        }
    }

}
