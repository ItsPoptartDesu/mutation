using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : iNucleotide
{
    public Poison()
    {
        Nucleotide = NUCLEOTIDE.POISON;
        IntrinsicValue = Random.Range(0.0f,1.0f);
    }
}
