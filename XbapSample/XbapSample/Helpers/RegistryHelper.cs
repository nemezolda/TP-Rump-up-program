using Microsoft.Win32;
using System;
using System.Security.Permissions;

namespace XbapSample.Helpers
{
    public static class RegistryHelper
    {
        public static string GetRegistryKeyValue(string path, string name)
        {
            string returnValue = string.Empty;
            if (SecurityManager.IsPermissionGranted(new RegistryPermission(PermissionState.Unrestricted)))
            {
                try
                {
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path))
                    {
                        if (key != null)
                        {
                            Object o = key.GetValue(name);
                            if (o != null)
                            {
                                returnValue = o.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                returnValue = "Access to registry is denied.";
            }

            return returnValue;
        }
    }
}
