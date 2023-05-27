using DnsVerifierNet.Records;
using System.Xml.Serialization;

namespace DnsVerifierNet.DnsRecords.DnsRecordTypes
{
    [XmlType("NsDnsRecord")]
    public class NsDnsRecord : DnsRecord
    {
        [XmlElement("Value")]
        public string Value;

        [XmlElement("IpAddress")]
        public string IpAddress;

        public NsDnsRecord() 
        {
            RecordType = "Ns";
        }

        public NsDnsRecord(string domainName, int ttl, string value, string ipAddress)
        {
            this.Domain = domainName;
            this.Ttl = ttl;
            IpAddress = ipAddress;
            Value = value;
            RecordType = "Ns";
        }
    }
}
