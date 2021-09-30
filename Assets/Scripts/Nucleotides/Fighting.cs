using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighting : iNucleotide
{
    public Fighting()
    {
        Nucleotide = NUCLEOTIDE.FIGHTING;
        IntrinsicValue = Random.Range(0.0f,1.0f);
    }
}
