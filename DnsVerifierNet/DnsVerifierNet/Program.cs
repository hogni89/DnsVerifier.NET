// See https://aka.ms/new-console-template for more information

using DnsVerifierNet.DnsRecords;
using DnsVerifierNet.DnsRecords.DnsRecordTypes;

var domainName = "google.com";

var aRecord1 = new ADnsRecord(domainName, 300, null, "142.251.41.14");
var aRecord2 = new ADnsRecord(domainName, 300, "test", "142.251.41.15");
var txtRecord = new TxtDnsRecord(domainName, 300, "This is a text record");
var MxRecord = new MxDnsRecord(domainName, 300, 10, "smtp.google.com", "172.253.115.26");
var CnameRecord = new CnameDnsRecord(domainName, 300, "autodiscover", "autodiscover.office.com");
var NsRecord = new NsDnsRecord(domainName, 86400, "ns1.google.com", "216.239.32.10");


var DnsRecords = new DnsRecords();
DnsRecords.AddDnsRecord(aRecord1);
DnsRecords.AddDnsRecord(aRecord2);
DnsRecords.AddDnsRecord(txtRecord); 
DnsRecords.AddDnsRecord(MxRecord);
DnsRecords.AddDnsRecord(CnameRecord);   
DnsRecords.AddDnsRecord(NsRecord);

var records = DnsRecords.GetDnsRecords();

foreach (var r in records)
{
    Console.WriteLine(r.ToString());
}

