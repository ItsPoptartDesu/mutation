using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Divine : iNucleotide
{
    public Divine()
    {
        Nucleotide = NUCLEOTIDE.DIVINE;
        IntrinsicValue = Random.Range(0.0f,1.0f);
        State = MutationState.STATE.BASE;
    }
}
