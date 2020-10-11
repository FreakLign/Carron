using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PlatFrameworkAssemblies.BaseFramework.Interface
{
    public interface IProgram
    {
        /// <summary>
        /// The Main window
        /// </summary>
        public Window MainWindow { get; }

        /// <summary>
        /// The loading window
        /// </summary>
        public Window LoadingWindow { get; }
    }
}
