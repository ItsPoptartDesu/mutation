using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Psychic : iNucleotide
{
    public Psychic()
    {
        Nucleotide = NUCLEOTIDE.PSYCHIC;
       IntrinsicValue = Random.Range(0.0f,1.0f);
        State = MutationState.STATE.BASE;
    }
}
