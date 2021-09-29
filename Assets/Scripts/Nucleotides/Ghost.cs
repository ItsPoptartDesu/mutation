using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : iNucleotide
{
    public Ghost()
    {
        myNucleotide = NUCLEOTIDE.GHOST;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
