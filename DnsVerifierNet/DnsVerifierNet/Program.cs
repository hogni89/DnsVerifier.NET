// See https://aka.ms/new-console-template for more information

using DnsVerifierNet.DnsRecords;

var aRecord = new ADnsRecord("A", "google.com", 300, "142.251.41.14");
var txtRecord = new TxtDnsRecord("TXT", "google.com", 300, "This is a text record");
var MxRecord = new MxDnsRecord("MX", "google.com", 300, 10, "smtp.google.com", "172.253.115.26");

Console.WriteLine(aRecord.ToString());
Console.WriteLine(txtRecord.ToString());
Console.WriteLine(MxRecord.ToString());
