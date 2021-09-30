using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
[Serializable]
public class JSONSave
{

    [Serializable]
    public struct JSONSaveData
    {
        public string Name;
        public List<JSONNucleotide> dnaSequence;
    }

    [Serializable]
    public struct JSONNucleotide
    {
        public iNucleotide.NUCLEOTIDE NucleotideTag;
        public float IntrinsicValue;
    }

    public JSONSaveData data;
    public JSONSave(DNA _dna)
    {
        data = new JSONSaveData();
        data.Name = _dna.Name;
        data.dnaSequence = new List<JSONNucleotide>();
        for (int i = 0; i < _dna.GetNucleotideCount(); ++i)
        {
            JSONNucleotide jn = new JSONNucleotide();
            var n = _dna.GetNucleotideAtIndex(i);
            jn.IntrinsicValue = n.IntrinsicValue;
            jn.NucleotideTag = n.Nucleotide;
            data.dnaSequence.Add(jn);
        }
        //data.dnaSequence = _dna.GetDNASequence().ToArray();
    }
}