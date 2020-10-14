using PlatFrameworkAssemblies.BaseFramework.Attributes;
using PlatFrameworkAssemblies.BaseFramework.BaseFunctions;
using PlatFrameworkAssemblies.RunningMonitor;
using PlatFrameworkAssemblies.RunTimeLogger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NevolEditor.LoadingProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [AttrsPlugs("LoadingForm")]
    public partial class LoadingForm : Window
    {
        public LoadingForm()
        {
            Logger.WriteLog(new NoticeResult("Starting rending form..."));
            InitializeComponent();
            Logger.WriteLog(new NoticeResult("Rending form complete!"));
        }

        #region override
        protected override void OnClosing(CancelEventArgs e)
        {
            Logger.WriteLog(new NoticeResult("Main Form closing..."));
            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            Logger.WriteLog(new NoticeResult("Main Form closed"));
            base.OnClosed(e);
        }
        #endregion

        #region Method
        #endregion
    }
}
