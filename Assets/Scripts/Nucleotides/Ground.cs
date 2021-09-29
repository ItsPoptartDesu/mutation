using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : iNucleotide
{
    public Ground()
    {
        myNucleotide = NUCLEOTIDE.GROUND;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
