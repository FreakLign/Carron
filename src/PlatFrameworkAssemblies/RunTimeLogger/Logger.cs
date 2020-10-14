// **********************************************************************
// 
// File Name:           RunTimeLogger.Logger
//
// Description:         The Object to send to logger.
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


using System;
using System.Diagnostics;
using System.Security.RightsManagement;

namespace PlatFrameworkAssemblies.RunTimeLogger
{
    /// <summary>
    /// Logger
    /// </summary>
    public class Logger
    {
        #region Private field
        private static int _index = 1;
        #endregion

        #region Event
        public static event Action<string> LogHandler;              // Handle data when log is record.
        public static event Action<Exception> ExceptionHandler;     // Handle data when exception is record.
        #endregion

        #region Public Functions
        /// <summary>
        /// Write a Log and raise a handle when handler is aviliable.
        /// </summary>
        /// <param name="notice">Log content</param>
        public static void WriteLog(NoticeResult notice)
        {
            string content = string.Format("{0}  {1,-4}:  ", DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss:fffffff"), notice.Index == -1 ? _index++ : notice.Index);
            if (notice.Message != null) content += notice.Message + "\t";
            if (LogHandler != null) LogHandler(content);
            Console.WriteLine($"{content}");
        }
        /// <summary>
        /// Write a Exception and raise a handle when handler is aviliable.
        /// </summary>
        /// <param name="notice">Exception content</param>
        public static void WriteException(NoticeResult notice)
        {
            string content = string.Format("{0}  {1,-4}:  ", DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss:fffffff"), notice.Index == -1 ? _index++ : notice.Index);
            if (notice.Exception != null) content += notice.Exception.ToString() + "\t";
            if (ExceptionHandler != null) ExceptionHandler(notice.Exception);
            Console.WriteLine($"{content}");
        }
        /// <summary>
        /// Write a Message.
        /// </summary>
        /// <param name="notice">Message</param>
        public static void WriteMessage(NoticeResult notice)
        {
            string content = string.Format("{0}  {1,-4}:  ", DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss:fffffff"), notice.Index == -1 ? _index++ : notice.Index);
            Console.WriteLine($"{content}");
        }
        #endregion
    }
}
