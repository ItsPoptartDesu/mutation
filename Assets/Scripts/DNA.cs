using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class DNA : iDNA
{
    public string Name;
    public DNA()
    {
        dna = new Dictionary<iNucleotide.NUCLEOTIDE, List<iNucleotide>>();
        affinity = new Dictionary<iNucleotide.NUCLEOTIDE, iDNAData>();
        State = MutationState.STATE.BASE;
    }

    // public int GetNucleotideCount() { return (from n in dna where n.State == MutationState.STATE.BASE select n).Count(); }
    // public int GetAminoAcidCount() { return (from n in dna where n.State == MutationState.STATE.AMINO select n).Count(); }
    // public int GetProteinCount() { return (from n in dna where n.State == MutationState.STATE.PROTEIN select n).Count(); }
    // public int GetCellCount() { return (from n in dna where n.State == MutationState.STATE.CELL select n).Count(); }

    //intended use for Monster Loading and gameplay
    public void CreateLife()
    {
        iNucleotideMutation(MutationState.STATE.BASE);
        iNucleotideMutation(MutationState.STATE.AMINO);
        iNucleotideMutation(MutationState.STATE.PROTEIN);
        iNucleotideMutation(MutationState.STATE.CELL);
        DEBUG_PrintInfo();
    }
    //intended for new monster creation, IE Monster Builder, Random Gen
    public void CreateLifeRaw()
    {
        // MakeAminoAcids();
        // MakeProteins();
        // MakeCells();
        iNucleotideMutation(MutationState.STATE.BASE);
        Name = SaveSystem.Instance.GenerateName(Random.Range(5, 12));
    }

    /// all we do is if the nucleotide has already been compressed we will increase its state for its ready for promotion congrats you did it little buddy
    private void iNucleotideMutation(MutationState.STATE _s)
    {
        //foreach nucleotide in dictionary dna
        foreach (var n in dna)
        {
            //grab the ratio before any changes could be made
            bool isLeveling = true;
            do
            {

                List<iNucleotide> t = n.Value.Where(x => x.State == _s).Take(dnaSplitCount).ToList();
                float ratio = n.Value.Count() / dna.Count;
                if (t.Count >= dnaSplitCount)
                {
                    iNucleotide compressed = null;
                    for (int i = 0; i < dnaSplitCount; ++i)
                    {
                        //remove the old ones they are being promoted
                        n.Value.Remove(t[i]);
                        compressed = SaveSystem.Instance.ConvertTagToNucleotide(t[i].Nucleotide);
                        compressed.State = t[i].State + 1;
                        compressed.IntrinsicValue += (ratio * t[i].IntrinsicValue);
                    }
                    n.Value.Add(compressed);
                }
                else
                    isLeveling = false;
            } while (isLeveling);
        }
    }

    public override void AddNucleotide(iNucleotide _nucleotide)
    {
        if (!dna.ContainsKey(_nucleotide.Nucleotide))
            dna[_nucleotide.Nucleotide] = new List<iNucleotide>();
        dna[_nucleotide.Nucleotide].Add(_nucleotide);
    }

    #region debug calls
    public void DEBUG_PrintInfo()
    {
        foreach (var a in dna)
        {
            foreach (var b in a.Value)
            {
                Debug.Log($"{a.Key} with a count of {a.Value.Count}");
                b.DEBUG_PrintInfo();
            }
        }
    }
    public void DEBUG_PrintAffinityInfo()
    {
        foreach (var a in affinity)
        {
            Debug.Log($"{a.Value.amount} of {a.Key} with a value of {a.Value.value}");
        }
    }


    #endregion

}
