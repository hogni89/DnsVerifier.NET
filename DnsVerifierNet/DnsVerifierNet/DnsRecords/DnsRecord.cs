using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnsVerifierNet.Records
{
    public class DnsRecord 
    {

        public string Type { get; set; }
        public string DomainName { get; set; }
        public int Ttl { get; set; }

        public DnsRecord(string type, string domainName, int ttl)
        {
            Type = type;
            DomainName = domainName;
            Ttl = ttl;
        }

    }
}
