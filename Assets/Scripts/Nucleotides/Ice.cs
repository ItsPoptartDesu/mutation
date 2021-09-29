using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : iNucleotide
{
    public Ice()
    {
        myNucleotide = NUCLEOTIDE.ICE;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
