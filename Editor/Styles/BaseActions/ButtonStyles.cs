using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Interop;

namespace Editor.Styles
{
    public partial class ButtonStyles
    {
        #region WinAPI
        /// <summary>
        /// Change window state
        /// <code>
        /// Use like : ShowWindow(new WindowInteropHelper(Application.Current.MainWindow).Handle, 2);
        /// </code>
        /// </summary>
        /// <param name="hwnd">Window Handle</param>
        /// <param name="nCmdShow">
        /// Show command
        /// <list type="table">
        /// <item>
        /// <term>1</term>
        /// <description>Normal Size</description>
        /// </item>
        /// <item>
        /// <term>2</term>
        /// <description>Minimized</description>
        /// </item>
        /// <item>
        /// <term>3</term>
        /// <description>Maxized</description>
        /// </item>
        /// </list>
        /// </param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "ShowWindow", CharSet = CharSet.Auto)]
        public extern static int ShowWindow(IntPtr hwnd, int nCmdShow);
        #endregion
        #region Functions
        /// <summary>
        /// Full Screen V1.0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullScreen(object sender, EventArgs e)
        {
            Application.Current.MainWindow.WindowState = Application.Current.MainWindow.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        /// <summary>
        /// Close Form V1.0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseForm(object sender, EventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        /// <summary>
        /// Minimize Form V1.0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizedForm(object sender, EventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        #endregion
    }
}
