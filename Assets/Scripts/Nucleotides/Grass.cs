using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : iNucleotide
{
    public Grass()
    {
        Nucleotide = NUCLEOTIDE.GRASS;
        IntrinsicValue = Random.Range(0.0f,1.0f);
    }
}
