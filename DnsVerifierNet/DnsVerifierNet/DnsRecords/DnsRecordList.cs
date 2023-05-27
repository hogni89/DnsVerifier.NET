
using DnsVerifierNet.Records;
using System.Xml.Serialization;

namespace DnsVerifierNet.DnsRecordList
{

    [XmlRoot("DnsRecordList")]
    [XmlInclude(typeof(DnsRecord))] // include type class Person
    public class DnsRecordList
    {
        [XmlArray("DnsRecordArray")]
        [XmlArrayItem("DnsRecordObject")]
        public List<DnsRecord> dnsRecords = new List<DnsRecord>();

        [XmlElement("Domain")]
        public string Domain { get; set; }

        // Konstruktoren 
        public DnsRecordList() { }

        public DnsRecordList(string domain)
        {
            this.Domain = domain;
        }

        public void AddDnsRecord(DnsRecord dnsRecord)
        {
            dnsRecords.Add(dnsRecord);
        }
    }
}
