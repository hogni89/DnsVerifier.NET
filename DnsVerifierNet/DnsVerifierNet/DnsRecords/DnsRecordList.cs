
using DnsVerifierNet.DnsRecords.DnsRecordTypes;
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

        [XmlArray("ADnsRecordArray")]
        [XmlArrayItem("ADnsRecordObject")]
        public List<ADnsRecord> aDnsRecords = new List<ADnsRecord>();

        [XmlArray("CnameDnsRecordArray")]
        [XmlArrayItem("CnameDnsRecordObject")]
        public List<CnameDnsRecord> cnameDnsRecords = new List<CnameDnsRecord>();

        [XmlArray("MxDnsRecordArray")]
        [XmlArrayItem("MxDnsRecordObject")]
        public List<MxDnsRecord> mxDnsRecords = new List<MxDnsRecord>();

        [XmlArray("NsDnsRecordArray")]
        [XmlArrayItem("NsDnsRecordObject")]
        public List<NsDnsRecord> nsDnsRecords = new List<NsDnsRecord>();

        [XmlArray("TxtDnsRecordArray")]
        [XmlArrayItem("TxtDnsRecordObject")]
        public List<TxtDnsRecord> txtDnsRecords = new List<TxtDnsRecord>();

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
            switch (dnsRecord.RecordType)
            {
                case "A":
                    aDnsRecords.Add((ADnsRecord)dnsRecord);
                    break;
                case "Cname":
                    cnameDnsRecords.Add((CnameDnsRecord)dnsRecord);
                    break;
                case "Mx":
                    mxDnsRecords.Add((MxDnsRecord)dnsRecord);
                    break;
                case "Ns":
                    nsDnsRecords.Add((NsDnsRecord)dnsRecord);
                    break;
                case "Txt":
                    txtDnsRecords.Add((TxtDnsRecord)dnsRecord);
                    break;
                default:
                    dnsRecords.Add(dnsRecord);
                    break;
            }
        }
    }
}
