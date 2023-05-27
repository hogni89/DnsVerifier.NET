using DnsVerifierNet.Records;
using System.Xml.Serialization;

namespace DnsVerifierNet.DnsRecords.DnsRecordTypes
{

    [XmlType("MxDnsRecord")]
    public class MxDnsRecord : DnsRecord
    {
        [XmlElement("Priority", DataType = "int")]
        public int Priority { get; set; }

        [XmlElement("Hostname")]
        public string Hostname { get; set; }

        [XmlElement("IpAddress")]
        public string IpAddress { get; set; }

        public MxDnsRecord() { }
        public MxDnsRecord(string domainName, int ttl, int priority, string hostname, string ipAddress)
        {
            this.Domain = domainName;
            this.Ttl = ttl; this.
            Priority = priority;
            Hostname = hostname;
            IpAddress = ipAddress;
        }
    }
}
