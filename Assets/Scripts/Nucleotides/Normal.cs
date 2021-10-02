using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal : iNucleotide
{
    public Normal()
    {
        Nucleotide = NUCLEOTIDE.NORMAL;
        IntrinsicValue = Random.Range(0.0f,1.0f);
        State = MutationState.STATE.BASE;
    }
}
