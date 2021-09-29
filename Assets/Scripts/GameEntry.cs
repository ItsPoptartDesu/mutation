using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEntry : MonoBehaviour
{
    public int NucleotideCount = 0;
    public DNA dna;
    // Start is called before the first frame update
    void Start()
    {
        dna = new DNA();
        for (int i = 0; i < NucleotideCount; ++i)
        {
            iNucleotide n = GetRandomNucleotide();
            dna.AddNucleotide(n);
        }
        
        dna.CreateLife();
        dna.DEBUG_PrintAffinityInfo();
        Debug.Log($"Nucleotide Count {dna.GetNucleotideCount()} | Amino Acid Count {dna.GetAminoAcidCount()} | Protein Count {dna.GetProteinCount()} | Cell Count {dna.GetCellCount()}");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private iNucleotide GetRandomNucleotide()
    {
        iNucleotide nt;
        iNucleotide.NUCLEOTIDE typeID = (iNucleotide.NUCLEOTIDE)Random.Range(0, 16);
        switch (typeID)
        {
            case iNucleotide.NUCLEOTIDE.NORMAL:
                nt = new Normal();
                break;
            case iNucleotide.NUCLEOTIDE.FIRE:
                nt = new Fire();
                break;
            case iNucleotide.NUCLEOTIDE.WATER:
                nt = new Water();
                break;
            case iNucleotide.NUCLEOTIDE.GRASS:
                nt = new Grass();
                break;
            case iNucleotide.NUCLEOTIDE.ELECTRIC:
                nt = new Electric();
                break;
            case iNucleotide.NUCLEOTIDE.ICE:
                nt = new Ice();
                break;
            case iNucleotide.NUCLEOTIDE.FIGHTING:
            nt = new Fighting();
                break;
            case iNucleotide.NUCLEOTIDE.POISON:
            nt = new Poison();
                break;
            case iNucleotide.NUCLEOTIDE.GROUND:
            nt = new Ground();
                break;
            case iNucleotide.NUCLEOTIDE.FLYING:
            nt = new Flying();
                break;
            case iNucleotide.NUCLEOTIDE.PSYCHIC:
            nt = new Psychic();
                break;
            case iNucleotide.NUCLEOTIDE.BUG:
            nt = new Bug();
                break;
            case iNucleotide.NUCLEOTIDE.ROCK:
            nt = new Rock();
                break;
            case iNucleotide.NUCLEOTIDE.GHOST:
            nt = new Ghost();
                break;
            case iNucleotide.NUCLEOTIDE.DRAGON:
            nt = new Dragon();
                break;
            case iNucleotide.NUCLEOTIDE.DIVINE://should not be used double gold star feature down the line
            nt = new Divine();
                break;
            default:
            nt = new Normal();
                break;
        }
        return nt;
    }
}
