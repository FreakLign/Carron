// **********************************************************************
// 
// File Name:           RunTimeLogger.RunTimeLogger
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
using System.Collections.Generic;
using System.Text;

namespace PlatFrameworkAssemblies.RunTimeLogger
{
    /// <summary>
    /// Object of Notice message
    /// </summary>
    public class NoticeResult
    {
        #region Private Field
        private string _message;            // Content of the message
        private Exception _exception;       // Exception message
        private long _index = -1;           // Index of notice
        private object _tag;                // Additional infos or data
        private Action _delegateAction;     // Delegate action
        #endregion

        #region Attributes
        /// <summary>
        /// Content of the message
        /// </summary>
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        /// <summary>
        /// Exception message
        /// </summary>
        public Exception Exception
        {
            get { return _exception; }
        }
        /// <summary>
        /// Index of notice
        /// </summary>
        public long Index
        {
            get { return _index; }
        }
        /// <summary>
        /// Additional infos or data
        /// </summary>
        public object Tag
        {
            get { return _tag; }
        }
        /// <summary>
        /// Delegate action
        /// </summary>
        public Action DelegateAction
        {
            get { return _delegateAction; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="message">Message content</param>
        public NoticeResult(string message)
        {
            _message = message;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="message">Message content</param>
        /// <param name="index">Index of notice</param>
        public NoticeResult(string message,int index)
        {
            _message = message;
            _index = index;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="message">Message content</param>
        /// <param name="index">Index of notice</param>
        public NoticeResult(string message,long index)
        {
            _message = message;
            _index = index;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="message">Message content</param>
        /// <param name="tag">Additional infos or data</param>
        public NoticeResult(string message,object tag)
        {
            _message = message;
            _tag = tag;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="message">Message content</param>
        /// <param name="index">Index of notice</param>
        /// <param name="tag">Additional infos or data</param>
        public NoticeResult(string message, int index, object tag)
        {
            _message = message;
            _index = index;
            _tag = tag;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="message">Message content</param>
        /// <param name="index">Index of notice</param>
        /// <param name="tag">Addditional infos or data</param>
        public NoticeResult(string message, long index, object tag)
        {
            _message = message;
            _index = index;
            _tag = tag;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="exception">Exception</param>
        public NoticeResult(Exception exception)
        {
            _exception = exception;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="exception">Exception</param>
        /// <param name="index">Index of notice</param>
        public NoticeResult(Exception exception,int index)
        {
            _exception = exception;
            _index = index;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="exception">Exception</param>
        /// <param name="index">Index of notice</param>
        public NoticeResult(Exception exception, long index)
        {
            _exception = exception;
            _index = index;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="tag">Additonal infos or data</param>
        public NoticeResult(object tag)
        {
            _tag = tag;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        public NoticeResult()
        {

        }
        // <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="message">Message content</param>
        /// <param name="action">Delegate action</param>
        public NoticeResult(string message,Action action)
        {
            _message = message;
            _delegateAction = action;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="message">Message content</param>
        /// <param name="index">Index of notice</param>
        /// <param name="action">Delegate action</param>
        public NoticeResult(string message, int index, Action action)
        {
            _message = message;
            _delegateAction = action;
            _index = index;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="message">Message content</param>
        /// <param name="index">Index of notice</param>
        public NoticeResult(string message, long index, Action action)
        {
            _message = message;
            _index = index;
            _delegateAction = action;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="message">Message content</param>
        /// <param name="tag">Additional infos or data</param>
        /// <param name="action">Delegate action</param>
        public NoticeResult(string message, object tag, Action action)
        {
            _message = message;
            _delegateAction = action;
            _tag = tag;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="message">Message content</param>
        /// <param name="index">Index of notice</param>
        /// <param name="tag">Additional infos or data</param>
        /// <param name="action">Delegate action</param>
        public NoticeResult(string message, int index, object tag, Action action)
        {
            _message = message;
            _index = index;
            _delegateAction = action;
            _tag = tag;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="message">Message content</param>
        /// <param name="index">Index of notice</param>
        /// <param name="tag">Addditional infos or data</param>
        public NoticeResult(string message, long index, object tag, Action action)
        {
            _message = message;
            _index = index;
            _tag = tag;
            _delegateAction = action;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="exception">Exception</param>
        /// <param name="action">Delegate action</param>
        public NoticeResult(Exception exception, Action action)
        {
            _exception = exception;
            _delegateAction = action;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="exception">Exception</param>
        /// <param name="index">Index of notice</param>
        /// <param name="action">Delegate action</param>
        public NoticeResult(Exception exception, int index, Action action)
        {
            _exception = exception;
            _index = index;
            _delegateAction = action;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="exception">Exception</param>
        /// <param name="index">Index of notice</param>
        /// <param name="action">Delegate action</param>
        public NoticeResult(Exception exception, long index, Action action)
        {
            _exception = exception;
            _index = index;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="tag">Additonal infos or data</param>
        /// <param name="action">Delegate action</param>
        public NoticeResult(object tag, Action action)
        {
            _delegateAction = action;
            _tag = tag;
        }
        /// <summary>
        /// Object of Notice message
        /// </summary>
        /// <param name="action">Delegate action</param>
        public NoticeResult(Action action)
        {
            _delegateAction = action;
        }
        #endregion
    }
}
