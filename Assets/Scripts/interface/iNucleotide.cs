using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class iNucleotide
{
    [Serializable]
    public enum NUCLEOTIDE
    {
        NORMAL, FIRE, WATER, GRASS,
        ELECTRIC, ICE, FIGHTING, POISON,
        GROUND, FLYING, PSYCHIC, BUG,
        ROCK, GHOST, DRAGON, DIVINE
    }
    public NUCLEOTIDE Nucleotide{get; set;} 
    public float IntrinsicValue {get; set;}

    public void DEBUG_PrintInfo()
    {
        Debug.Log($"NUCLEOTIDE INFO | NucleoTide type of {Nucleotide} | Intrinsic Value of {IntrinsicValue}");
    }
}
