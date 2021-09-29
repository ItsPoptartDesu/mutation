using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electric : iNucleotide
{
    public Electric()
    {
        myNucleotide = NUCLEOTIDE.ELECTRIC;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
