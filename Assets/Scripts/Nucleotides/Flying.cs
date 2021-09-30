using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : iNucleotide
{
    public Flying()
    {
        Nucleotide = NUCLEOTIDE.FLYING;
        IntrinsicValue = Random.Range(0.0f,1.0f);
    }
}
