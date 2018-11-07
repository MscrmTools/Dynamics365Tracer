using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Dynamics365Tracer.AppCode
{
    /// <summary>
    /// This class is used to retrieve of define registry keys
    /// </summary>
    public static class RegistryHelper
    {
        /// <summary>
        /// Evaluate an Integer registry value
        /// </summary>
        /// <param name="optionName">Name of the Registry Value</param>
        /// <param name="regKeyPath">Path to the Registry Hive</param>
        /// <returns></returns>
        public static int EvaluateInteger(string optionName, string regKeyPath)
        {
            using (RegistryKey regKey = OpenSubKey(regKeyPath))
            {
                return (int?)regKey?.GetValue(optionName, 0) ?? 0;
            }
        }

        /// <summary>
        /// Evaluates a string.
        /// </summary>
        /// <param name="optionName">Option name.</param>
        /// <returns>Option value.</returns>
        public static List<string> EvaluateMultiString(string optionName, string regKeyPath)
        {
            using (RegistryKey regKey = OpenSubKey(regKeyPath))
            {
                string[] value = (string[])regKey.GetValue(optionName, null);

                if (value == null)
                    return new List<string>();

                return value.ToList();
            }
        }

        /// <summary>
        /// Evaluates if an option is set.
        /// </summary>
        /// <param name="optionName">Option name.</param>
        /// <returns>True if the option is set.</returns>
        public static bool EvaluateOption(string optionName, string regKeyPath)
        {
            using (RegistryKey regKey = OpenSubKey(regKeyPath))
            {
                if (regKey == null)
                {
                    throw new NotCrmServerException();
                }
                return 0 != (int)regKey.GetValue(optionName, 0);
            }
        }

        /// <summary>
        /// Evaluates a string.
        /// </summary>
        /// <param name="optionName">Option name.</param>
        /// <returns>Option value.</returns>
        public static string EvaluateString(string optionName, string regKeyPath)
        {
            using (RegistryKey regKey = OpenSubKey(regKeyPath))
            {
                if (regKey == null)
                {
                    throw new NotCrmServerException();
                }

                object value = regKey.GetValue(optionName, null);

                if (value == null)
                    return null;
                if (value is string[] strings)
                    return strings[0];

                return value.ToString();
            }
        }

        /// <summary>
        /// Checks wether a key file exists
        /// </summary>
        /// <param name="regKeyPath"></param>
        /// <returns></returns>
        public static bool KeyExists(string regKeyPath)
        {
            try
            {
                RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "");

                using (RegistryKey regKey = OpenSubKey(regKeyPath))
                {
                    return regKey != null;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Sets or clear an numeric registry value.
        /// </summary>
        /// <param name="regKeyPath">Reg Key Path to the value.</param>
        /// <param name="optionName">Option name.</param>
        /// <param name="value">Option value.</param>
        public static void SetInteger(string regKeyPath, string optionName, int value)
        {
            using (RegistryKey regKey = OpenSubKey(regKeyPath, true))
            {
                if (value != 0)
                {
                    regKey.SetValue(optionName, value, RegistryValueKind.DWord);
                }
                else
                {
                    regKey.DeleteValue(optionName, false);
                }
            }
        }

        /// <summary>
        /// Sets or clear a string.
        /// </summary>
        /// <param name="regKeyPath">Reg Key Path to the value.</param>
        /// <param name="optionName">Option name.</param>
        /// <param name="value">Option value.</param>
        public static void SetMultiString(string regKeyPath, string optionName, List<string> value)
        {
            using (RegistryKey regKey = OpenSubKey(regKeyPath, true))
            {
                regKey.SetValue(optionName, value.ToArray(), RegistryValueKind.MultiString);
            }
        }

        /// <summary>
        /// Sets or clear an option.
        /// </summary>
        /// <param name="regKeyPath">Reg Key Path to the value.</param>
        /// <param name="optionName">Option name.</param>
        /// <param name="value">Option value.</param>
        public static void SetOption(string regKeyPath, string optionName, bool value)
        {
            using (RegistryKey regKey = OpenSubKey(regKeyPath, true))
            {
                if (value)
                {
                    regKey.SetValue(optionName, 1);
                }
                else
                {
                    // actually i discovered it's better to turn off an option putting the
                    // bit to zero instead of deleting the key....
                    // CRM understand better the change.

                    //regKey.DeleteValue(optionName, false);

                    regKey.SetValue(optionName, 0);
                }
            }
        }

        /// <summary>
        /// Sets or clear a string.
        /// </summary>
        /// <param name="regKeyPath">Reg Key Path to the value.</param>
        /// <param name="optionName">Option name.</param>
        /// <param name="value">Option value.</param>
        public static void SetString(string regKeyPath, string optionName, string value)
        {
            using (RegistryKey regKey = OpenSubKey(regKeyPath, true))
            {
                if (!String.IsNullOrEmpty(value))
                {
                    regKey.SetValue(optionName, value);
                }
                else
                {
                    regKey.DeleteValue(optionName, false);
                }
            }
        }

        /// <summary>
        /// Retrieves a list of registry keys
        /// </summary>
        /// <param name="regKeyPath">Path of the registry key</param>
        /// <returns>List of registry keys</returns>
        internal static Dictionary<string, string> GetAllKeys(string regKeyPath)
        {
            Dictionary<string, string> rKeys = new Dictionary<string, string>();

            using (RegistryKey regKey = OpenSubKey(regKeyPath))
            {
                if (regKey == null)
                    return rKeys;

                foreach (string valueName in regKey.GetValueNames())
                {
                    rKeys.Add(valueName, regKey.GetValue(valueName).ToString());
                }

                var list = rKeys.Keys.ToList();
                list.Sort();

                // Write subkey values
                foreach (string keyName in regKey.GetSubKeyNames())
                {
                    using (RegistryKey subRegKey = regKey.OpenSubKey(keyName))
                    {
                        Dictionary<string, string> subKeys = GetAllKeys(subRegKey.Name);

                        foreach (string key in subKeys.Keys)
                        {
                            rKeys.Add(key, subKeys[key]);
                        }
                    }
                }
            }

            return rKeys;
        }

        /// <summary>
        /// Retrieves a list of registry keys with their path included
        /// </summary>
        /// <param name="regKeyPath">Path of the registry key</param>
        /// <returns>List of registry keys</returns>
        internal static Dictionary<string, string> GetAllKeysWithPath(string regKeyPath)
        {
            Dictionary<string, string> rKeys = new Dictionary<string, string>();

            using (RegistryKey regKey = OpenSubKey(regKeyPath))
            {
                if (regKey == null)
                {
                    return rKeys;
                }

                foreach (string valueName in regKey.GetValueNames())
                {
                    string path = string.Format(CultureInfo.InvariantCulture, @"{0}[{1}]", regKey.ToString(), valueName);
                    rKeys.Add(path, regKey.GetValue(valueName).ToString());
                }

                var list = rKeys.Keys.ToList();
                list.Sort();

                // Write subkey values
                foreach (string keyName in regKey.GetSubKeyNames())
                {
                    using (RegistryKey subRegKey = regKey.OpenSubKey(keyName))
                    {
                        Dictionary<string, string> subKeys = GetAllKeys(subRegKey.Name);

                        foreach (string key in subKeys.Keys)
                        {
                            rKeys.Add(key, subKeys[key]);
                        }
                    }
                }
            }

            return rKeys;
        }

        internal static List<string> GetSubKeyNames(string regKeyPath)
        {
            using (RegistryKey regKey = OpenSubKey(regKeyPath))
            {
                if (regKey == null)
                {
                    return new List<string>();
                }

                return regKey.GetSubKeyNames().ToList();
            }
        }

        private static RegistryKey OpenSubKey(string regKeyPath, bool writeable = false)
        {
            RegistryKey localMachine;
            localMachine = Directory.Exists("C:\\Windows\\SysWOW64")
                ? RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
                : Registry.LocalMachine;

            return localMachine.OpenSubKey(regKeyPath, writeable);
        }
    }
}