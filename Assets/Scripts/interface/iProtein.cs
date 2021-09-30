using System.Collections;
using System.Collections.Generic;

public abstract class iProtein {
    public iAminoAcid[] baseAminoAcids = new iAminoAcid[4];

    public Dictionary<iNucleotide.NUCLEOTIDE, iDNAData> protiens = new Dictionary<iNucleotide.NUCLEOTIDE, iDNAData>();

    public abstract void CompressAminoAcids();
    public abstract void DEBUG_PrintInfo();

}