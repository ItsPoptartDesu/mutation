using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;

[XmlRoot("DNARoot")]
public class XMLDNARoot 
{
    [XmlArray("DNAHead")]
    [XmlArrayItem("DNA")]
    public List<XML_Nucleotides> xml_dna = new List<XML_Nucleotides>();
}