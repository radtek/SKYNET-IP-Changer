using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lol.frmMain;

namespace NetManager
{
    public class RegistrySettings
    {
        public static RegistryKey XNova { get; private set; }

        public static void Initialice()
        {
            XNova = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\[SKYNET] IP Changer\", true);
            if (XNova == null)
            {
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\[SKYNET] IP Changer\");
                XNova = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\[SKYNET] IP Changer\", true);

                frm.txtIP.Text = modCommon.GetIP();
                frm.txtMask.Text = "255.255.255.0";
                SaveSettings();

            }
        }

        public static void SaveSettings()
        {
            try { XNova.SetValue("IP", frm.txtIP.Text); } catch { }
            try { XNova.SetValue("Mask", frm.txtMask.Text); } catch { }
            try { XNova.SetValue("Gateway", frm.txtGateway.Text); } catch { }
            try { XNova.SetValue("DNS", frm.txtDNS.Text); } catch { }
        }
        public static void LoadSettings()
        {
            try { frm.txtIP.Text = (string)XNova.GetValue("IP", RegistryValueKind.String); } catch { }
            try { frm.txtMask.Text = (string)XNova.GetValue("Mask", RegistryValueKind.String); } catch { }
            try { frm.txtGateway.Text = (string)XNova.GetValue("Gateway", RegistryValueKind.String); } catch { }
            try { frm.txtDNS.Text = (string)XNova.GetValue("DNS", RegistryValueKind.String); } catch { }
        }

    }

}
