using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace PlatFrameworkAssemblies.BaseFramework.Attributes
{
    [AttributeUsage(AttributeTargets.All,Inherited =false)]
    public class AttrsPlugsAttribute:Attribute
    {
        public string Description { get; private set; }
        public AttrsPlugsAttribute(string description)
        {
            Description = description;
        }
    }
}
