﻿using System;
using System.Xml;
using Microsoft.Win32;

namespace CommunalComputerManager.RegOperation
{
    [Serializable]
    public class RegKey : RegPath
    {
        /// <summary>
        /// 
        /// </summary>
        public RegistryValueKind LpKind { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public object LpValue { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public RegKey() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hKey"></param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpValueName"></param>
        /// <param name="lpKind"></param>
        /// <param name="lpValue"></param>
        public RegKey(
            UIntPtr hKey, 
            string lpSubKey, 
            string lpValueName = "", 
            RegistryValueKind lpKind = RegistryValueKind.None, 
            object lpValue = null) :
            base(hKey,lpSubKey,lpValueName)
        {
            LpKind = lpKind;
            LpValue = lpValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regPath"></param>
        /// <param name="lpKind"></param>
        /// <param name="lpValue"></param>
        public RegKey(RegPath regPath, RegistryValueKind lpKind, object lpValue) :
            base(regPath)
        {
            LpKind = lpKind;
            LpValue = lpValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regKey"></param>
        public RegKey(RegKey regKey) :
            base(regKey.HKey, regKey.LpSubKey, regKey.LpValueName)
        {
            LpKind = regKey.LpKind;
            LpValue = regKey.LpValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="name"></param>
        /// <param name="skey"></param>
        protected new void MidExport(XmlTextWriter writer, string name, string skey = "12345678")
        {
            base.MidExport(writer, name, skey);
            writer.WriteAttributeString("lpkind", CryptStr.Encrypt(LpKind.ToString(), skey));
            writer.WriteAttributeString("lpvalue", CryptStr.Encrypt(LpValue.ToString(), skey));
        }
    }
}