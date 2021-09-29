using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Psychic : iNucleotide
{
    public Psychic()
    {
        myNucleotide = NUCLEOTIDE.PSYCHIC;
       intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
