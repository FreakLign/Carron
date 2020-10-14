// **********************************************************************
// 
// File Name:           BaseFramework
//
// Description:         This is the base framework of NevolEditor.
//
// Tables:              Nothing
//
// Author:              Lign
//
// Create Date:         2020/10/02
//
// Using:               Nothing
//
// Revision History:    Nothing
//
// **********************************************************************

using PlatFrameworkAssemblies.BaseFramework.Attributes;
using PlatFrameworkAssemblies.BaseFramework.BaseFunctions;
using PlatFrameworkAssemblies.BaseFramework.Interface.PlugInterface;
using PlatFrameworkAssemblies.BaseFramework.Resources.LANG;
using PlatFrameworkAssemblies.RunningMonitor;
using PlatFrameworkAssemblies.RunTimeLogger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Documents;
using System.Xml.Schema;

namespace ProgramEntrance
{
    /// <summary>
    /// Program Loading Entrance
    /// </summary>
    public class Entrance
    {
        #region Private Field
        private static Application _app = new Application();
        private static Window _currentWindow;                   // Current Window
        private static ResourceDictionary _currentResource;     // Current resource
        private static string _loadingText = "";                // Loading Text
        private static event Action<string> _loadingEvent;      // Loading event
        #endregion

        #region Constructor
        static Entrance()
        {

        }

        public Entrance()
        {

        }
        #endregion

        #region Attribute
        /// <summary>
        /// Loading text
        /// </summary>
        public static string LoadingText
        {
            get { return _loadingText; }
            set { _loadingText = value; }
        }

        /// <summary>
        /// Language
        /// </summary>
        public ILanguageConfiguration Language { get; set; }

        #endregion

        #region Event
        #endregion

        #region Common Fucntion
        /// <summary>
        /// Set Default Language of Window.
        /// </summary>
        /// <param name="window">Target window</param>
        /// <param name="language">Target Language</param>
        public static ResourceDictionary SetLanguage(ILanguageConfiguration language)
        {
            return language.GetResourceDictionary();
        }

        /// <summary>
        /// Load GUI Form
        /// </summary>
        public static void LoadWindow()
        {
            ReadLoadingAssembly();
            try
            {
                SetLoadingText();
                ReadDllAsAssembly();
                _currentResource = SetLanguage(new en_US());
                _app.Resources.MergedDictionaries.Add(_currentResource);
                _currentWindow = RunningParamaters.GetParamaters<Window>("LoadingForm");
                _app.Run(_currentWindow);
            }
            catch (Exception e)
            {
                Logger.WriteException(new NoticeResult(e));
            }
            Logger.WriteLog(new NoticeResult("UnLoading..."));
        }

        /// <summary>
        /// Start GUI Program
        /// </summary>
        public static void StartProgram()
        {
            LoadWindow();
        }

        #endregion

        #region Private Function
        /// <summary>
        /// Read loading assembly(Style & Form)
        /// </summary>
        private static void ReadLoadingAssembly()
        {
            Assembly fluentWPFAssembly = LoadingFunctions.CheckAssemblyFile(Environment.CurrentDirectory + @"\FluentWPF.dll");
            if (fluentWPFAssembly != null && !RunningParamaters.RunningAssemblies.Contains(fluentWPFAssembly))
            {
                Logger.WriteLog(new NoticeResult("Loading Styles..."));
                RunningParamaters.RunningAssemblies.Add(fluentWPFAssembly);
            }
            Assembly loadingAssembly = LoadingFunctions.CheckAssemblyFile(Environment.CurrentDirectory + @"\LoadingFormDll.dll");
            if (loadingAssembly != null && !RunningParamaters.RunningAssemblies.Contains(loadingAssembly))
            {
                Logger.WriteLog(new NoticeResult("Initializing GUI..."));
                RunningParamaters.RunningAssemblies.Add(loadingAssembly);
            }
        }

        /// <summary>
        /// Load *.dll assemblies into program.
        /// </summary>
        private static void ReadDllAsAssembly()
        {
            ThreadPool.QueueUserWorkItem((e) =>
            {
                Thread.Sleep(3000);
                foreach (string fileName in Directory.GetFiles(Environment.CurrentDirectory))
                {
                    if (Path.GetExtension(fileName).ToLower() == ".dll")
                    {
                        Assembly assembly = LoadingFunctions.CheckAssemblyFile(fileName);
                        if (assembly != null && !RunningParamaters.RunningAssemblies.Contains(assembly))
                        {
                            UpdateLoadingText($"Loading {assembly.GetName().Name}...");
                            RunningParamaters.RunningAssemblies.Add(assembly);
                        }
                    }
                }
                _app.Dispatcher.Invoke(() =>
                {
                    Window tempWindow = _app.MainWindow;
                    Assembly MaterialDesignColorAssembly = LoadingFunctions.CheckAssemblyFile(Environment.CurrentDirectory + @"\MaterialDesignColors.dll");
                    if (MaterialDesignColorAssembly != null && !RunningParamaters.RunningAssemblies.Contains(MaterialDesignColorAssembly))
                    {
                        Logger.WriteLog(new NoticeResult("Loading Styles..."));
                        RunningParamaters.RunningAssemblies.Add(MaterialDesignColorAssembly);

                    }
                    Assembly MaterialDesignThemeAssembly = LoadingFunctions.CheckAssemblyFile(Environment.CurrentDirectory + @"\MaterialDesignThemes.Wpf.dll");
                    if (MaterialDesignThemeAssembly != null && !RunningParamaters.RunningAssemblies.Contains(MaterialDesignThemeAssembly))
                    {
                        Logger.WriteLog(new NoticeResult("Loading Styles..."));
                        RunningParamaters.RunningAssemblies.Add(MaterialDesignThemeAssembly);
                    }
                    
                    _app.MainWindow = RunningParamaters.GetParamaters<Window>("EditorForm");
                    _app.MainWindow.Show();
                    tempWindow.Close();
                });
            });
        }

        /// <summary>
        /// Update loading text
        /// </summary>
        /// <param name="text">Text to display</param>
        private static void UpdateLoadingText(string text)
        {
            if (_loadingEvent != null)
            {
                _loadingEvent(text);
            }
        }

        /// <summary>
        /// RegistLoadingEvent
        /// </summary>
        /// <param name="app">Target application</param>
        private static void SetLoadingText()
        {
            _loadingEvent += (text) =>
            {
                if (!_app.Resources.Contains("LoadingText"))
                {
                    ResourceDictionary loadingText = new ResourceDictionary();
                    loadingText.Add("LoadingText", text);
                    _app.Resources.MergedDictionaries.Add(loadingText);
                }
                else
                {
                    _app.Resources["LoadingText"] = text;
                }
            };
        }
        #endregion
    }
}