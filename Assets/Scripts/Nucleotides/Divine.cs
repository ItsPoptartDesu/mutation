using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Divine : iNucleotide
{
    public Divine()
    {
        myNucleotide = NUCLEOTIDE.DIVINE;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
