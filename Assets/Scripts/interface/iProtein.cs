using System.Collections;
using System.Collections.Generic;
public class ProteinValues
{
    public float weight;
    public float value;
    public ProteinValues(float _w, float _v)
    {
        weight = _w;
        value = _v;
    }
}

public abstract class iProtein {
    public iAminoAcid[] baseAminoAcids = new iAminoAcid[4];

    public Dictionary<iNucleotide.NUCLEOTIDE, ProteinValues> protiens = new Dictionary<iNucleotide.NUCLEOTIDE, ProteinValues>();

    public abstract void CompressAminoAcids();
    public abstract void DEBUG_PrintInfo();

}