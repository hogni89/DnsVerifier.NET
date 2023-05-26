using DnsVerifierNet.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnsVerifierNet.DnsRecords.DnsRecordTypes
{
    public class NsDnsRecord : DnsRecord
    {
        public string Domain;
        public string IpAddress;

        public NsDnsRecord(string domainName, int ttl, string domain, string ipAddress) : base("NS", domainName, ttl)
        {
            IpAddress = ipAddress;
            Domain = domainName;
        }

        public override string ToString()
        {
            var result = base.ToString() + ", domain: " + Domain + ", ip address: " + IpAddress;
            return result;
        }
    }
}
