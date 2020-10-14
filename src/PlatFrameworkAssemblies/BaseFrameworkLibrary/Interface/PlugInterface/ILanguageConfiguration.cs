// **********************************************************************
// 
// File Name:           BaseFramework.Interface.ILanguageConfiguration
//
// Description:         Language configuration.
//
// Tables:              Nothing
//
// Author:              Lign
//
// Create Date:         2020/10/03
//
// Using:               Nothing
//
// Revision History:    Nothing
//
// **********************************************************************

using PlatFrameworkAssemblies.BaseFramework.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Xaml;

namespace PlatFrameworkAssemblies.BaseFramework.Interface.PlugInterface
{
    /// <summary>
    /// Language configuration
    /// </summary>
    [AttrsLanguage("All")]
    public interface ILanguageConfiguration
    {
        /// <summary>
        /// Language name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// ControlText_File
        /// </summary>
        public string ControlText_File { get; }

        /// <summary>
        /// ControlText_Edit
        /// </summary>
        public string ControlText_Edit { get; }

        /// <summary>
        /// ControlText_View
        /// </summary>
        public string ControlText_View { get; }

        /// <summary>
        /// ControlText_Open
        /// </summary>
        public string ControlText_Open { get; }

        /// <summary>
        /// ControlText_Close
        /// </summary>
        public string ControlText_Close { get; }
        
        /// <summary>
        /// ControlText_Edit
        /// </summary>
        public string ControlText_Exit { get; }

        /// <summary>
        /// Get resources.
        /// </summary>
        /// <returns>Resource dictionary</returns>
        public ResourceDictionary GetResourceDictionary()
        {
            ResourceDictionary dicts = new ResourceDictionary();
            dicts.Add("ControlText_View", ControlText_View);
            dicts.Add("ControlText_File", ControlText_File);
            dicts.Add("ControlText_Edit", ControlText_Edit);
            dicts.Add("ControlText_Exit", ControlText_Exit);
            dicts.Add("ControlText_Open", ControlText_Open);
            dicts.Add("ControlText_Close", ControlText_Close);
            return dicts;
        }

        public static List<ILanguageConfiguration> GetAllLanguage()
        {
            return null;
        }
    }
}
