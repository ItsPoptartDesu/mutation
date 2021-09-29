using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : iNucleotide
{
    public Bug()
    {
        myNucleotide = NUCLEOTIDE.BUG;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
