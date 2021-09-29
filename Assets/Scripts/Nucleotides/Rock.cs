using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : iNucleotide
{
    public Rock()
    {
        myNucleotide = NUCLEOTIDE.ROCK;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
