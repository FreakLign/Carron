using ImageResources.Resources;
using System;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace ImageResources
{
    [MarkupExtensionReturnType(typeof(BindingExpression))]
    public class Handler : MarkupExtension
    {
        [ConstructorArgument("key")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>
        /// 获取资源内容
        /// </summary>
        public string Value { get { return LoadingForm.ResourceManager.GetString(Key); } }

        public Handler(string key)
            : this()
        {
            Key = key;
        }

        public Handler()
        {
        }
        //public static void GetImage(string name);
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            Binding binding = new Binding("Value") { Source = this, Mode = BindingMode.OneWay };
            return binding.ProvideValue(serviceProvider);
        }
    }
}
