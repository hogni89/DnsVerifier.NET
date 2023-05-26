using DnsVerifierNet.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnsVerifierNet.DnsRecords
{
    public class ADnsRecord : DnsRecord
    {

        private string Address { get; set; }
        
        public ADnsRecord(string type, string domainName, int ttl, string address) : base(type, domainName, ttl)
        {
            this.Address = address; 
        }

        public override string ToString() 
        {
            var result = base.ToString() + ", address: " + Address;
            return result;
        }
    }
}
