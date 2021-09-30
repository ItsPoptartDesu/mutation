using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AminoAcid : iAminoAcid
{
    public AminoAcid(iNucleotide[] _nucleotides)
    {
        if (_nucleotides.Length != 4)
            Debug.LogError("AMINO ACID PARSING ERRORS NOT OF SUB SIZE FOUR");

        for (int i = 0; i < 4; ++i)
            nucleotides[i] = _nucleotides[i];

        CompressNucleotides();
    }
    protected override void CompressNucleotides()
    {
        //init the defaults
        for (int i = 0; i < 4; ++i)
        {
            var t = nucleotides[i].Nucleotide;
            if (!aminoAcids.ContainsKey(t))
                aminoAcids.Add(t, new iDNAData(nucleotides[i].IntrinsicValue));
            else
            {
                aminoAcids[t].weight ++;
                aminoAcids[t].value += nucleotides[i].IntrinsicValue;
                aminoAcids[t].amount++;
            }
        }
        //compress the weights
        foreach (var i in aminoAcids)
        {
            if (i.Value.value <= 0)
                continue;
            i.Value.weight /= 4.0f;
        }
    }
    public override void DEBUG_PrintInfo()
    {
        foreach (var i in aminoAcids)
        {
            if (i.Value.value > 0)
                Debug.Log($"{i.Value.amount} of {i.Key} with a weight of {i.Value.weight} and a value of {i.Value.value}");
        }
    }
}