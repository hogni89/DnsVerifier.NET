using DnsVerifierNet.Records;

namespace DnsVerifierNet.DnsRecords.DnsRecordTypes
{
    public class ADnsRecord : DnsRecord
    {

        private string Address { get; set; }

        public ADnsRecord(string domainName, int ttl, string address) : base("A", domainName, ttl)
        {
            Address = address;
        }

        public override string ToString()
        {
            var result = base.ToString() + ", address: " + Address;
            return result;
        }
    }
}
