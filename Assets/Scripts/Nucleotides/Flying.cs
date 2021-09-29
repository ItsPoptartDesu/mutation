using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : iNucleotide
{
    public Flying()
    {
        myNucleotide = NUCLEOTIDE.FLYING;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
