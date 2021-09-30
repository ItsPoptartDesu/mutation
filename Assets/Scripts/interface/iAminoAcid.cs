using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//iNucleotide.NUCLEOTIDE i in System.Enum.GetValues(typeof(iNucleotide.NUCLEOTIDE))

public abstract class iAminoAcid
{
    public iNucleotide[] nucleotides = new iNucleotide[4];
    public Dictionary<iNucleotide.NUCLEOTIDE,iDNAData> aminoAcids = new Dictionary<iNucleotide.NUCLEOTIDE, iDNAData>();
    protected abstract void CompressNucleotides();
    public abstract void DEBUG_PrintInfo();
}
