using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal : iNucleotide
{
    public Normal()
    {
        myNucleotide = NUCLEOTIDE.NORMAL;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}