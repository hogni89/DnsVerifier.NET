// See https://aka.ms/new-console-template for more information

using DnsClient;
using DnsVerifierNet.DnsRecordList;
using DnsVerifierNet.DnsRecords.DnsRecordTypes;
using DnsVerifierNet.Records;
using System.Xml.Serialization;


var xmlPath = @"C:\Users\hbe\OneDrive - Effo\Documents\Git\DnsVerifier.NET\DnsVerifierNet\DnsVerifierNet\Resources\addresses.xml";

var domainName = "google.com";

var dnsRecords = new DnsRecordList();

var aRecord = new ADnsRecord(domainName, 300, null, new List<string>() { "172.217.169.14" });
var txtRecord = new TxtDnsRecord(domainName, 300, "This is a text record");
var MxRecord = new MxDnsRecord(domainName, 300, 10, "smtp.google.com", "172.253.115.26");
var CnameRecord = new CnameDnsRecord(domainName, 300, "autodiscover", "autodiscover.office.com");
var NsRecord = new NsDnsRecord(domainName, 86400, "ns1.google.com", "216.239.32.10");


dnsRecords.AddDnsRecord(aRecord);
dnsRecords.AddDnsRecord(txtRecord);
dnsRecords.AddDnsRecord(MxRecord);
dnsRecords.AddDnsRecord(CnameRecord);
dnsRecords.AddDnsRecord(NsRecord);

// Serialize 
Type[] dnsRecordTypes = {
    typeof(DnsRecord),
    typeof(ADnsRecord),
    typeof(TxtDnsRecord),
    typeof(MxDnsRecord),
    typeof(CnameDnsRecord),
    typeof(NsDnsRecord)
};
XmlSerializer serializer = new XmlSerializer(typeof(DnsRecordList), dnsRecordTypes);
FileStream fs = new FileStream(xmlPath, FileMode.Create);
serializer.Serialize(fs, dnsRecords);
fs.Close();
dnsRecords = null;

// Deserialize 
fs = new FileStream(xmlPath, FileMode.Open);
dnsRecords = (DnsRecordList)serializer.Deserialize(fs);
//serializer.Serialize(Console.Out, dnsRecords);
//Console.ReadLine();


var lookup = new LookupClient();

foreach (var a in dnsRecords.aDnsRecords)
{
    var result = await lookup.QueryAsync(a.Domain, QueryType.A);
    var record = result.Answers.ARecords().FirstOrDefault();

    var ip = record?.Address.ToString();
    var factIp = a.Addresses.FirstOrDefault();

    if (ip != factIp)
    {
        Console.WriteLine("IP address for " + a.Domain + " is " + ip + ", but was expected to be " + factIp);
    }
}




