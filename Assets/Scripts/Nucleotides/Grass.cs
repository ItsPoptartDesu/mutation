using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : iNucleotide
{
    public Grass()
    {
        myNucleotide = NUCLEOTIDE.GRASS;
        intrinsicValue = Random.Range(0.0f,1.0f);
    }
}
