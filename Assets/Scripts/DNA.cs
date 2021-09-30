using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class DNA : iDNA
{
    public DNA()
    {
        dna = new List<iNucleotide>();
        aminoAcids = new List<iAminoAcid>();
        proteins = new List<iProtein>();
        cells = new List<iCell>();
        affinity = new Dictionary<iNucleotide.NUCLEOTIDE, iDNAData>();
    }

    public void CreateLife()
    {
        MakeAminoAcids();
        if (aminoAcids.Count() > 3)
            MakeProteins();
        if (proteins.Count() > 3)
            MakeCells();
    }

    public override void AddNucleotide(iNucleotide _nucleotide)
    {
        dna.Add(_nucleotide);
    }
    public int GetNucleotideCount() { return dna.Count; }
    public int GetAminoAcidCount() { return aminoAcids.Count; }
    public int GetProteinCount() { return proteins.Count; }
    public int GetCellCount() { return cells.Count; }
    public void DEBUG_PrintProteinInfo()
    {
        for (int i = 0; i < proteins.Count; ++i)
        {
            Debug.Log($"Protein {i}");
            proteins[i].DEBUG_PrintInfo();
        }
    }
    public void DEBUG_PrintNucleotideInfo()
    {
        for(int i = 0; i < dna.Count(); ++i)
        {
            dna[i].DEBUG_PrintInfo();
        }
    }
    public void DEBUG_PrintAminoAcidInfo()
    {
        for (int i = 0; i < aminoAcids.Count; ++i)
        {
            Debug.Log($"AminoAcid {i}");
            aminoAcids[i].DEBUG_PrintInfo();
        }
    }
    public void DEBUG_PrintCellInfo()
    {
        for (int i = 0; i < cells.Count; ++i)
        {
            Debug.Log($"Cell {i}");
            cells[i].DEBUG_PrintInfo();
        }
    }
    public void DEBUG_PrintAffinityInfo()
    {
        foreach (var a in affinity)
        {
            Debug.Log($"{a.Value.amount} of {a.Key} with a value of {a.Value.value}");
        }
    }
    protected override void MakeAminoAcids()
    {
        for (int i = 0; i < dna.Count; i += dnaSplitCount)
        {
            iNucleotide[] nucleotides = dna.Skip(i).Take(dnaSplitCount).ToArray();
            AminoAcid aa = new AminoAcid(nucleotides);
            aminoAcids.Add(aa);
        }
    }
    protected override void MakeProteins()
    {
        for (int i = 0; i < aminoAcids.Count; i += dnaSplitCount)
        {
            iAminoAcid[] aa = aminoAcids.Skip(i).Take(dnaSplitCount).ToArray();
            Protein p = new Protein(aa);
            proteins.Add(p);
        }
    }
    protected override void MakeCells()
    {
        for (int i = 0; i < proteins.Count; i += dnaSplitCount)
        {
            iProtein[] p = proteins.Skip(i).Take(dnaSplitCount).ToArray();
            Cell c = new Cell(p);
            cells.Add(c);
        }
        CompressCells();
    }
    protected override void CompressCells()
    {
        foreach (var c in cells)
        {
            foreach (var i in c.cells)
            {
                if (!affinity.ContainsKey(i.Key))
                    affinity.Add(i.Key, new iDNAData(i.Value.value));
                else
                {
                    affinity[i.Key].value += i.Value.value;
                    affinity[i.Key].amount++;
                }
            }
        }
    }
}
