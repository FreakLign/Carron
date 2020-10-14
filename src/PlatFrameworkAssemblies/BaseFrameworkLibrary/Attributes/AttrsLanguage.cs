using System;
using System.Collections.Generic;
using System.Text;

namespace PlatFrameworkAssemblies.BaseFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Interface,AllowMultiple = false)]
    public class AttrsLanguage:Attribute
    {
        protected string description;
        public string Description { get { return description; } }
        public AttrsLanguage(string Description)
        {
            description = Description;
        }
    }
}
