using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : iNucleotide
{
    public Water()
    {
        myNucleotide = NUCLEOTIDE.WATER;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
