// See https://aka.ms/new-console-template for more information

using DnsVerifierNet.DnsRecords;

var aRecord = new ADnsRecord("A", "google.com", 300, "142.251.41.14");

Console.WriteLine(aRecord.getAsString());
