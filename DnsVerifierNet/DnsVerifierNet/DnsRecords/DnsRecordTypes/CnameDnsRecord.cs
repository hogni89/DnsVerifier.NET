using DnsVerifierNet.Records;
using System.Xml.Serialization;

namespace DnsVerifierNet.DnsRecords.DnsRecordTypes
{

    [XmlType("CnameDnsRecord")]
    public class CnameDnsRecord : DnsRecord
    {
        [XmlElement("canonicalName")]
        public string CanonicalName;

        [XmlElement("prefix")]
        public string Prefix;

        public CnameDnsRecord() { }
        public CnameDnsRecord(string domainName, int ttl, string prefix, string canonicalName)
        {
            this.Domain = domainName;
            this.Ttl = ttl;
            CanonicalName = canonicalName;
            Prefix = prefix;
        }
    }
}
