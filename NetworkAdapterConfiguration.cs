
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Management;
using System.Runtime.CompilerServices;

public class NetworkAdapterConfiguration 
{
    public enum IGMPLevelValues
    {
        No_multidifusión_IP,
        Multidifusión_IP,
        Multidifusión_IP_IGMP,
        NULL_ENUM_VALUE
    }

    public enum IPXFrameTypeValues
    {
        Ethernet_II = 0,
        Ethernet_802_3 = 1,
        Ethernet_802_2 = 2,
        Ethernet_SNAP = 3,
        Automático = 0xFF,
        NULL_ENUM_VALUE = 0x100
    }

    public enum IPXMediaTypeValues
    {
        Ethernet = 1,
        Token_Ring = 2,
        FDDI = 3,
        ARCNET = 8,
        NULL_ENUM_VALUE = 0
    }

    public enum TcpipNetbiosOptionsValues
    {
        EnableNetbiosViaDhcp,
        Habilitado,
        Habilitado0,
        NULL_ENUM_VALUE
    }

    public class NetworkAdapterConfigurationCollection : ICollection
    {
        public class NetworkAdapterConfigurationEnumerator : IEnumerator
        {
            private ManagementObjectCollection.ManagementObjectEnumerator mObj;

            public virtual object Current => new NetworkAdapterConfiguration((ManagementObject)mObj.Current);

            public NetworkAdapterConfigurationEnumerator(ManagementObjectCollection.ManagementObjectEnumerator objEnum)
            {
                mObj = objEnum;
            }

            public virtual bool MoveNext()
            {
                return mObj.MoveNext();
            }

            bool IEnumerator.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                return this.MoveNext();
            }

            public virtual void Reset()
            {
                mObj.Reset();
            }

            void IEnumerator.Reset()
            {
                //ILSpy generated this explicit interface implementation from .override directive in Reset
                this.Reset();
            }
        }

        private ManagementObjectCollection mObj;

        public virtual int Count => mObj.Count;

        public virtual bool IsSynchronized => mObj.IsSynchronized;

        public virtual object SyncRoot => this;

        public NetworkAdapterConfigurationCollection(ManagementObjectCollection objCollection)
        {
            mObj = objCollection;
        }

        public virtual void CopyTo(Array array, int index)
        {
            mObj.CopyTo(array, index);
            for (int i = 0; i < array.Length; i = checked(i + 1))
            {
                array.SetValue(new NetworkAdapterConfiguration((ManagementObject)array.GetValue(i)), i);
            }
        }

        void ICollection.CopyTo(Array array, int index)
        {
            //ILSpy generated this explicit interface implementation from .override directive in CopyTo
            this.CopyTo(array, index);
        }

        public virtual IEnumerator GetEnumerator()
        {
            return new NetworkAdapterConfigurationEnumerator(mObj.GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
            return this.GetEnumerator();
        }
    }

    public class WMIValueTypeConverter : TypeConverter
    {
        private TypeConverter mObj;

        private Type ᜁ;

