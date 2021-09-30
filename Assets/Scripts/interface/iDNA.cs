using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class iDNA
{
    public Dictionary<iNucleotide.NUCLEOTIDE, iDNAData> affinity;

    protected int dnaSplitCount = 4;

    protected List<iNucleotide> dna;
    public abstract void AddNucleotide(iNucleotide _nucleotide);

    protected List<iAminoAcid> aminoAcids;
    protected abstract void MakeAminoAcids();

    protected List<iProtein> proteins;
    protected abstract void MakeProteins();

    protected List<iCell> cells;
    protected abstract void MakeCells();

    protected abstract void CompressCells();
}
