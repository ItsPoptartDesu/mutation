using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class iNucleotide : MutationState
{
    [Serializable]
    public enum NUCLEOTIDE
    {
        BUG, DIVINE, DRAGON, ELECTRIC,
        FIGHTING, FIRE, FLYING, GHOST,
        GRASS, GROUND, ICE, NORMAL,
        POISON, PSYCHIC, ROCK, WATER
    }

    public NUCLEOTIDE Nucleotide { get; set; }
    public float IntrinsicValue { get; set; }
    public void DEBUG_PrintInfo()
    {
        Debug.Log($"NUCLEOTIDE INFO | State {State} | NucleoTide type of {Nucleotide} | Intrinsic Value of {IntrinsicValue}");
    }
}
