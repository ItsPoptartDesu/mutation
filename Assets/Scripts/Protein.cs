using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protein : iProtein
{
    public Protein(iAminoAcid[] _aa)
    {
        if (_aa.Length != 4)
            Debug.LogError("Protein PARSING ERRORS NOT OF SUB SIZE FOUR");

        for (int i = 0; i < 4; ++i)
            baseAminoAcids[i] = _aa[i];

        CompressAminoAcids();
    }

    public override void CompressAminoAcids()
    {
        //for each amino acid
        foreach (var aa in baseAminoAcids)
        {
            foreach (var n in aa.aminoAcids)
            {
                if (!protiens.ContainsKey(n.Key))
                    protiens.Add(n.Key, new iDNAData(n.Value.value));
                else
                {
                    protiens[n.Key].weight++;
                    protiens[n.Key].value += (n.Value.weight * n.Value.value);
                    protiens[n.Key].amount++;
                }
            }
        }
        foreach (var p in protiens)
        {
            p.Value.weight /= protiens.Count;
        }
    }

    public override void DEBUG_PrintInfo()
    {
        foreach (var p in protiens)
        {
            Debug.Log($"{p.Value.amount} of {p.Key} with a weight of {p.Value.weight} and a value of {p.Value.value}");
        }
    }
}