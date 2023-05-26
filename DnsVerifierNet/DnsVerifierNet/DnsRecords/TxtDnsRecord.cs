using DnsVerifierNet.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DnsVerifierNet.DnsRecords
{
    public class TxtDnsRecord : DnsRecord
    {
        public string Value;

        public TxtDnsRecord(string type, string domainName, int ttl, string value) : base(type, domainName, ttl)
        {
            Value = value;
        }

        public override string ToString()
        {
            var result = base.ToString() + ", value: " + Value;
            return result;
        }
    }
}
