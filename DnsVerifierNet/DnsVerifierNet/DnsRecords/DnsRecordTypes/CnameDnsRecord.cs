using DnsVerifierNet.Records;

namespace DnsVerifierNet.DnsRecords.DnsRecordTypes
{
    public class CnameDnsRecord : DnsRecord
    {
        public string CanonicalName;
        public string Prefix;
        public CnameDnsRecord(string domainName, int ttl, string prefix, string canonicalName) : base("CNAME", domainName, ttl)
        {
            CanonicalName = canonicalName;
            Prefix = prefix;
        }

        public override string ToString()
        {
            var result = base.ToString(Prefix + "." + base.DomainName) + ", canonical name: " + CanonicalName;
            return result;
        }
    }
}
