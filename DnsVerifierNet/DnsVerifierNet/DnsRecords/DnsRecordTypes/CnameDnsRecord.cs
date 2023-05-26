using DnsVerifierNet.Records;

namespace DnsVerifierNet.DnsRecords.DnsRecordTypes
{
    public class CnameDnsRecord : DnsRecord
    {
        public string CanonicalName;
        public CnameDnsRecord(string domainName, int ttl, string canonicalName) : base("CNAME", domainName, ttl)
        {
            CanonicalName = canonicalName;
        }

        public override string ToString()
        {
            var result = base.ToString() + ", canonical name: " + CanonicalName;
            return result;
        }
    }
}
