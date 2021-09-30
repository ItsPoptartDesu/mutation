using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : iNucleotide
{
    public Ice()
    {
        Nucleotide = NUCLEOTIDE.ICE;
        IntrinsicValue = Random.Range(0.0f,1.0f);
    }
}
