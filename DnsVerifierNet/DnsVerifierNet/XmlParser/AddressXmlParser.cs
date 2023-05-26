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


        public AddressXmlParser() { }
       

        public DnsRecord ParseRecordFromXElement(XElement xElement)
        {
            var eName = xElement.Name.ToString();
            
            switch (eName)
            {
                case "ARecord":
                    Console.WriteLine("ARecord");
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

    }
}
