using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : iNucleotide
{
    public Dragon()
    {
        myNucleotide = NUCLEOTIDE.DRAGON;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
