using PlatFrameworkAssemblies.BaseFramework.Attributes;
using PlatFrameworkAssemblies.BaseFramework.Interface.PlugInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PlatFrameworkAssemblies.BaseFramework.Resources.LANG
{
    [AttrsLanguage("zh_CN")]
    public class zh_CN : ILanguageConfiguration
    {
        public string Name { get { return "中文"; } }
        public string ControlText_File { get { return "文件"; } }
        public string ControlText_Edit { get { return "编辑"; } }
        public string ControlText_View { get { return "视图"; } }
        public string ControlText_Open { get { return "打开"; } }
        public string ControlText_Close { get { return "关闭"; } }
        public string ControlText_Exit { get { return "退出"; } }
    }
}
