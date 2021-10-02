using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : iNucleotide
{
    public Ground()
    {
        Nucleotide = NUCLEOTIDE.GROUND;
        IntrinsicValue = Random.Range(0.0f,1.0f);
        State = MutationState.STATE.BASE;
    }
}
