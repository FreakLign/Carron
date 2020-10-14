// **********************************************************************
// 
// File Name:           BaseFramework.program
//
// Description:         Program entrance.
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

using PlatFrameworkAssemblies.RunTimeLogger;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ProgramEntrance
{
    /// <summary>
    /// program entry point
    /// </summary>
    class program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        public static void Main(string[] args)
        {
            Logger.WriteLog(new NoticeResult("Loading..."));
            Entrance.StartProgram();
        }
    }
}
