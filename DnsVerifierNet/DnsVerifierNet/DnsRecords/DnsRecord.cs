using DnsVerifierNet.DnsRecords.DnsRecordTypes;
using System.Xml.Serialization;

namespace DnsVerifierNet.Records
{
    [XmlType("DnsRecord")] // define Type
    [XmlInclude(typeof(ADnsRecord)), XmlInclude(typeof(TxtDnsRecord))]
    // include type class SpecialPerson and class SuperPerson
    public class DnsRecord
    {
        [XmlElement("Domain", DataType = "string")]
        public string Domain { get; set; }

        [XmlElement("ttl")]
        public int Ttl { get; set; }

        // Konstruktoren 
        public DnsRecord() { }

        public DnsRecord(int ttl, string domain)
        {
            this.Ttl = ttl;
            this.Domain = domain;
        }
    }
}
