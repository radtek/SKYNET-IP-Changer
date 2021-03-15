using System;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Win32;


public class NetworkConfigurator
{
    /// <param name="ipAddress">The IP Address</param>
    /// <param name="subnetMask">The Submask IP Address</param>
    /// <param name="gateway">The gateway.</param>
    static string[] IPs = new string[2];

    public static void SetIP(string ipAddress, string subnetMask)
    {
        using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
        {
            using (var networkConfigs = networkConfigMng.GetInstances())
            {
                foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"]))
                {
                    using (ManagementBaseObject newIP = managementObject.GetMethodParameters("EnableStatic"))
                    {
                        // Set new IP address and subnet if needed
                        if ((!String.IsNullOrEmpty(ipAddress)) || (!String.IsNullOrEmpty(subnetMask)))
                        {
                            if (!String.IsNullOrEmpty(ipAddress))
                            {
                                newIP["IPAddress"] = new[] { ipAddress };
                            }

                            if (!String.IsNullOrEmpty(subnetMask))
                            {
                                newIP["SubnetMask"] = new[] { subnetMask };
                            }

                            managementObject.InvokeMethod("EnableStatic", newIP, null);
                        }
                    }
                }
            }
        }
    }
    public static void SetGateway(string DnsString)
    {
        string[] Dns = { DnsString };
        using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
        {
            using (var networkConfigs = networkConfigMng.GetInstances())
            {
                foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"]))
                {
                    using (ManagementBaseObject objdns = managementObject.GetMethodParameters("SetGateways"))
                    {
                        objdns["DefaultIPGateway"] = Dns;
                        objdns["GatewayCostMetric"] = new[] { 1 };
                        managementObject.InvokeMethod("SetGateways", objdns, null);
                    }
                }
            }
        }
    }
    internal static void SetDHCP()
    {
        using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
        {
            using (var networkConfigs = networkConfigMng.GetInstances())
            {
                foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"]))
                {
                    using (ManagementBaseObject newIP = managementObject.GetMethodParameters("EnableDHCP"))
                    {
                        managementObject.InvokeMethod("EnableDHCP", newIP, null);
                    }
                }
            }
        }
    }
    public static void SetDNS(string DnsString)
    {
        string[] Dns = { DnsString };
        using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
        {
            using (var networkConfigs = networkConfigMng.GetInstances())
            {
                foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"]))
                {
                    using (ManagementBaseObject objdns = managementObject.GetMethodParameters("SetDNSServerSearchOrder"))
                    {
                        objdns["DNSServerSearchOrder"] = Dns;
                        managementObject.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                    }
                }
            }
        }
    }
    public static void UnsetDNS()
    {
        using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
        {
            using (var networkConfigs = networkConfigMng.GetInstances())
            {
                foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"]))
                {
                    using (ManagementBaseObject objdns = managementObject.GetMethodParameters("SetDNSServerSearchOrder"))
                    {
                        objdns["DNSServerSearchOrder"] = null;
                        managementObject.InvokeMethod("SetDNSServerSearchOrder", objdns, null);
                    }
                }
            }
        }
    }
    /// <summary>
    /// Set's the DNS Server of the local machine
    /// </summary>
    /// <param name="nic">NIC address</param>
    /// <param name="dnsServers">Comma seperated list of DNS server addresses</param>
    /// <remarks>Requires a reference to the System.Management namespace</remarks>
    public void SetNameservers(string nic, string dnsServers)
    {
        using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
        {
            using (var networkConfigs = networkConfigMng.GetInstances())
            {
                foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(objMO => (bool)objMO["IPEnabled"] && objMO["Caption"].Equals(nic)))
                {
                    using (var newDNS = managementObject.GetMethodParameters("SetDNSServerSearchOrder"))
                    {
                        newDNS["DNSServerSearchOrder"] = dnsServers.Split(',');
                        managementObject.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                    }
                }
            }
        }
    }





    public static void GetData()
    {
        using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
        {
            using (var networkConfigs = networkConfigMng.GetInstances())
            {
                foreach (var managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"]))
                {
                    using (ManagementBaseObject newIP = managementObject.GetMethodParameters("EnableStatic"))
                    {
                        // Set new IP address and subnet if needed
                                newIP["IPAddress"] = new[] { "" };

                                newIP["SubnetMask"] = new[] { "" };

                                ///////////////////////////////////////////

                                string[] lo = (string[])newIP.GetPropertyValue("SubnetMask");
                                MessageBox.Show(lo[0]);

                            //managementObject.InvokeMethod("EnableStatic", newIP, null);
                            using (var newGateway = managementObject.GetMethodParameters("SetGateways"))
                            {
                                newGateway["DefaultIPGateway"] = new[] { "" };
                                newGateway["GatewayCostMetric"] = new[] { 1 };
                                managementObject.InvokeMethod("SetGateways", newGateway, null);
                            }
                    }
                }
            }
        }
    }
    public static ManagementObject GetManagementObject()
    {
        ManagementObject result = null;
        using (var networkConfigMng = new ManagementClass("Win32_NetworkAdapterConfiguration"))
        {
            using (var networkConfigs = networkConfigMng.GetInstances())
            {
                foreach (ManagementObject managementObject in networkConfigs.Cast<ManagementObject>().Where(managementObject => (bool)managementObject["IPEnabled"]))
                {
                    result = managementObject;
                }
            }
        }
        return result;
    }


}