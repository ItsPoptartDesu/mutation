using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class iDNA : MutationState
{
    public Dictionary<iNucleotide.NUCLEOTIDE, iDNAData> affinity;

    protected int baseSplitCount = 4;
    protected int AminoAcidSplitCount = 4;
    protected int ProteinSplitCount = 4;
    protected int CellSplitCount = 4;

    public Dictionary<iNucleotide.NUCLEOTIDE, List<iNucleotide>> dna;
    public abstract void AddNucleotide(iNucleotide _nucleotide);

}
