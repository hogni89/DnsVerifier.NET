using DnsVerifierNet.Records;
using System.Xml.Serialization;

namespace DnsVerifierNet.DnsRecords.DnsRecordTypes
{
    [XmlType("TxtDnsRecord")]
    public class TxtDnsRecord : DnsRecord
    {
        [XmlElement("Value")]
        public string Value { get; set; }

        public TxtDnsRecord() { }
        public TxtDnsRecord(string domainName, int ttl, string value)
        {
            Value = value;
            this.Domain = domainName;
            this.Ttl = ttl;
        }

    }
}
