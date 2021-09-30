using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : iNucleotide
{
    public Ghost()
    {
        Nucleotide = NUCLEOTIDE.GHOST;
        IntrinsicValue = Random.Range(0.0f,1.0f);
    }
}
