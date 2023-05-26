
using DnsVerifierNet.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnsVerifierNet.DnsRecords
{
    
    public class DnsRecords
    {
        private List<DnsRecord> Records = new List<DnsRecord>();

        public DnsRecords() { }

        public List<DnsRecord> AddDnsRecord(DnsRecord record)
        {
            Records.Add(record);
            return Records;
        }

        public List<DnsRecord> GetDnsRecords()
        {
            return Records;
        }

    }
}
