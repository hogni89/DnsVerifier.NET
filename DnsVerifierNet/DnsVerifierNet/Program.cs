// See https://aka.ms/new-console-template for more information

using DnsVerifierNet.DnsRecords.DnsRecordTypes;

var aRecord = new ADnsRecord("google.com", 300, "142.251.41.14");
var txtRecord = new TxtDnsRecord("google.com", 300, "This is a text record");
var MxRecord = new MxDnsRecord("google.com", 300, 10, "smtp.google.com", "172.253.115.26");
var CnameRecord = new CnameDnsRecord("autodiscover.google.com", 300, "autodiscover.office.com");
var NsRecord = new NsDnsRecord("google.com", 86400, "ns1.google.com", "216.239.32.10");

Console.WriteLine(aRecord.ToString());
Console.WriteLine(txtRecord.ToString());
Console.WriteLine(MxRecord.ToString());
Console.WriteLine(CnameRecord.ToString());
Console.WriteLine(NsRecord.ToString());
