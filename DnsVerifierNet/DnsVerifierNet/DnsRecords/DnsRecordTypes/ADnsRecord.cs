using DnsVerifierNet.Records;
using System.Xml.Serialization;

namespace DnsVerifierNet.DnsRecords.DnsRecordTypes
{
    [XmlType("ADnsRecord")]
    public class ADnsRecord : DnsRecord
    {
        [XmlArray("Addresses")]
        [XmlArrayItem("IpAddress")]
        public List<string> Addresses { get; set; }

        [XmlElement("Prefix")]
        public string Prefix { get; set; }

        public ADnsRecord() 
        {
            this.RecordType = "A";
        }

        public ADnsRecord(string domain, int ttl, string prefix, List<string> address)
        {
            this.Ttl = ttl;
            this.Domain = domain;
            this.Addresses = address;
            this.Prefix = prefix;
            this.RecordType = "A";
        }
    }
}
