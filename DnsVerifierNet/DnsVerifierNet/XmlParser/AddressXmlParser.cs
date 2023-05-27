using DnsVerifierNet.DnsRecords.DnsRecordTypes;
using DnsVerifierNet.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DnsVerifierNet.XmlParser
{
    public class AddressXmlParser
    {

        private string DomainName;
        public void SetDomainName(String domainName)
        {
            DomainName = domainName;
        }
        public string GetDomainName()
        {
            return DomainName;
        }

        public AddressXmlParser(String domainName) 
        {
            DomainName = domainName;    
        }


        public DnsRecord ParseRecordFromXElement(XElement xElement)
        {
            var eName = xElement.Name.ToString();
            
            switch (eName)
            {
                case "ARecord":
                    ParseADnsRecordFromXElement(xElement);
                    break;
                case "TxtRecord":
                    Console.WriteLine("TxtRecord");

                    break;
                case "MxRecord":
                    Console.WriteLine("MxRecord");

                    break;
                case "CnameRecord":
                    Console.WriteLine("CnameRecord");

                    break;
                case "NsRecord":
                    Console.WriteLine("NsRecord");

                    break;
                default:
                    Console.WriteLine("Unknown!!");
                    break;
            }

            return null;
        }

        private ADnsRecord ParseADnsRecordFromXElement(XElement xElement)
        {

            var ttl = 0;
            var prefix = "";
            var address = "";

            foreach (XElement e in xElement.Elements())
            {
                switch(e.Name.ToString())
                {
                    case "ttl":
                        ttl = Convert.ToInt32(e.Value);
                        break;
                    case "prefix":
                        prefix = Convert.ToString(e.Value);
                        break;
                    case "address":
                        address = Convert.ToString(e.Value);
                        break;
                    default:
                        break;
                }

                var aDnsRecord = new ADnsRecord(DomainName, ttl, prefix, address);
                
                Console.WriteLine(aDnsRecord.ToString());
            }
            return null;
        }

    }
}
