using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//iNucleotide.NUCLEOTIDE i in System.Enum.GetValues(typeof(iNucleotide.NUCLEOTIDE))
public class AminoAcidValues
{
    public float weight;
    public float value;
    public AminoAcidValues(float _w, float _v){
        weight = _w;
        value = _v;
    }
}
public abstract class iAminoAcid
{
    public iNucleotide[] nucleotides = new iNucleotide[4];
    public Dictionary<iNucleotide.NUCLEOTIDE,AminoAcidValues> aminoAcids = new Dictionary<iNucleotide.NUCLEOTIDE, AminoAcidValues>();
    protected abstract void CompressNucleotides();
    public abstract void DEBUG_PrintInfo();
}
