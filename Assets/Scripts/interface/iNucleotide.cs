using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class iNucleotide
{
    public enum NUCLEOTIDE
    {
        NORMAL, FIRE, WATER, GRASS,
        ELECTRIC, ICE, FIGHTING, POISON,
        GROUND, FLYING, PSYCHIC, BUG,
        ROCK, GHOST, DRAGON, DIVINE
    }
    protected NUCLEOTIDE myNucleotide;
    public NUCLEOTIDE GetNucleoTideType() { return myNucleotide; }
    protected float intrinsicValue;
    public float GetIntrinsicValue() { return intrinsicValue;}

    public void DEBUG_PrintInfo()
    {
        Debug.Log($"NUCLEOTIDE INFO | NucleoTide type of {myNucleotide} | Intrinsic Value of {intrinsicValue}");
    }
}
