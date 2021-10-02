using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electric : iNucleotide
{
    public Electric()
    {
        Nucleotide = NUCLEOTIDE.ELECTRIC;
        IntrinsicValue = Random.Range(0.0f,1.0f);
        State = MutationState.STATE.BASE;
    }
}
