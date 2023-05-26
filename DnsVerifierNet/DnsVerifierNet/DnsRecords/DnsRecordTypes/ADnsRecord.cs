using DnsVerifierNet.Records;

namespace DnsVerifierNet.DnsRecords.DnsRecordTypes
{
    public class ADnsRecord : DnsRecord
    {

        private string Address { get; set; }
        private string? Prefix { get; set; }

        public ADnsRecord(string domainName, int ttl, string? prefix, string address) : base("A", domainName, ttl)
        {
            Address = address;
            Prefix = prefix;
        }

        public override string ToString()
        {
            var result = "";

            if (Prefix == null)
            {
                result = base.ToString() + ", address: " + Address;
            } else
            {
                result = base.ToString(Prefix + "." + DomainName) + ", address: " + Address;
            }

            return result;
        }
    }
}
