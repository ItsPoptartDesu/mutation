using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : iNucleotide
{
    public Fire()
    {
        Nucleotide = NUCLEOTIDE.FIRE;
        IntrinsicValue = Random.Range(0.0f,1.0f);
    }
}
