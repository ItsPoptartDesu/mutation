using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : iNucleotide
{
    public Fire()
    {
        myNucleotide = NUCLEOTIDE.FIRE;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
