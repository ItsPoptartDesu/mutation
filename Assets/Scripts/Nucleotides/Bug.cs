using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : iNucleotide
{
    public Bug()
    {
        Nucleotide = NUCLEOTIDE.BUG;
        IntrinsicValue = Random.Range(0.0f,1.0f);
        State = MutationState.STATE.BASE;
    }
}
