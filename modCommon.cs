using System;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

public class modCommon
{
    public static SizeF GetTextSize(string text, Font font)
    {
        using (Graphics graphics = Graphics.FromImage((Image)new Bitmap(1, 1)))
            return graphics.MeasureString(text, font);
    }

    public static string GetIP()
    {
        string Ip = "";
        bool isNetworkUp = NetworkInterface.GetIsNetworkAvailable();
        if (isNetworkUp)
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    Ip = ip.ToString();
                }
            }
        }
        return Ip;
    }

    internal static void Show(object message)
    {
        MessageBox.Show(message.ToString());
    }
}