using Accessibility;
using PlatFrameworkAssemblies.BaseFramework.Attributes;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace PlatFrameworkAssemblies.RunningMonitor
{
    public class RunningParamaters
    {
        private static List<Assembly> _runningAssemblies = new List<Assembly>();
        public static List<Assembly> RunningAssemblies { get { return _runningAssemblies; } }
        public static Dictionary<string, object> RunningObjects { get; private set; }
        public static T GetParamaters<T>(string attrDescription)
        {
            if (RunningObjects != null && RunningObjects.ContainsKey(attrDescription)) return (T)RunningObjects[attrDescription];
            T objType;
            RunningObjects = new Dictionary<string, object>();
            List<object> list = new List<object>();
            foreach (Assembly assembly in RunningAssemblies)
            {
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.BaseType == typeof(T))
                    {
                        Type toRead = assembly.GetType(type.FullName);
                        AttrsPlugsAttribute attrsPlugs = (AttrsPlugsAttribute)Attribute.GetCustomAttribute(toRead, typeof(AttrsPlugsAttribute));
                        if (attrsPlugs != null && attrsPlugs.Description == attrDescription)
                        {
                            objType = (T)assembly.CreateInstance(toRead.FullName);
                            RunningObjects.Add(attrDescription, objType);
                            return objType;
                        }
                    }
                }
            }
            return default(T);
        }
    }
}
