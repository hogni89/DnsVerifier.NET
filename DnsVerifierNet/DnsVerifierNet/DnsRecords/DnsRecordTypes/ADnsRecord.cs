using DnsVerifierNet.Records;
using System.Xml.Serialization;

namespace DnsVerifierNet.DnsRecords.DnsRecordTypes
{
    [XmlType("ADnsRecord")]
    public class ADnsRecord : DnsRecord
    {
        [XmlElement("Address")]
        public string Address { get; set; }

        [XmlElement("Prefix")]
        public string Prefix { get; set; }

        public ADnsRecord() { }

        public ADnsRecord(string domain, int ttl, string prefix, string address)
        {
            this.Ttl = ttl;
            this.Domain = domain;
            this.Address = address;
            this.Prefix = prefix;
        }
    }
}
