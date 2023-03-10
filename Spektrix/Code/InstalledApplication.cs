using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Spektrix.Code
{
    /**
     * Credit to vadimffe.
     * https://github.com/vadimffe/InstalledAppsViewer
     */
    class InstalledApp
    {
        public string DisplayName { get; set; }
        public string InstallationLocation { get; set; }
    }

    class InstalledApplication
    {
        private static List<InstalledApp> GetInstalledApplication(RegistryKey regKey, string registryKey)
        {
            List<InstalledApp> list = new List<InstalledApp>();
            using (Microsoft.Win32.RegistryKey key = regKey.OpenSubKey(registryKey))
            {
                if (key == null) return list;
                foreach (string name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(name))
                    {
                        string installLocation = (string)subkey.GetValue("InstallLocation") ?? (string)subkey.GetValue("");

                        if (string.IsNullOrEmpty(installLocation)) continue;
                        installLocation = installLocation.Trim().Replace(@"\\", @"/").Replace(@"\", @"/").Replace("\"", "");
                        if (Uri.IsWellFormedUriString(installLocation, UriKind.Absolute)) continue;

                        string displayName = (string)subkey.GetValue("DisplayName");
                        displayName = !string.IsNullOrEmpty(displayName) ? displayName : Path.GetFileNameWithoutExtension(installLocation).Trim();
                        installLocation = Regex.Replace(installLocation, $"/{displayName}.exe", "", RegexOptions.IgnoreCase);
                        installLocation = (!installLocation.EndsWith("/")) ? installLocation + "/" : installLocation;

                        list.Add(new InstalledApp()
                        {
                            DisplayName = displayName.Trim(),
                            InstallationLocation = installLocation
                        });
                    }
                }

            }
            return list;
        }

        public List<InstalledApp> GetFullListInstalledApplication()
        {
            IEnumerable<InstalledApp> finalList = new List<InstalledApp>();

            string registry = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths";
            string registry_key_32 = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            string registry_key_64 = @"SOFTWARE\WoW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

            List<InstalledApp> win32AppsCU = GetInstalledApplication(Registry.CurrentUser, registry_key_32);
            List<InstalledApp> win32AppsLM = GetInstalledApplication(Registry.LocalMachine, registry_key_32);
            List<InstalledApp> win64AppsCU = GetInstalledApplication(Registry.CurrentUser, registry_key_64);
            List<InstalledApp> win64AppsLM = GetInstalledApplication(Registry.LocalMachine, registry_key_64);
            List<InstalledApp> Apps = GetInstalledApplication(Registry.LocalMachine, registry);

            finalList = win32AppsCU.Concat(win32AppsLM).Concat(win64AppsCU).Concat(win64AppsLM).Concat(Apps);

            finalList = finalList.GroupBy(d => d.DisplayName).Select(d => d.First());

            return finalList.ToList();
        }

    }
}