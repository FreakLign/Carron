// **********************************************************************
// 
// File Name:           BaseFramework.Interface.IEncryptionMethod
//
// Description:         Interface of encrypt method.
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

namespace PlatFrameworkAssemblies.BaseFramework.Interface.PlugInterface
{
    /// <summary>
    /// Encryt data or decrypt data from code.
    /// </summary>
    interface IEncryptionMethod
    {
        /// <summary>
        /// Method name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Encrypt Data
        /// </summary>
        /// <param name="things">Data</param>
        /// <returns>Encrypted code</returns>
        public object Encrypt(object things);
        /// <summary>
        /// Decrypt Data
        /// </summary>
        /// <param name="codes"><Data/param>
        /// <returns>Decrypted data</returns>
        public object Decrypt(object codes);
    }
}
