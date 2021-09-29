using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : iNucleotide
{
    public Poison()
    {
        myNucleotide = NUCLEOTIDE.POISON;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
