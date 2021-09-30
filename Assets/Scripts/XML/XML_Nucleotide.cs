using System.Xml;
using System.Xml.Serialization;

public class XML_Nucleotides
{
    [XmlAttribute("NucleotideTag")]
    public string NucleotideTag;

    [XmlAttribute("IntrinsicValue")]
    public string IntrinsicValue;
    
}