        public WMIValueTypeConverter(Type inBaseType)
        {
            mObj = TypeDescriptor.GetConverter(inBaseType);
            ᜁ = inBaseType;
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type srcType)
        {
            return mObj.CanConvertFrom(context, srcType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return mObj.CanConvertTo(context, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            return mObj.ConvertFrom(context, culture, RuntimeHelpers.GetObjectValue(value));
        }

        public override object CreateInstance(ITypeDescriptorContext context, IDictionary dictionary)
        {
            return mObj.CreateInstance(context, dictionary);
        }

        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
        {
            return mObj.GetCreateInstanceSupported(context);
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributeVar)
        {
            return mObj.GetProperties(context, RuntimeHelpers.GetObjectValue(value), attributeVar);
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return mObj.GetPropertiesSupported(context);
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return mObj.GetStandardValues(context);
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return mObj.GetStandardValuesExclusive(context);
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return mObj.GetStandardValuesSupported(context);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if ((object)ᜁ.BaseType == typeof(Enum))
            {
                if ((object)value.GetType() == destinationType)
                {
                    return value;
                }
                if (value == null && context != null && !context.PropertyDescriptor.ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.Instance)))
                {
                    return "NULL_ENUM_VALUE";
                }
                return mObj.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
            }
            if ((object)ᜁ == typeof(bool) && (object)ᜁ.BaseType == typeof(ValueType))
            {
                if (value == null && context != null && !context.PropertyDescriptor.ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.Instance)))
                {
                    return "";
                }
                return mObj.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
            }
            if (context != null && !context.PropertyDescriptor.ShouldSerializeValue(RuntimeHelpers.GetObjectValue(context.Instance)))
            {
                return "";
            }
            return mObj.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType);
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ManagementSystemProperties
    {
        private ManagementBaseObject mObj;

        [Browsable(true)]
        public int GENUS
        {
            get
            {
                return Conversions.ToInteger(mObj["__GENUS"]);
            }
        }

        [Browsable(true)]
        public string CLASS
        {
            get
            {
                return Conversions.ToString(mObj["__CLASS"]);
            }
        }

        [Browsable(true)]
        public string SUPERCLASS
        {
            get
            {
                return Conversions.ToString(mObj["__SUPERCLASS"]);
            }
        }

        [Browsable(true)]
        public string DYNASTY
        {
            get
            {
                return Conversions.ToString(mObj["__DYNASTY"]);
            }
        }

        [Browsable(true)]
        public string RELPATH
        {
            get
            {
                return Conversions.ToString(mObj["__RELPATH"]);
            }
        }

        [Browsable(true)]
        public int PROPERTY_COUNT
        {
            get
            {
                return Conversions.ToInteger(mObj["__PROPERTY_COUNT"]);
            }
        }

        [Browsable(true)]
        public string[] DERIVATION
        {
            get
            {
                return (string[])mObj["__DERIVATION"];
            }
        }

        [Browsable(true)]
        public string SERVER
        {
            get
            {
                return Conversions.ToString(mObj["__SERVER"]);
            }
        }

        [Browsable(true)]
        public string NAMESPACE
        {
            get
            {
                return Conversions.ToString(mObj["__NAMESPACE"]);
            }
        }

        [Browsable(true)]
        public string PATH
        {
            get
            {
                return Conversions.ToString(mObj["__PATH"]);
            }
        }

        public ManagementSystemProperties(ManagementBaseObject ManagedObject)
        {
            mObj = ManagedObject;
        }
    }

    private static string root = "root\\CimV2";

    private static string w32_N = "Win32_NetworkAdapterConfiguration";

    private static ManagementScope mScope = null;

    private ManagementSystemProperties mSystemProperties;

    private ManagementObject mObject;

    private bool result;

    private ManagementBaseObject MBaseObject;

    private ManagementBaseObject mBaseObject;

    private bool res;

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string OriginatingNamespace
    {
        get
        {
            return "root\\CimV2";
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    public string ManagementClassName
    {
        get
        {
            string text = NetworkAdapterConfiguration.w32_N;
            if (this.mBaseObject != null && this.mBaseObject.ClassPath != null)
            {
                text = Conversions.ToString(this.mBaseObject["__CLASS"]);
                if (text == null || (object)text == string.Empty)
                {
                    text = NetworkAdapterConfiguration.w32_N;
                }
            }
            return text;
        }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ManagementSystemProperties SystemProperties
    {
        get
        {
            return this.mSystemProperties;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public ManagementBaseObject LateBoundObject
    {
        get
        {
            return this.mBaseObject;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    public ManagementScope Scope
    {
        get
        {
            if (!this.res)
            {
                return this.mObject.Scope;
            }
            return null;
        }
        set
        {
            if (!this.res)
            {
                this.mObject.Scope = value;
            }
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool AutoCommit
    {
        get
        {
            return this.result;
        }
        set
        {
            this.result = value;
        }
    }

    [Browsable(true)]
    public ManagementPath Path
    {
        get
        {
            if (!this.res)
            {
                return this.mObject.Path;
            }
            return null;
        }
        set
        {
            if (!this.res)
            {
                if (!ᜁ(null, value, null))
                {
                    throw new ArgumentException("El nombre de clase no coincide.");
                }
                this.mObject.Path = value;
            }
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    public static ManagementScope StaticScope
    {
        get
        {
            return NetworkAdapterConfiguration.mScope;
        }
        set
        {
            NetworkAdapterConfiguration.mScope = value;
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsArpAlwaysSourceRouteNull
    {
        get
        {
            if (this.mBaseObject["ArpAlwaysSourceRoute"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [TypeConverter(typeof(WMIValueTypeConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad ArpAlwaysSourceRoute indica si ARP siempre usa enrutamiento de origen. Si se asigna el valor TRUE, TCP/IP transmitirá las consultas ARP con el enrutamiento de origen habilitado en redes Token Ring. De forma predeterminada, ARP transmite las consultas primero sin el enrutamiento de origen y, si no se recibe respuesta, vuelve a intentarlo con el enrutamiento de origen habilitado. Enrutamiento de origen permite el enrutamiento de paquetes de red a través de diferentes tipos de red. Predeterminado: FALSE.")]
    [Browsable(true)]
    public bool ArpAlwaysSourceRoute
    {
        get
        {
            if (this.mBaseObject["ArpAlwaysSourceRoute"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["ArpAlwaysSourceRoute"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsArpUseEtherSNAPNull
    {
        get
        {
            if (this.mBaseObject["ArpUseEtherSNAP"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad ArpUseEtherSNAP indica si los paquetes de Ethernet utilizan la codificación SNAP IEEE 802.3. Si se asigna el valor 1, TCP/IP transmitirá los paquetes de Ethernet con la codificación SNAP 802.3. De forma predeterminada, la pila transmite los paquetes en formato DIX de Ethernet. Los sistemas Windows NT/Windows 2000 reciben siempre en ambos formatos. Valor predeterminado: FALSE.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public bool ArpUseEtherSNAP
    {
        get
        {
            if (this.mBaseObject["ArpUseEtherSNAP"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["ArpUseEtherSNAP"]);
        }
    }

    [Description("Una corta descripción textual (cadena de una línea) del objeto CIM_Setting.")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string Caption
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["Caption"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad DatabasePath indica una ruta de archivo de Windows a los archivos de base de datos de Internet estándar (HOSTS, LMHOSTS, NETWORKS, PROTOCOLS). Lo utiliza la interfaz de Windows Sockets. La propiedad sólo está disponible en los sistemas de Windows NT/Windows 2000.")]
    public string DatabasePath
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["DatabasePath"]);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsDeadGWDetectEnabledNull
    {
        get
        {
            if (this.mBaseObject["DeadGWDetectEnabled"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad DeadGWDetectEnabled indica si se detectan las puertas de enlace inactivas. Si se asigna el valor TRUE, TCP detectará las puertas de enlace inactivas. Con esta característica habilitada, TCP pedirá a IP el cambio a una puerta de enlace de reserva si retransmite un segmento varias veces sin recibir una respuesta. Valor predeterminado: TRUE.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public bool DeadGWDetectEnabled
    {
        get
        {
            if (this.mBaseObject["DeadGWDetectEnabled"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["DeadGWDetectEnabled"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad DefaultIPGateway indica las direcciones IP de las puertas de enlace predeterminadas que el equipo usa.\nEjemplo: {194.161.12.1, 194.162.46.1}")]
    public string[] DefaultIPGateway
    {
        get
        {
            return (string[])this.mBaseObject["DefaultIPGateway"];
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsDefaultTOSNull
    {
        get
        {
            if (this.mBaseObject["DefaultTOS"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [TypeConverter(typeof(WMIValueTypeConverter))]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad DefaultTOS indica el valor predeterminado de tipo de servicio (TOS) establecido en el encabezado de los paquetes IP salientes. Consulte el documento RFC 791 para ver la definición de los valores. Valor predeterminado: 0, Intervalo válido: 0 - 255.")]
    public byte DefaultTOS
    {
        get
        {
            if (this.mBaseObject["DefaultTOS"] == null)
            {
                return Convert.ToByte(0);
            }
            return Conversions.ToByte(this.mBaseObject["DefaultTOS"]);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsDefaultTTLNull
    {
        get
        {
            if (this.mBaseObject["DefaultTTL"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    [Description("La propiedad DefaultTTL indica el valor Período de vida (TTL) predeterminado definido en el encabezado de los paquetes IP salientes. El TTL especifica el número de enrutadores por los que un paquete IP puede pasar hasta alcanzar su destino antes de ser descartado. Cada enrutador reduce en uno el recuento TTL de un paquete al pasar y descarta los paquetes si el TTL es 0. Valor predeterminado: 32, Intervalo válido: de 1 a 255.")]
    public byte DefaultTTL
    {
        get
        {
            if (this.mBaseObject["DefaultTTL"] == null)
            {
                return Convert.ToByte(0);
            }
            return Conversions.ToByte(this.mBaseObject["DefaultTTL"]);
        }
    }

    [Description("Una descripción textual del objeto CIM_Setting.")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string Description
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["Description"]);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsDHCPEnabledNull
    {
        get
        {
            if (this.mBaseObject["DHCPEnabled"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [TypeConverter(typeof(WMIValueTypeConverter))]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad DHCPEnabled determina si se va a permitir que un servidor del protocolo de configuración dinámica de host (DHCP) asigne automáticamente direcciones IP cuando se establezcan conexiones de red.\nValores: TRUE o FALSE. Si se asigna el valor TRUE, DHCP está habilitado.")]
    public bool DHCPEnabled
    {
        get
        {
            if (this.mBaseObject["DHCPEnabled"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["DHCPEnabled"]);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsDHCPLeaseExpiresNull
    {
        get
        {
            if (this.mBaseObject["DHCPLeaseExpires"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [TypeConverter(typeof(WMIValueTypeConverter))]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad DHCPLeaseExpires indica la fecha y hora de expiración de una concesión de dirección IP que se asignó a un equipo por el servidor de protocolo de configuración dinámica de host (DHCP).\nEjemplo: 20521201000230.000000000")]
    public DateTime DHCPLeaseExpires
    {
        get
        {
            if (this.mBaseObject["DHCPLeaseExpires"] != null)
            {
                return ToDateTime(Conversions.ToString(this.mBaseObject["DHCPLeaseExpires"]));
            }
            return DateTime.MinValue;
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsDHCPLeaseObtainedNull
    {
        get
        {
            if (this.mBaseObject["DHCPLeaseObtained"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    [Description("La propiedad DHCPLeaseObtained indica la fecha y hora de obtención de una concesión de dirección IP que se asignó a un equipo por el servidor de protocolo de configuración dinámica de host (DHCP).\nEjemplo: 19521201000230.000000000")]
    public DateTime DHCPLeaseObtained
    {
        get
        {
            if (this.mBaseObject["DHCPLeaseObtained"] != null)
            {
                return ToDateTime(Conversions.ToString(this.mBaseObject["DHCPLeaseObtained"]));
            }
            return DateTime.MinValue;
        }
    }

    [Description("La propiedad DHCPServer indica la dirección IP del servidor DHCP (Protocolo de configuración dinámica de host).\nEjemplo: 154.55.34.0")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string DHCPServer
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["DHCPServer"]);
        }
    }

    [Description("La propiedad DNSDomain indica un nombre de organización seguido de un punto y una extensión que especifica el tipo de organización, como microsoft.com. El nombre puede estar formado por cualquier combinación de las letras A a la Z, los números 0 al 9 y el guión (-), más el punto (.) utilizado como separador.\nEjemplo: microsoft.com.")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string DNSDomain
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["DNSDomain"]);
        }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad DNSDomainSuffixSearchOrder especifica los sufijos de dominio DNS que se van a anexar a los nombres de host durante la resolución de nombres. Al intentar resolver un nombre de dominio completo (FQDN) de un nombre sólo de host, el sistema primero anexará el nombre de dominio local. Si no es posible, el sistema utilizará la lista de sufijos de dominio para crear FQDN adicionales en el orden enumerado y consultará cada uno en los servidores DNS.\nEjemplo: samples.microsoft.com example.microsoft.com")]
    public string[] DNSDomainSuffixSearchOrder
    {
        get
        {
            return (string[])this.mBaseObject["DNSDomainSuffixSearchOrder"];
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsDNSEnabledForWINSResolutionNull
    {
        get
        {
            if (this.mBaseObject["DNSEnabledForWINSResolution"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    [Description("La propiedad DNSEnabledForWINSResolution indica si está habilitado el Sistema de nombres de dominio (DNS) para la resolución de nombres mediante la resolución WINS. Si no se puede resolver el nombre con DNS, la solicitud del nombre se reenvía a WINS para su resolución.")]
    public bool DNSEnabledForWINSResolution
    {
        get
        {
            if (this.mBaseObject["DNSEnabledForWINSResolution"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["DNSEnabledForWINSResolution"]);
        }
    }

    [Description("La propiedad DNSHostName indica el nombre de host que emplean algunas utilidades para identificar el equipo local para la autenticación. Otras utilidades basadas en TCP/IP pueden usar este valor para conocer el nombre del equipo local. Los nombres de host se almacenan en servidores DNS en una tabla que asigna nombres a direcciones IP para su uso en DNS. El nombre puede estar formado por cualquier combinación de las letras A a la Z, los números 0 al 9 y el guión (-), más el punto (.) utilizado como separador. De forma predeterminada, este valor es el nombre de equipo de red de Microsoft, pero el administrador de la red puede asignar otro nombre de host sin que afecte al nombre de equipo.\nEjemplo: corpdns.")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string DNSHostName
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["DNSHostName"]);
        }
    }

    [Browsable(true)]
    [Description("La propiedad DNSServerSearchOrder muestra una lista en orden alfabético de las direcciones IP que consultan servidores DNS. ")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string[] DNSServerSearchOrder
    {
        get
        {
            return (string[])this.mBaseObject["DNSServerSearchOrder"];
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsDomainDNSRegistrationEnabledNull
    {
        get
        {
            if (this.mBaseObject["DomainDNSRegistrationEnabled"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [TypeConverter(typeof(WMIValueTypeConverter))]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad DomainDNSRegistrationEnabled especifica si las direcciones IP de esta conexión están registradas en DNS bajo el nombre de dominio de esta conexión, además de registrarse bajo el nombre DNS completo del equipo. El nombre de dominio de esta conexión se define por medio del método SetDNSDomain() o DHCP lo asigna. El nombre registrado es el nombre del host del equipo que tiene el nombre de dominio anexado. Sólo en Windows 2000.")]
    public bool DomainDNSRegistrationEnabled
    {
        get
        {
            if (this.mBaseObject["DomainDNSRegistrationEnabled"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["DomainDNSRegistrationEnabled"]);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsForwardBufferMemoryNull
    {
        get
        {
            if (this.mBaseObject["ForwardBufferMemory"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [TypeConverter(typeof(WMIValueTypeConverter))]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad ForwardBufferMemory indica la cantidad de memoria que IP asigna para almacenar datos de paquetes en la cola de paquetes del enrutador. Cuando el espacio de este búfer está lleno, el enrutador comienza a descartar aleatoriamente paquetes de la cola. Los búferes de datos de las colas de paquetes tienen una longitud de 256 bytes, por lo que el valor de este parámetro debe ser un múltiplo de 256. Para paquetes de gran tamaño se encadenan varios búferes. El encabezado IP de los paquetes se almacena por separado. Este parámetro se omite y no se asignan búferes si el enrutador IP no está habilitado. El tamaño del búfer puede variar desde la red MTU al valor más pequeño que 0xFFFFFFFF. Valor predeterminado: 74240 (suficiente para 50 paquetes de 1480 bytes, redondeados a un múltiplo de 256).")]
    public uint ForwardBufferMemory
    {
        get
        {
            if (this.mBaseObject["ForwardBufferMemory"] == null)
            {
                return Convert.ToUInt32(0);
            }
            return Conversions.ToUInteger(this.mBaseObject["ForwardBufferMemory"]);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsFullDNSRegistrationEnabledNull
    {
        get
        {
            if (this.mBaseObject["FullDNSRegistrationEnabled"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [TypeConverter(typeof(WMIValueTypeConverter))]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad FullDNSRegistrationEnabled especifica si las direcciones IP de esta conexión están registradas en DNS bajo el nombre DNS completo del equipo. El nombre DNS completo del equipo se muestra en la ficha Identificación de red del elemento  Sistema del Panel de control. Sólo en Windows 2000.")]
    public bool FullDNSRegistrationEnabled
    {
        get
        {
            if (this.mBaseObject["FullDNSRegistrationEnabled"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["FullDNSRegistrationEnabled"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad GatewayCostMetric indica una métrica de costo de valores enteros (entre 1 y 9999) que se va a utilizar para calcular las rutas más rápidas, confiables y económicas. Este argumento tiene una correspondencia exacta con la propiedad DefaultIPGateway. Sólo para Windows 2000.")]
    public ushort[] GatewayCostMetric
    {
        get
        {
            return (ushort[])this.mBaseObject["GatewayCostMetric"];
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsIGMPLevelNull
    {
        get
        {
            if (this.mBaseObject["IGMPLevel"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad IGMPLevel determina en qué medida el sistema admite la multidifusión IP y participa en el Protocolo de administración de grupos de Internet. En el nivel 0, el sistema no admite la multidifusión. En el nivel 1, el sistema sólo puede enviar paquetes de multidifusión IP. En el nivel 2, el sistema puede enviar paquetes de multidifusión IP y participar totalmente en IGMP para recibir paquetes de multidifusión. Valor predeterminado: 2")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public IGMPLevelValues IGMPLevel
    {
        get
        {
            if (this.mBaseObject["IGMPLevel"] == null)
            {
                return (IGMPLevelValues)Convert.ToInt32(3);
            }
            return (IGMPLevelValues)Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.mBaseObject["IGMPLevel"]));
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsIndexNull
    {
        get
        {
            if (this.mBaseObject["Index"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad Index especifica el número de índice correspondiente a la configuración del adaptador de red de Win32. El número de índice se usa cuando hay más de una configuración disponible.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public uint Index
    {
        get
        {
            if (this.mBaseObject["Index"] == null)
            {
                return Convert.ToUInt32(0);
            }
            return Conversions.ToUInteger(this.mBaseObject["Index"]);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsInterfaceIndexNull
    {
        get
        {
            if (this.mBaseObject["InterfaceIndex"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [Browsable(true)]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad InterfaceIndex contiene el valor del índice que identifica de forma única a la interfaz local.")]
    public uint InterfaceIndex
    {
        get
        {
            if (this.mBaseObject["InterfaceIndex"] == null)
            {
                return Convert.ToUInt32(0);
            }
            return Conversions.ToUInteger(this.mBaseObject["InterfaceIndex"]);
        }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad IPAddress contiene una lista con todas las direcciones IP asociadas al adaptador de red actual.\nEjemplo: 155.34.22.0")]
    public string[] IPAddress
    {
        get
        {
            return (string[])this.mBaseObject["IPAddress"];
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsIPConnectionMetricNull
    {
        get
        {
            if (this.mBaseObject["IPConnectionMetric"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad IPConnectionMetric indica el costo de utilizar las rutas configuradas para este adaptador enlazado a IP y se trata del valor estimado de dichas rutas de la tabla de enrutamiento IP. Si hay varias rutas para cada destino de la tabla de enrutamiento IP, se utiliza la ruta con la métrica más baja. El valor predeterminado es 1. Sólo para Windows 2000.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public uint IPConnectionMetric
    {
        get
        {
            if (this.mBaseObject["IPConnectionMetric"] == null)
            {
                return Convert.ToUInt32(0);
            }
            return Conversions.ToUInteger(this.mBaseObject["IPConnectionMetric"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsIPEnabledNull
    {
        get
        {
            if (this.mBaseObject["IPEnabled"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad IPEnabled determina si IP está enlazado y habilitado para este adaptador de red.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public bool IPEnabled
    {
        get
        {
            if (this.mBaseObject["IPEnabled"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["IPEnabled"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsIPFilterSecurityEnabledNull
    {
        get
        {
            if (this.mBaseObject["IPFilterSecurityEnabled"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad IPFilterSecurityEnabled indica si la seguridad de puertos IP está habilitada globalmente en todos los adaptadores de red enlazados a IP. Esta propiedad se utiliza junto con las propiedades IPSecPermitTCPPorts, IPSecPermitUDPPorts y IPSecPermitIPProtocols. El valor TRUE indica que la seguridad de puertos IP está habilitada y que los valores de seguridad asociados a adaptadores individuales están vigentes. El valor FALSE indica que la seguridad de filtro IP está deshabilitada en todos los adaptadores de red y permite que el tráfico de todos los puertos y protocolos pase sin filtrar.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public bool IPFilterSecurityEnabled
    {
        get
        {
            if (this.mBaseObject["IPFilterSecurityEnabled"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["IPFilterSecurityEnabled"]);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsIPPortSecurityEnabledNull
    {
        get
        {
            if (this.mBaseObject["IPPortSecurityEnabled"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad IPPortSecurityEnabled indica si la seguridad del puerto IP está habilitada globalmente por todos los adaptadores de red enlazados a IP. Esta propiedad quedó obsoleta en favor de IPFilterSecurityEnabled en su lugar.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public bool IPPortSecurityEnabled
    {
        get
        {
            if (this.mBaseObject["IPPortSecurityEnabled"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["IPPortSecurityEnabled"]);
        }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad IPSecPermitIPProtocols enumera los protocolos cuya ejecución a través de IP está permitida. La lista de protocolos se define con el método EnableIPSec. Esta lista estará vacía o incluirá valores numéricos. Un valor numérico cero indica que se concede permiso de acceso para todos los protocolos. Una cadena vacía indica que no se permite la ejecución de ningún protocolo cuando IPFilterSecurityEnabled es TRUE.")]
    public string[] IPSecPermitIPProtocols
    {
        get
        {
            return (string[])this.mBaseObject["IPSecPermitIPProtocols"];
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad IPSecPermitTCPPorts enumera los puertos a los que se va a conceder permiso de acceso para TCP. La lista de protocolos se define con el método EnableIPSec. Esta lista estará vacía o incluirá valores numéricos. Un valor numérico cero indica que se concede permiso de acceso para todos los puertos. Una cadena vacía indica que no se concede permiso de acceso a ningún puerto cuando IPFilterSecurityEnabled es TRUE.")]
    public string[] IPSecPermitTCPPorts
    {
        get
        {
            return (string[])this.mBaseObject["IPSecPermitTCPPorts"];
        }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad IPSecPermitTCPPorts enumera los puertos a los que se va a conceder permiso de acceso para Protocolo de datagrama de usuario (UDP). La lista de protocolos se define con el método EnableIPSec. Esta lista estará vacía o incluirá valores numéricos. Un valor numérico cero indica que se concede permiso de acceso para todos los puertos. Una cadena vacía indica que no se concede permiso de acceso a ningún puerto cuando IPFilterSecurityEnabled es TRUE.")]
    public string[] IPSecPermitUDPPorts
    {
        get
        {
            return (string[])this.mBaseObject["IPSecPermitUDPPorts"];
        }
    }

    [Description("La propiedad IPSubnet contiene una lista con todas las máscaras de subred asociadas al adaptador de red actual.\nEjemplo: 255.255.0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    public string[] IPSubnet
    {
        get
        {
            return (string[])this.mBaseObject["IPSubnet"];
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsIPUseZeroBroadcastNull
    {
        get
        {
            if (this.mBaseObject["IPUseZeroBroadcast"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [Description("La propiedadIPUseZeroBroadcast indica si se utilizan las difusiones de ceros de IP. Si este parámetro tiene el valor TRUE, IP utilizará las difusiones de ceros (0.0.0.0), y el sistema utilizará las difusiones de unos (255.255.255.255). Los sistemas de equipos normalmente utilizan difusiones de unos, pero los que se derivan de las implementaciones BSD utilizan las difusiones de ceros. Los sistemas que no utilizan las mismas difusiones no interoperarán en la misma red. Valor predeterminado: FALSE.")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public bool IPUseZeroBroadcast
    {
        get
        {
            if (this.mBaseObject["IPUseZeroBroadcast"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["IPUseZeroBroadcast"]);
        }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad IPXAddress indica la dirección (IPX) del adaptador de red. La dirección IPX identifica un sistema en una red que utiliza protocolo IPX.")]
    public string IPXAddress
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["IPXAddress"]);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsIPXEnabledNull
    {
        get
        {
            if (this.mBaseObject["IPXEnabled"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [Description("La propiedad IPXEnabled determina si Internetwork Packet Exchange (IPX) está enlazado y habilitado para este adaptador.")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public bool IPXEnabled
    {
        get
        {
            if (this.mBaseObject["IPXEnabled"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["IPXEnabled"]);
        }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad IPXFrameType representa una matriz de identificadores de tipos de trama con valores enteros. Los valores de esta matriz corresponden a los elementos de IPXNetworkNumber.")]
    public IPXFrameTypeValues[] IPXFrameType
    {
        get
        {
            Array array = (Array)this.mBaseObject["IPXFrameType"];
            IPXFrameTypeValues[] array2 = new IPXFrameTypeValues[checked(array.Length - 1 + 1)];
            int num = 0;
            for (num = 0; num < array.Length; num = checked(num + 1))
            {
                array2[num] = (IPXFrameTypeValues)Convert.ToInt32(RuntimeHelpers.GetObjectValue(array.GetValue(num)));
            }
            return array2;
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsIPXMediaTypeNull
    {
        get
        {
            if (this.mBaseObject["IPXMediaType"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [TypeConverter(typeof(WMIValueTypeConverter))]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad IPXMediaType representa un identificador de tipo de media IPX.")]
    [Browsable(true)]
    public IPXMediaTypeValues IPXMediaType
    {
        get
        {
            if (this.mBaseObject["IPXMediaType"] == null)
            {
                return (IPXMediaTypeValues)Convert.ToInt32(0);
            }
            return (IPXMediaTypeValues)Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.mBaseObject["IPXMediaType"]));
        }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad IPXNetworkNumber representa una matriz de caracteres que identifica únicamente una combinación del adaptador de trama/red en el sistema del equipo. NetWare Link (NWLink), transporte compatible con IPX/SPX en Windows 2000 y Windows NT 4.0 y posteriores usan dos tipos de números de red distintamente diferentes. A veces se hace referencia a este número como el número de red externo. Debe ser único para cada segmento de red. El orden en esta lista de cadenas se corresponderá elemento-para-elemento con los elementos en la propiedad IPXFrameType.")]
    public string[] IPXNetworkNumber
    {
        get
        {
            return (string[])this.mBaseObject["IPXNetworkNumber"];
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad IPXVirtualNetNumber identifica de forma única el sistema del equipo en la red. Se representa como un dígito hexadecimal de ocho caracteres. Windows NT/2000 utiliza el número de red virtual (también conocido como un número de red interno) para el enrutamiento interno.")]
    public string IPXVirtualNetNumber
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["IPXVirtualNetNumber"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsKeepAliveIntervalNull
    {
        get
        {
            if (this.mBaseObject["KeepAliveInterval"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad KeepAliveInterval determina el intervalo de separación de retransmisiones de mantenimiento de conexión (Keep Alive) hasta que se reciba una respuesta. Una vez recibida una respuesta, el retardo hasta la siguiente transmisión de mantenimiento de conexión está controlado de nuevo por el valor de Keep Alive Transmission. La conexión se anulará después de intentar el número de retransmisiones especificado en TcpMaxDataRetransmissions y no se haya obtenido respuesta. Valor predeterminado: 1000, Intervalo válido: 1 - 0xFFFFFFFF.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public uint KeepAliveInterval
    {
        get
        {
            if (this.mBaseObject["KeepAliveInterval"] == null)
            {
                return Convert.ToUInt32(0);
            }
            return Conversions.ToUInteger(this.mBaseObject["KeepAliveInterval"]);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsKeepAliveTimeNull
    {
        get
        {
            if (this.mBaseObject["KeepAliveTime"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [Description("La propiedad KeepAliveTime determina la frecuencia con que TCP intenta comprobar que una conexión inactiva sigue intacta mediante el envío de un paquete de mantenimiento de conexión (Keep Alive). Si el sistema remoto sigue siendo accesible y está en funcionamiento, confirmará la transmisión de mantenimiento de conexión. De forma predeterminada, este tipo de paquetes no se envían. Una aplicación puede habilitar esta característica en una conexión. Valor predeterminado: 7.200.000 (dos horas)")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public uint KeepAliveTime
    {
        get
        {
            if (this.mBaseObject["KeepAliveTime"] == null)
            {
                return Convert.ToUInt32(0);
            }
            return Conversions.ToUInteger(this.mBaseObject["KeepAliveTime"]);
        }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad MACAddress indica la dirección de Media Access Control (MAC) para el adaptador de red. El fabricante asigna una dirección MAC para identificar de forma única al adaptador de red.\nEjemplo: 00:80:C7:8F:6C:96")]
    public string MACAddress
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["MACAddress"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsMTUNull
    {
        get
        {
            if (this.mBaseObject["MTU"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad MTU invalida la unidad máxima de transmisión (MTU) predeterminada de una interfaz de red. La unidad MTU es el tamaño máximo del paquete (incluido el encabezado de transporte) que el transporte transmitirá por la red subyacente. El datagrama IP puede abarcar varios paquetes. El intervalo de este valor abarca el tamaño mínimo de paquete (68) hasta la MTU compatible con la red subyacente.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public uint MTU
    {
        get
        {
            if (this.mBaseObject["MTU"] == null)
            {
                return Convert.ToUInt32(0);
            }
            return Conversions.ToUInteger(this.mBaseObject["MTU"]);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsNumForwardPacketsNull
    {
        get
        {
            if (this.mBaseObject["NumForwardPackets"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad NumForwardPackets determina el número de encabezados de paquetes IP asignados para la cola de paquetes del enrutador. Cuando todos los encabezados están en uso, el enrutador comienza a descartar aleatoriamente paquetes de la cola. Este valor debe ser al menos tan grande como el valor de ForwardBufferMemory dividido entre el tamaño máximo de datos IP de las redes conectadas al enrutador. No debe ser mayor que el valor de ForwardBufferMemory dividido entre 256, ya que se utilizan como mínimo 256 bytes de memoria del búfer de reenvío para cada paquete. El número óptimo de paquetes de reenvío de un tamaño de ForwardBufferMemory especificado depende del tipo de tráfico existente en la red y se encontrará entre estos dos valores. Este parámetro se omite y no se asignan encabezados si el enrutador no está habilitado. Valor predeterminado: 50, Intervalo válido: 1 - 0xFFFFFFFF")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public uint NumForwardPackets
    {
        get
        {
            if (this.mBaseObject["NumForwardPackets"] == null)
            {
                return Convert.ToUInt32(0);
            }
            return Conversions.ToUInteger(this.mBaseObject["NumForwardPackets"]);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsPMTUBHDetectEnabledNull
    {
        get
        {
            if (this.mBaseObject["PMTUBHDetectEnabled"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [TypeConverter(typeof(WMIValueTypeConverter))]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad PMTUBHDetectEnabled indica si se detectan los enrutadores \"agujero negro\". Si se asigna el valor TRUE, TCP intentará detectar los enrutadores \"agujero negro\" durante la detección de la unidad MTU de la ruta de acceso. Un enrutador \"agujero negro\" no devuelve mensajes de destino de ICMP inaccesible cuando necesita fragmentar un datagrama IP con el bit No fragmentar definido. TCP depende de la recepción de estos mensajes para detectar la unidad MTU de la ruta de acceso. Con esta característica habilitada, TCP intentará enviar segmentos sin el bit No fragmentar definido si no se confirman varias retransmisiones de un segmento. Si se confirma el segmento como resultado, el MSS se reducirá y se definirá el bit No fragmentar para futuros paquetes de la conexión. Al habilitar la detección de agujeros negros aumenta el número máximo de retransmisiones realizadas para un segmento dado. Valor predeterminado: FALSE.")]
    public bool PMTUBHDetectEnabled
    {
        get
        {
            if (this.mBaseObject["PMTUBHDetectEnabled"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["PMTUBHDetectEnabled"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsPMTUDiscoveryEnabledNull
    {
        get
        {
            if (this.mBaseObject["PMTUDiscoveryEnabled"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    [Description("La propiedad PMTUDiscoveryEnabled indica si se detecta la ruta máxima de transmisión (MTU). Si se asigna el valor TRUE, TCP intentará detectar la unidad MTU (o el mayor tamaño de paquete) en la ruta de acceso a un host remoto. Mediante la detección de la unidad MTU de la ruta de acceso y la limitación de los segmentos TCP a este tamaño, TCP puede eliminar la fragmentación en los enrutadores que se encuentran en la ruta de acceso que conecta las redes con diferentes unidades MTU. La fragmentación repercute negativamente en el rendimiento de TCP y la congestión de la red. Si se asigna el valor FALSE, se utilizará una unidad MTU de 576 bytes para todas las conexiones que no sean a equipos que se encuentren en la subred local. Valor predeterminado: TRUE.")]
    public bool PMTUDiscoveryEnabled
    {
        get
        {
            if (this.mBaseObject["PMTUDiscoveryEnabled"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["PMTUDiscoveryEnabled"]);
        }
    }

    [Description("La propiedad ServiceName indica el nombre de servicio del adaptador de red. Este nombre suele ser más corto que el nombre completo del producto. \nEjemplo: Elnkii.")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string ServiceName
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["ServiceName"]);
        }
    }

    [Browsable(true)]
    [Description("El identificador por el que se conoce el objeto CIM_Setting.")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string SettingID
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["SettingID"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsTcpipNetbiosOptionsNull
    {
        get
        {
            if (this.mBaseObject["TcpipNetbiosOptions"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad TcpipNetbiosOptions especifica un mapa de bits de los valores posibles relacionados con NetBIOS sobre TCP/IP. Sólo para Windows 2000.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public TcpipNetbiosOptionsValues TcpipNetbiosOptions
    {
        get
        {
            if (this.mBaseObject["TcpipNetbiosOptions"] == null)
            {
                return (TcpipNetbiosOptionsValues)Convert.ToInt32(3);
            }
            return (TcpipNetbiosOptionsValues)Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.mBaseObject["TcpipNetbiosOptions"]));
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsTcpMaxConnectRetransmissionsNull
    {
        get
        {
            if (this.mBaseObject["TcpMaxConnectRetransmissions"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad TcpMaxConnectRetransmissions indica el número de veces que TCP intentará retransmitir una Solicitud de conexión antes de terminar la conexión. El período de espera de retransmisión es de 3 segundos. El período de espera de retransmisión se duplica para cada intento. Valor predeterminado: 3, Intervalo rápido: 0 - 0xFFFFFFFF.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public uint TcpMaxConnectRetransmissions
    {
        get
        {
            if (this.mBaseObject["TcpMaxConnectRetransmissions"] == null)
            {
                return Convert.ToUInt32(0);
            }
            return Conversions.ToUInteger(this.mBaseObject["TcpMaxConnectRetransmissions"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsTcpMaxDataRetransmissionsNull
    {
        get
        {
            if (this.mBaseObject["TcpMaxDataRetransmissions"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad TcpMaxDataRetransmissions indica el número de veces que TCP retransmitirá un segmento de datos individual (segmento sin conexión) antes de terminar la conexión. El período de espera de la retransmisión se duplicará con cada retransmisión sucesiva en una conexión. Valor predeterminado: 5, Intervalo válido: 0 - 0xFFFFFFFF.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public uint TcpMaxDataRetransmissions
    {
        get
        {
            if (this.mBaseObject["TcpMaxDataRetransmissions"] == null)
            {
                return Convert.ToUInt32(0);
            }
            return Conversions.ToUInteger(this.mBaseObject["TcpMaxDataRetransmissions"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsTcpNumConnectionsNull
    {
        get
        {
            if (this.mBaseObject["TcpNumConnections"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad TcpNumConnections indica el número máximo de conexiones que TCP puede abrir a la vez. Default: 0xFFFFFE, Intervalo válido: 0 - 0xFFFFFE.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public uint TcpNumConnections
    {
        get
        {
            if (this.mBaseObject["TcpNumConnections"] == null)
            {
                return Convert.ToUInt32(0);
            }
            return Conversions.ToUInteger(this.mBaseObject["TcpNumConnections"]);
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IsTcpUseRFC1122UrgentPointerNull
    {
        get
        {
            if (this.mBaseObject["TcpUseRFC1122UrgentPointer"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad TcpUseRFC1122UrgentPointer determina si TCP utiliza la especificación RFC 1122 para datos urgentes o el modo utilizado por sistemas derivados de BSD. Los dos mecanismos interpretan de forma distinta el puntero urgente en el encabezado TCP y la longitud de los datos urgentes. No son interoperables. De forma predeterminada, Windows 2000 y Windows NT 3.51 utiliza el modo BSD. Si está el valor TRUE, se envían los datos urgentes en modo RFC 1122. Valor predeterminado: FALSE. ")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public bool TcpUseRFC1122UrgentPointer
    {
        get
        {
            if (this.mBaseObject["TcpUseRFC1122UrgentPointer"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["TcpUseRFC1122UrgentPointer"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsTcpWindowSizeNull
    {
        get
        {
            if (this.mBaseObject["TcpWindowSize"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [Description("La propiedad TcpWindowSize contiene el tamaño máximo de la ventana de recepción TCP que el sistema ofrece. La ventana de recepción especifica el número de bytes que un remitente puede transmitir sin recibir confirmación. En general, las ventanas que pueden recepción de tamaños mayores mejoran el rendimiento cuando hay retrasos y  sobre redes de banda ancha. Para mayor eficacia, la ventana de recepción debe ser un múltiplo para del tamaño máximo del segmento TCP (MSS). Valor predeterminado: Cuatro veces el tamaño máximo de los datos TCP o un múltiplo par del tamaño de datos TCP redondeado hacia el múltiplo más cercano a 8760. Intervalo válido: 0 - 65535.")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public ushort TcpWindowSize
    {
        get
        {
            if (this.mBaseObject["TcpWindowSize"] == null)
            {
                return Convert.ToUInt16(0);
            }
            return Conversions.ToUShort(this.mBaseObject["TcpWindowSize"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public bool IsWINSEnableLMHostsLookupNull
    {
        get
        {
            if (this.mBaseObject["WINSEnableLMHostsLookup"] == null)
            {
                return true;
            }
            return false;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad WINSEnableLMHostsLookup indica si se utilizan archivos de búsqueda locales. Los archivos de búsqueda contienen las asignaciones de direcciones IP a nombres de host. Si existen en el sistema local, se encuentran en %SystemRoot%\\system32\\drivers\\etc.")]
    [TypeConverter(typeof(WMIValueTypeConverter))]
    public bool WINSEnableLMHostsLookup
    {
        get
        {
            if (this.mBaseObject["WINSEnableLMHostsLookup"] == null)
            {
                return Convert.ToBoolean(0);
            }
            return Conversions.ToBoolean(this.mBaseObject["WINSEnableLMHostsLookup"]);
        }
    }

    [Description("La propiedad WINSHostLookupFile contiene una ruta de acceso a un archivo de búsqueda de WINS en el sistema local. Este archivo contiene las asignaciones de direcciones IP a nombres de host. Si se encuentra el archivo especificado en esta propiedad, se copiará a la carpeta %SystemRoot%\\system32\\drivers\\etc del sistema local. Válido únicamente cuando la propiedad WINSEnableLMHostsLookup es TRUE.")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    public string WINSHostLookupFile
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["WINSHostLookupFile"]);
        }
    }

    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Description("La propiedad WINSPrimaryServer indica la dirección IP del servidor WINS principal.")]
    public string WINSPrimaryServer
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["WINSPrimaryServer"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad ScopeID permite aislar un grupo de equipos que sólo se comunican entre sí. El id. de ámbito es un valor de cadena de caracteres anexada al nombre NetBIOS y que se usa para todas las comunicaciones NetBIOS a través de TCP/IP desde ese equipo. Otros equipos configurados con el mismo id. de ámbito pueden comunicarse con este equipo, mientras que los clientes TCP/IP con un id. de ámbito diferente descartan los paquetes de cualquier otro id. de ámbito. Válido únicamente cuando el método EnableWINS se ejecuta correctamente.")]
    public string WINSScopeID
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["WINSScopeID"]);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(true)]
    [Description("La propiedad WINSSecondaryServer indica la dirección IP del servidor WINS secundario.")]
    public string WINSSecondaryServer
    {
        get
        {
            return Conversions.ToString(this.mBaseObject["WINSSecondaryServer"]);
        }
    }

    public NetworkAdapterConfiguration()
    {
        mObj(null, null, null);
    }

    public NetworkAdapterConfiguration(uint keyIndex)
    {
        mObj(null, new ManagementPath(mObj(keyIndex)), null);
    }

    public NetworkAdapterConfiguration(ManagementScope mgmtScope, uint keyIndex)
    {
        mObj(mgmtScope, new ManagementPath(mObj(keyIndex)), null);
    }

    public NetworkAdapterConfiguration(ManagementPath path, ObjectGetOptions getOptions)
    {
        mObj(null, path, getOptions);
    }

    public NetworkAdapterConfiguration(ManagementScope mgmtScope, ManagementPath path)
    {
        mObj(mgmtScope, path, null);
    }

    public NetworkAdapterConfiguration(ManagementPath path)
    {
        mObj(null, path, null);
    }

    public NetworkAdapterConfiguration(ManagementScope mgmtScope, ManagementPath path, ObjectGetOptions getOptions)
    {
        mObj(mgmtScope, path, getOptions);
    }

    public NetworkAdapterConfiguration(ManagementObject theObject)
    {
        if (mObj(theObject))
        {
            this.mObject = theObject;
            this.mSystemProperties = new ManagementSystemProperties(this.mObject);
            this.mBaseObject = this.mObject;
            return;
        }
        throw new ArgumentException("El nombre de clase no coincide.");
    }

    public NetworkAdapterConfiguration(ManagementBaseObject theObject)
    {
        if (mObj(theObject))
        {
            this.MBaseObject = theObject;
            this.mSystemProperties = new ManagementSystemProperties(theObject);
            this.mBaseObject = this.MBaseObject;
            this.res = true;
            return;
        }
        throw new ArgumentException("El nombre de clase no coincide.");
    }

    private bool ᜁ(ManagementScope A_0, ManagementPath A_1, ObjectGetOptions A_2)
    {
        if (A_1 != null && string.Compare(A_1.ClassName, ManagementClassName, true, CultureInfo.InvariantCulture) == 0)
        {
            return true;
        }
        return mObj(new ManagementObject(A_0, A_1, A_2));
    }

    private bool mObj(ManagementBaseObject A_0)
    {
        if (A_0 != null && string.Compare(Conversions.ToString(A_0["__CLASS"]), ManagementClassName, true, CultureInfo.InvariantCulture) == 0)
        {
            return true;
        }
        Array array = (Array)A_0["__DERIVATION"];
        if (array != null)
        {
            int num = 0;
            for (num = 0; num < array.Length; num = checked(num + 1))
            {
                if (string.Compare(Conversions.ToString(array.GetValue(num)), ManagementClassName, true, CultureInfo.InvariantCulture) == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }

    private bool ᜣ()
    {
        if (!IsArpAlwaysSourceRouteNull)
        {
            return true;
        }
        return false;
    }

    private bool ᜢ()
    {
        if (!IsArpUseEtherSNAPNull)
        {
            return true;
        }
        return false;
    }

    private bool ᜡ()
    {
        if (!IsDeadGWDetectEnabledNull)
        {
            return true;
        }
        return false;
    }

    private bool ᜠ()
    {
        if (!IsDefaultTOSNull)
        {
            return true;
        }
        return false;
    }



	public static DateTime ToDateTime(string dmtfDate)
    {
        DateTime minValue = DateTime.MinValue;
        int num = minValue.Year;
        int num2 = minValue.Month;
        int num3 = minValue.Day;
        int num4 = minValue.Hour;
        int num5 = minValue.Minute;
        int num6 = minValue.Second;
        long num7 = 0L;
        DateTime minValue2 = DateTime.MinValue;
        string empty = string.Empty;
        if (dmtfDate == null)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (dmtfDate.Length == 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (dmtfDate.Length != 25)
        {
            throw new ArgumentOutOfRangeException();
        }
        checked
        {
            try
            {
                empty = dmtfDate.Substring(0, 4);
                if (Operators.CompareString("****", empty, TextCompare: false) != 0)
                {
                    num = int.Parse(empty);
                }
                empty = dmtfDate.Substring(4, 2);
                if (Operators.CompareString("**", empty, TextCompare: false) != 0)
                {
                    num2 = int.Parse(empty);
                }
                empty = dmtfDate.Substring(6, 2);
                if (Operators.CompareString("**", empty, TextCompare: false) != 0)
                {
                    num3 = int.Parse(empty);
                }
                empty = dmtfDate.Substring(8, 2);
                if (Operators.CompareString("**", empty, TextCompare: false) != 0)
                {
                    num4 = int.Parse(empty);
                }
                empty = dmtfDate.Substring(10, 2);
                if (Operators.CompareString("**", empty, TextCompare: false) != 0)
                {
                    num5 = int.Parse(empty);
                }
                empty = dmtfDate.Substring(12, 2);
                if (Operators.CompareString("**", empty, TextCompare: false) != 0)
                {
                    num6 = int.Parse(empty);
                }
                empty = dmtfDate.Substring(15, 6);
                if (Operators.CompareString("******", empty, TextCompare: false) != 0)
                {
                    num7 = long.Parse(empty) * 10;
                }
                if (num < 0 || num2 < 0 || num3 < 0 || num4 < 0 || num5 < 0 || num5 < 0 || num6 < 0 || num7 < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                throw new ArgumentOutOfRangeException(null, ex2.Message);
            }
            minValue2 = new DateTime(num, num2, num3, num4, num5, num6, 0).AddTicks(num7);
            TimeSpan utcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(minValue2);
            int num8 = 0;
            int num9 = 0;
            long num10 = (long)Math.Round(unchecked((double)utcOffset.Ticks / 600000000.0));
            empty = dmtfDate.Substring(22, 3);
            if (Operators.CompareString(empty, "******", TextCompare: false) != 0)
            {
                empty = dmtfDate.Substring(21, 4);
                try
                {
                    num8 = int.Parse(empty);
                }
                catch (Exception ex3)
                {
                    ProjectData.SetProjectError(ex3);
                    Exception ex4 = ex3;
                    throw new ArgumentOutOfRangeException(null, ex4.Message);
                }
                num9 = (int)(num10 - num8);
                minValue2 = minValue2.AddMinutes(unchecked((double)num9));
            }
            return minValue2;
        }
    }

public static string ToDmtfDateTime(DateTime date)
{
    string empty = string.Empty;
    TimeSpan utcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(date);
    checked
    {
        long value = (long)Math.Round(unchecked((double)utcOffset.Ticks / 600000000.0));
        if (Math.Abs(value) > 999)
        {
            date = date.ToUniversalTime();
            empty = "+000";
        }
        else if (utcOffset.Ticks >= 0)
        {
            empty = "+" + ((long)Math.Round(unchecked((double)utcOffset.Ticks / 600000000.0))).ToString().PadLeft(3, '0');
        }
        else
        {
            string text = value.ToString();
            empty = "-" + text.Substring(1, text.Length - 1).PadLeft(3, '0');
        }
        string str = date.Year.ToString().PadLeft(4, '0') + date.Month.ToString().PadLeft(2, '0') + date.Day.ToString().PadLeft(2, '0') + date.Hour.ToString().PadLeft(2, '0') + date.Minute.ToString().PadLeft(2, '0') + date.Second.ToString().PadLeft(2, '0') + ".";
        DateTime dateTime = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, 0);
        string text2 = ((long)Math.Round(unchecked((double)checked((date.Ticks - dateTime.Ticks) * 1000) / 10000.0))).ToString();
        if (text2.Length > 6)
        {
            text2 = text2.Substring(0, 6);
        }
        return str + text2.PadLeft(6, '0') + empty;
    }
}

    private bool DHCPLeaseExpiresNull()
	{
		if (!IsDHCPLeaseExpiresNull)
		{
			return true;
		}
		return false;
	}

	private bool DHCPLeaseObtainedNull()
	{
		if (!IsDHCPLeaseObtainedNull)
		{
			return true;
		}
		return false;
	}

	private bool DNSEnabledForWINSResolutionNull()
	{
		if (!IsDNSEnabledForWINSResolutionNull)
		{
			return true;
		}
		return false;
	}

	private bool DomainDNSRegistrationEnabledNull()
	{
		if (!IsDomainDNSRegistrationEnabledNull)
		{
			return true;
		}
		return false;
	}

	private bool ForwardBufferMemoryNull()
	{
		if (!IsForwardBufferMemoryNull)
		{
			return true;
		}
		return false;
	}

	private bool FullDNSRegistrationEnabledNull()
	{
		if (!IsFullDNSRegistrationEnabledNull)
		{
			return true;
		}
		return false;
	}

	private bool IGMPLevelNull()
	{
		if (!IsIGMPLevelNull)
		{
			return true;
		}
		return false;
	}

	private bool IndexNull()
	{
		if (!IsIndexNull)
		{
			return true;
		}
		return false;
	}
    /*
	private bool ᜕()
	{
		if (!IsInterfaceIndexNull)
		{
			return true;
		}
		return false;
	}

	private bool ᜔()
	{
		if (!IsIPConnectionMetricNull)
		{
			return true;
		}
		return false;
	}

	private bool ᜓ()
	{
		if (!IsIPEnabledNull)
		{
			return true;
		}
		return false;
	}

	private bool ᜒ()
	{
		if (!IsIPFilterSecurityEnabledNull)
		{
			return true;
		}
		return false;
	}

	private bool ᜑ()
{
    if (!IsIPPortSecurityEnabledNull)
    {
        return true;
    }
    return false;
}

private bool ᜐ()
{
    if (!IsIPUseZeroBroadcastNull)
    {
        return true;
    }
    return false;
}

private bool ᜏ()
{
    if (!IsIPXEnabledNull)
    {
        return true;
    }
    return false;
}

private bool ᜎ()
{
    if (!IsIPXMediaTypeNull)
    {
        return true;
    }
    return false;
}

private bool ᜍ()
	{
		if (!IsKeepAliveIntervalNull)
		{
			return true;
		}
		return false;
	}

	private bool ᜌ()
{
    if (!IsKeepAliveTimeNull)
    {
        return true;
    }
    return false;
}

private bool ᜋ()
{
    if (!IsMTUNull)
    {
        return true;
    }
    return false;
}

private bool ᜊ()
{
    if (!IsNumForwardPacketsNull)
    {
        return true;
    }
    return false;
}

private bool ᜉ()
{
    if (!IsPMTUBHDetectEnabledNull)
    {
        return true;
    }
    return false;
}

private bool ᜈ()
{
    if (!IsPMTUDiscoveryEnabledNull)
    {
        return true;
    }
    return false;
}

private bool ᜇ()
{
    if (!IsTcpipNetbiosOptionsNull)
    {
        return true;
    }
    return false;
}

private bool ᜆ()
{
    if (!IsTcpMaxConnectRetransmissionsNull)
    {
        return true;
    }
    return false;
}

private bool ᜅ()
{
    if (!IsTcpMaxDataRetransmissionsNull)
    {
        return true;
    }
    return false;
}

private bool ᜄ()
{
    if (!IsTcpNumConnectionsNull)
    {
        return true;
    }
    return false;
}

private bool ᜃ()
{
    if (!IsTcpUseRFC1122UrgentPointerNull)
    {
        return true;
    }
    return false;
}

private bool ᜂ()
{
    if (!IsTcpWindowSizeNull)
    {
        return true;
    }
    return false;
}

private bool ᜁ()
{
    if (!IsWINSEnableLMHostsLookupNull)
    {
        return true;
    }
    return false;
}
*/
[Browsable(true)]
public void CommitObject()
{
    if (!this.res)
    {
        this.mObject.Put();
    }
}

[Browsable(true)]
public void CommitObject(PutOptions putOptions)
{
    if (!this.res)
    {
        this.mObject.Put(putOptions);
    }
}

private void mObj()
{
    this.result = true;
    this.res = false;
}

private static string mObj(uint A_0)
{
    return "root\\CimV2:Win32_NetworkAdapterConfiguration" + (".Index=" + A_0.ToString());
}

private void mObj(ManagementScope A_0, ManagementPath A_1, ObjectGetOptions A_2)
{
    mObj();
    if (A_1 != null && !ᜁ(A_0, A_1, A_2))
    {
        throw new ArgumentException("El nombre de clase no coincide.");
    }
    this.mObject = new ManagementObject(A_0, A_1, A_2);
    this.mSystemProperties = new ManagementSystemProperties(this.mObject);
    this.mBaseObject = this.mObject;
}

public static NetworkAdapterConfigurationCollection GetInstances()
{
    return GetInstances(null, null, null);
}

public static NetworkAdapterConfigurationCollection GetInstances(string condition)
{
    return GetInstances(null, condition, null);
}

public static NetworkAdapterConfigurationCollection GetInstances(string[] selectedProperties)
{
    return GetInstances(null, null, selectedProperties);
}

public static NetworkAdapterConfigurationCollection GetInstances(string condition, string[] selectedProperties)
{
    return GetInstances(null, condition, selectedProperties);
}

public static NetworkAdapterConfigurationCollection GetInstances(ManagementScope mgmtScope, EnumerationOptions enumOptions)
{
    if (mgmtScope == null)
    {
        if (NetworkAdapterConfiguration.mScope == null)
        {
            mgmtScope = new ManagementScope();
            mgmtScope.Path.NamespacePath = "root\\CimV2";
        }
        else
        {
            mgmtScope = NetworkAdapterConfiguration.mScope;
        }
    }
    ManagementPath managementPath = new ManagementPath();
    managementPath.ClassName = "Win32_NetworkAdapterConfiguration";
    managementPath.NamespacePath = "root\\CimV2";
    ManagementClass managementClass = new ManagementClass(mgmtScope, managementPath, null);
    if (enumOptions == null)
    {
        enumOptions = new EnumerationOptions();
        enumOptions.EnsureLocatable = true;
    }
    return new NetworkAdapterConfigurationCollection(managementClass.GetInstances(enumOptions));
}

public static NetworkAdapterConfigurationCollection GetInstances(ManagementScope mgmtScope, string condition)
{
    return GetInstances(mgmtScope, condition, null);
}

public static NetworkAdapterConfigurationCollection GetInstances(ManagementScope mgmtScope, string[] selectedProperties)
{
    return GetInstances(mgmtScope, null, selectedProperties);
}

public static NetworkAdapterConfigurationCollection GetInstances(ManagementScope mgmtScope, string condition, string[] selectedProperties)
{
    if (mgmtScope == null)
    {
        if (NetworkAdapterConfiguration.mScope == null)
        {
            mgmtScope = new ManagementScope();
            mgmtScope.Path.NamespacePath = "root\\CimV2";
        }
        else
        {
            mgmtScope = NetworkAdapterConfiguration.mScope;
        }
    }
    ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(mgmtScope, new SelectQuery("Win32_NetworkAdapterConfiguration", condition, selectedProperties));
    EnumerationOptions enumerationOptions = new EnumerationOptions();
    enumerationOptions.EnsureLocatable = true;
    managementObjectSearcher.Options = enumerationOptions;
    return new NetworkAdapterConfigurationCollection(managementObjectSearcher.Get());
}

[Browsable(true)]
public static NetworkAdapterConfiguration CreateInstance()
{
    ManagementScope managementScope = null;
    if (NetworkAdapterConfiguration.mScope == null)
    {
        managementScope = new ManagementScope();
        managementScope.Path.NamespacePath = NetworkAdapterConfiguration.root;
    }
    else
    {
        managementScope = NetworkAdapterConfiguration.mScope;
    }
    ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
    ManagementClass managementClass = new ManagementClass(managementScope, path, null);
    return new NetworkAdapterConfiguration(managementClass.CreateInstance());
}

[Browsable(true)]
public void Delete()
{
    this.mObject.Delete();
}

public uint DisableIPSec()
{
    if (!this.res)
    {
        ManagementBaseObject inParameters = null;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("DisableIPSec", inParameters, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public uint EnableDHCP()
{
    if (!this.res)
    {
        ManagementBaseObject inParameters = null;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("EnableDHCP", inParameters, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint EnableDNS(string DNSDomain, string[] DNSDomainSuffixSearchOrder, string DNSHostName, string[] DNSServerSearchOrder)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("EnableDNS");
        managementBaseObject["DNSDomain"] = DNSDomain;
        managementBaseObject["DNSDomainSuffixSearchOrder"] = DNSDomainSuffixSearchOrder;
        managementBaseObject["DNSHostName"] = DNSHostName;
        managementBaseObject["DNSServerSearchOrder"] = DNSServerSearchOrder;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("EnableDNS", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint EnableIPFilterSec(bool IPFilterSecurityEnabled)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("EnableIPFilterSec");
        managementBaseObject["IPFilterSecurityEnabled"] = IPFilterSecurityEnabled;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("EnableIPFilterSec", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public uint EnableIPSec(string[] IPSecPermitIPProtocols, string[] IPSecPermitTCPPorts, string[] IPSecPermitUDPPorts)
{
    if (!this.res)
    {
        ManagementBaseObject managementBaseObject = null;
        managementBaseObject = this.mObject.GetMethodParameters("EnableIPSec");
        managementBaseObject["IPSecPermitIPProtocols"] = IPSecPermitIPProtocols;
        managementBaseObject["IPSecPermitTCPPorts"] = IPSecPermitTCPPorts;
        managementBaseObject["IPSecPermitUDPPorts"] = IPSecPermitUDPPorts;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("EnableIPSec", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public uint EnableStatic(string[] IPAddress, string[] SubnetMask)
{
    if (!this.res)
    {
        ManagementBaseObject managementBaseObject = null;
        managementBaseObject = this.mObject.GetMethodParameters("EnableStatic");
        managementBaseObject["IPAddress"] = IPAddress;
        managementBaseObject["SubnetMask"] = SubnetMask;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("EnableStatic", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint EnableWINS(bool DNSEnabledForWINSResolution, bool WINSEnableLMHostsLookup, string WINSHostLookupFile, string WINSScopeID)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("EnableWINS");
        managementBaseObject["DNSEnabledForWINSResolution"] = DNSEnabledForWINSResolution;
        managementBaseObject["WINSEnableLMHostsLookup"] = WINSEnableLMHostsLookup;
        managementBaseObject["WINSHostLookupFile"] = WINSHostLookupFile;
        managementBaseObject["WINSScopeID"] = WINSScopeID;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("EnableWINS", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public uint ReleaseDHCPLease()
{
    if (!this.res)
    {
        ManagementBaseObject inParameters = null;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("ReleaseDHCPLease", inParameters, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint ReleaseDHCPLeaseAll()
{
    if (true)
    {
        ManagementBaseObject inParameters = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(new ManagementClass(NetworkAdapterConfiguration.mScope, path, null).InvokeMethod("ReleaseDHCPLeaseAll", inParameters, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public uint RenewDHCPLease()
{
    if (!this.res)
    {
        ManagementBaseObject inParameters = null;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("RenewDHCPLease", inParameters, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint RenewDHCPLeaseAll()
{
    if (true)
    {
        ManagementBaseObject inParameters = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(new ManagementClass(NetworkAdapterConfiguration.mScope, path, null).InvokeMethod("RenewDHCPLeaseAll", inParameters, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetArpAlwaysSourceRoute(bool ArpAlwaysSourceRoute)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetArpAlwaysSourceRoute");
        managementBaseObject["ArpAlwaysSourceRoute"] = ArpAlwaysSourceRoute;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetArpAlwaysSourceRoute", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetArpUseEtherSNAP(bool ArpUseEtherSNAP)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetArpUseEtherSNAP");
        managementBaseObject["ArpUseEtherSNAP"] = ArpUseEtherSNAP;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetArpUseEtherSNAP", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetDatabasePath(string DatabasePath)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetDatabasePath");
        managementBaseObject["DatabasePath"] = DatabasePath;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetDatabasePath", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetDeadGWDetect(bool DeadGWDetectEnabled)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetDeadGWDetect");
        managementBaseObject["DeadGWDetectEnabled"] = DeadGWDetectEnabled;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetDeadGWDetect", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetDefaultTOS(byte DefaultTOS)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetDefaultTOS");
        managementBaseObject["DefaultTOS"] = DefaultTOS;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetDefaultTOS", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetDefaultTTL(byte DefaultTTL)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetDefaultTTL");
        managementBaseObject["DefaultTTL"] = DefaultTTL;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetDefaultTTL", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public uint SetDNSDomain(string DNSDomain)
{
    if (!this.res)
    {
        ManagementBaseObject managementBaseObject = null;
        managementBaseObject = this.mObject.GetMethodParameters("SetDNSDomain");
        managementBaseObject["DNSDomain"] = DNSDomain;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("SetDNSDomain", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public uint SetDNSServerSearchOrder(string[] DNSServerSearchOrder)
{
    if (!this.res)
    {
        ManagementBaseObject managementBaseObject = null;
        managementBaseObject = this.mObject.GetMethodParameters("SetDNSServerSearchOrder");
        managementBaseObject["DNSServerSearchOrder"] = DNSServerSearchOrder;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("SetDNSServerSearchOrder", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetDNSSuffixSearchOrder(string[] DNSDomainSuffixSearchOrder)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetDNSSuffixSearchOrder");
        managementBaseObject["DNSDomainSuffixSearchOrder"] = DNSDomainSuffixSearchOrder;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetDNSSuffixSearchOrder", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public uint SetDynamicDNSRegistration(bool DomainDNSRegistrationEnabled, bool FullDNSRegistrationEnabled)
{
    if (!this.res)
    {
        ManagementBaseObject managementBaseObject = null;
        managementBaseObject = this.mObject.GetMethodParameters("SetDynamicDNSRegistration");
        managementBaseObject["DomainDNSRegistrationEnabled"] = DomainDNSRegistrationEnabled;
        managementBaseObject["FullDNSRegistrationEnabled"] = FullDNSRegistrationEnabled;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("SetDynamicDNSRegistration", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetForwardBufferMemory(uint ForwardBufferMemory)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetForwardBufferMemory");
        managementBaseObject["ForwardBufferMemory"] = ForwardBufferMemory;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetForwardBufferMemory", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public uint SetGateways(string[] DefaultIPGateway, ushort[] GatewayCostMetric)
{
    if (!this.res)
    {
        ManagementBaseObject managementBaseObject = null;
        managementBaseObject = this.mObject.GetMethodParameters("SetGateways");
        managementBaseObject["DefaultIPGateway"] = DefaultIPGateway;
        managementBaseObject["GatewayCostMetric"] = GatewayCostMetric;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("SetGateways", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetIGMPLevel(byte IGMPLevel)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetIGMPLevel");
        managementBaseObject["IGMPLevel"] = IGMPLevel;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetIGMPLevel", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public uint SetIPConnectionMetric(uint IPConnectionMetric)
{
    if (!this.res)
    {
        ManagementBaseObject managementBaseObject = null;
        managementBaseObject = this.mObject.GetMethodParameters("SetIPConnectionMetric");
        managementBaseObject["IPConnectionMetric"] = IPConnectionMetric;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("SetIPConnectionMetric", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetIPUseZeroBroadcast(bool IPUseZeroBroadcast)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetIPUseZeroBroadcast");
        managementBaseObject["IPUseZeroBroadcast"] = IPUseZeroBroadcast;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetIPUseZeroBroadcast", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public uint SetIPXFrameTypeNetworkPairs(uint[] IPXFrameType, string[] IPXNetworkNumber)
{
    if (!this.res)
    {
        ManagementBaseObject managementBaseObject = null;
        managementBaseObject = this.mObject.GetMethodParameters("SetIPXFrameTypeNetworkPairs");
        managementBaseObject["IPXFrameType"] = IPXFrameType;
        managementBaseObject["IPXNetworkNumber"] = IPXNetworkNumber;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("SetIPXFrameTypeNetworkPairs", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetIPXVirtualNetworkNumber(string IPXVirtualNetNumber)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetIPXVirtualNetworkNumber");
        managementBaseObject["IPXVirtualNetNumber"] = IPXVirtualNetNumber;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetIPXVirtualNetworkNumber", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetKeepAliveInterval(uint KeepAliveInterval)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetKeepAliveInterval");
        managementBaseObject["KeepAliveInterval"] = KeepAliveInterval;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetKeepAliveInterval", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetKeepAliveTime(uint KeepAliveTime)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetKeepAliveTime");
        managementBaseObject["KeepAliveTime"] = KeepAliveTime;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetKeepAliveTime", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetMTU(uint MTU)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetMTU");
        managementBaseObject["MTU"] = MTU;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetMTU", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetNumForwardPackets(uint NumForwardPackets)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetNumForwardPackets");
        managementBaseObject["NumForwardPackets"] = NumForwardPackets;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetNumForwardPackets", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetPMTUBHDetect(bool PMTUBHDetectEnabled)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetPMTUBHDetect");
        managementBaseObject["PMTUBHDetectEnabled"] = PMTUBHDetectEnabled;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetPMTUBHDetect", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetPMTUDiscovery(bool PMTUDiscoveryEnabled)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetPMTUDiscovery");
        managementBaseObject["PMTUDiscoveryEnabled"] = PMTUDiscoveryEnabled;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetPMTUDiscovery", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public uint SetTcpipNetbios(uint TcpipNetbiosOptions)
{
    if (!this.res)
    {
        ManagementBaseObject managementBaseObject = null;
        managementBaseObject = this.mObject.GetMethodParameters("SetTcpipNetbios");
        managementBaseObject["TcpipNetbiosOptions"] = TcpipNetbiosOptions;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("SetTcpipNetbios", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetTcpMaxConnectRetransmissions(uint TcpMaxConnectRetransmissions)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetTcpMaxConnectRetransmissions");
        managementBaseObject["TcpMaxConnectRetransmissions"] = TcpMaxConnectRetransmissions;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetTcpMaxConnectRetransmissions", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetTcpMaxDataRetransmissions(uint TcpMaxDataRetransmissions)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetTcpMaxDataRetransmissions");
        managementBaseObject["TcpMaxDataRetransmissions"] = TcpMaxDataRetransmissions;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetTcpMaxDataRetransmissions", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetTcpNumConnections(uint TcpNumConnections)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetTcpNumConnections");
        managementBaseObject["TcpNumConnections"] = TcpNumConnections;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetTcpNumConnections", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetTcpUseRFC1122UrgentPointer(bool TcpUseRFC1122UrgentPointer)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetTcpUseRFC1122UrgentPointer");
        managementBaseObject["TcpUseRFC1122UrgentPointer"] = TcpUseRFC1122UrgentPointer;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetTcpUseRFC1122UrgentPointer", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public static uint SetTcpWindowSize(ushort TcpWindowSize)
{
    if (true)
    {
        ManagementBaseObject managementBaseObject = null;
        ManagementPath path = new ManagementPath(NetworkAdapterConfiguration.w32_N);
        ManagementClass managementClass = new ManagementClass(NetworkAdapterConfiguration.mScope, path, null);
        managementBaseObject = managementClass.GetMethodParameters("SetTcpWindowSize");
        managementBaseObject["TcpWindowSize"] = TcpWindowSize;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(managementClass.InvokeMethod("SetTcpWindowSize", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}

public uint SetWINSServer(string WINSPrimaryServer, string WINSSecondaryServer)
{
    if (!this.res)
    {
        ManagementBaseObject managementBaseObject = null;
        managementBaseObject = this.mObject.GetMethodParameters("SetWINSServer");
        managementBaseObject["WINSPrimaryServer"] = WINSPrimaryServer;
        managementBaseObject["WINSSecondaryServer"] = WINSSecondaryServer;
        return Convert.ToUInt32(RuntimeHelpers.GetObjectValue(this.mObject.InvokeMethod("SetWINSServer", managementBaseObject, null).Properties["ReturnValue"].Value));
    }
    return Convert.ToUInt32(0);
}
}
