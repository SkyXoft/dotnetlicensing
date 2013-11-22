using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DotNetLicensing
{
    public class License
    {
        public bool VerifyXmlDocument(string publicKey, string licenseContent)
        {
            

            RSA key = RSA.Create();
            key.FromXmlString(publicKey);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(licenseContent);
            SignedXml sxml = new SignedXml(doc);
            try
            {
                // Find signature node
                XmlNode sig = doc.GetElementsByTagName("Signature")[0];
                sxml.LoadXml((XmlElement)sig);
            }
            catch (Exception ex)
            {
                // Not signed!
                return false;
            }
            return sxml.CheckSignature(key);
        }
        public XmlDocument SignXmlDocument(string licenseContent, string privateKey)
        {
            RSA key = RSA.Create();
            key.FromXmlString(privateKey);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(licenseContent);

            SignedXml sxml = new SignedXml(doc);
            sxml.SigningKey = key;
            sxml.SignedInfo.CanonicalizationMethod = SignedXml.XmlDsigCanonicalizationUrl;

            // Add reference to XML data
            Reference r = new Reference("");
            r.AddTransform(new XmlDsigEnvelopedSignatureTransform(false));
            sxml.AddReference(r);

            // Build signature
            sxml.ComputeSignature();

            // Attach signature to XML Document
            XmlElement sig = sxml.GetXml();
            doc.DocumentElement.AppendChild(sig);

            return doc;
        }
    }
}
