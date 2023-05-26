using DnsVerifierNet.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnsVerifierNet.DnsRecords
{
    public class MxDnsRecord : DnsRecord
    {
        public int Priority { get; set; }
        public string Hostname { get; set; }
        public string IpAddress { get; set; }
        public MxDnsRecord(string type, string domainName, int ttl, int priority, string hostname, string ipAddress) : base(type, domainName, ttl)
        {
            Priority = priority;
            Hostname = hostname;
            IpAddress = ipAddress;
        }

        public override string ToString()
        {
            var result = base.ToString() + ", priority: " + Priority.ToString() + ", hostname: " + Hostname + ", ip address: " + IpAddress;
            return result;
        }
    }
}
