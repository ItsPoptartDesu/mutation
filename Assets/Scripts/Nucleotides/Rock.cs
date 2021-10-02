using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : iNucleotide
{
    public Rock()
    {
        Nucleotide = NUCLEOTIDE.ROCK;
        IntrinsicValue = Random.Range(0.0f,1.0f);
        State = MutationState.STATE.BASE;
    }
}
