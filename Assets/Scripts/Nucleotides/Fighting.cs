using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighting : iNucleotide
{
    public Fighting()
    {
        myNucleotide = NUCLEOTIDE.FIGHTING;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
