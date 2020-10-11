using PlatFrameworkAssemblies.BaseFramework.Attributes;
using PlatFrameworkAssemblies.BaseFramework.Interface.PlugInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PlatFrameworkAssemblies.BaseFramework.Resources.LANG
{
    [AttrsLanguage("en_US")]
    public class en_US : ILanguageConfiguration
    {
        public string Name { get { return "English"; } }
        public string ControlText_File { get { return "File"; } }
        public string ControlText_Edit { get { return "Edit"; } }
        public string ControlText_View { get { return "View"; } }
        public string ControlText_Open { get { return "Open"; } }
        public string ControlText_Close { get { return "Close"; } }
        public string ControlText_Exit { get { return "Exit"; } }
    }
}
