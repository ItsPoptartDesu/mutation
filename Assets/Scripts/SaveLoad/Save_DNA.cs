using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Save_DNA
{
    public char NucleotideTag;
    public float IntrinsicValue;

    public Save_DNA(char _nt, float _iv)
    {
        NucleotideTag =_nt;
        IntrinsicValue = _iv;
    }
}