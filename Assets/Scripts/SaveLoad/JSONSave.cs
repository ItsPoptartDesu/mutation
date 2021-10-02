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
        public MutationState.STATE MutationState;
        public bool isCompressed;
    }

    public JSONSaveData data;
    public JSONSave(DNA _dna)
    {
        data = new JSONSaveData();
        data.Name = _dna.Name;
        data.dnaSequence = new List<JSONNucleotide>();
        foreach (var t in _dna.dna)
        {
            foreach (var n in t.Value)
            {
                JSONNucleotide jn = new JSONNucleotide();
                jn.IntrinsicValue = n.IntrinsicValue;
                jn.NucleotideTag = n.Nucleotide;
                jn.MutationState = n.State;
                data.dnaSequence.Add(jn);
            }
        }
        //data.dnaSequence = _dna.GetDNASequence().ToArray();
    }
}