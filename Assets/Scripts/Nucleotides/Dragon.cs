using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : iNucleotide
{
    public Dragon()
    {
        Nucleotide = NUCLEOTIDE.DRAGON;
        IntrinsicValue = Random.Range(0.0f,1.0f);
        State = MutationState.STATE.BASE;
    }
}
