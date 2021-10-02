using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_MonsterBuilder : MonoBehaviour
{
    public UI_SliderReader AmountSlider;
    public UI_SliderReader IntrinsicSlider;
    public TextMeshProUGUI TypeText;

    public Button AddSequenceButton;
    public Button SaveSequenceButton;
    public DNA dna;

    void Start()
    {
        dna = new DNA();
        AddSequenceButton.onClick.AddListener(OnClickAddSequenceButton);
        SaveSequenceButton.onClick.AddListener(OnClickSaveSequenceButton);
    }

    private iNucleotide.NUCLEOTIDE nType;
    public iNucleotide.NUCLEOTIDE NucleotideType
    {
        get
        {
            return nType;
        }
        set
        {
            nType = value;
            UpdateText(nType);
        }
    }
    private void UpdateText(iNucleotide.NUCLEOTIDE _n)
    {
        switch (_n)
        {
            case iNucleotide.NUCLEOTIDE.NORMAL:
                TypeText.text = "NORMAL";
                break;
            case iNucleotide.NUCLEOTIDE.FIRE:
                TypeText.text = "FIRE";
                break;
            case iNucleotide.NUCLEOTIDE.WATER:
                TypeText.text = "WATER";
                break;
            case iNucleotide.NUCLEOTIDE.GRASS:
                TypeText.text = "GRASS";
                break;
            case iNucleotide.NUCLEOTIDE.ELECTRIC:
                TypeText.text = "ELECTRIC";
                break;
            case iNucleotide.NUCLEOTIDE.ICE:
                TypeText.text = "ICE";
                break;
            case iNucleotide.NUCLEOTIDE.FIGHTING:
                TypeText.text = "FIGHTING";
                break;
            case iNucleotide.NUCLEOTIDE.POISON:
                TypeText.text = "POISON";
                break;
            case iNucleotide.NUCLEOTIDE.GROUND:
                TypeText.text = "GROUND";
                break;
            case iNucleotide.NUCLEOTIDE.FLYING:
                TypeText.text = "FLYING";
                break;
            case iNucleotide.NUCLEOTIDE.PSYCHIC:
                TypeText.text = "PSYCHIC";
                break;
            case iNucleotide.NUCLEOTIDE.BUG:
                TypeText.text = "BUG";
                break;
            case iNucleotide.NUCLEOTIDE.ROCK:
                TypeText.text = "ROCK";
                break;
            case iNucleotide.NUCLEOTIDE.GHOST:
                TypeText.text = "GHOST";
                break;
            case iNucleotide.NUCLEOTIDE.DRAGON:
                TypeText.text = "DRAGON";
                break;
            case iNucleotide.NUCLEOTIDE.DIVINE://should not be used double gold star feature down the line
                TypeText.text = "DIVINE";
                break;
        }
    }

    private void OnClickAddSequenceButton()
    {
        for (int i = 0; i < AmountSlider.SelectedAmount; ++i)
        {
            iNucleotide n = SaveSystem.Instance.ConvertTagToNucleotide(nType);
            n.IntrinsicValue = IntrinsicSlider.SelectedAmount;
            if (!dna.dna.ContainsKey(n.Nucleotide))
                dna.dna[n.Nucleotide] = new List<iNucleotide>();
            dna.dna[n.Nucleotide].Add(n);
        }
        
    }

    private void OnClickSaveSequenceButton()
    {
        dna.CreateLifeRaw();
        dna.DEBUG_PrintInfo();
        SaveSystem.Instance.SaveMonster(dna);
    }

}