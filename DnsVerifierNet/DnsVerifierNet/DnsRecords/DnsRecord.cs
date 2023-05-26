using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public override string ToString()
        {
            var result = "type: " + Type + ", domain name: " + DomainName + ", ttl: " + Ttl.ToString();
            return result;
        }

    }
}
