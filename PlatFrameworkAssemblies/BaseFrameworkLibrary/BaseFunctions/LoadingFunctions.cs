using PlatFrameworkAssemblies.RunTimeLogger;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PlatFrameworkAssemblies.BaseFramework.BaseFunctions
{
    public class LoadingFunctions
    {
        /// <summary>
        /// Check assembly file is wheather CLR.
        /// </summary>
        /// <returns></returns>
        public static Assembly CheckAssemblyFile(string assemblyPath)
        {
            try
            {
                Logger.WriteLog(new NoticeResult($"Trying to load {assemblyPath} ..."));
                Assembly assembly = Assembly.LoadFile(assemblyPath);
                Logger.WriteLog(new NoticeResult($"{assemblyPath} Loaded."));
                return assembly;
            }
            catch (Exception ex)
            {
                if (ex is BadImageFormatException)
                {
                    Logger.WriteLog(new NoticeResult($"{assemblyPath} is not a CLR assembly."));
                    return null;
                }
                else
                {
                    throw ex;
                }
            }
        }
    }
}
