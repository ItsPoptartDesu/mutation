using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }

    }
    private string MonsterFolderPath = "monsters/";
    private string Extension = ".json";

    public void SaveMonster(DNA _dna)
    {
        JSONSave js = new JSONSave(_dna);
        string path = Application.dataPath + "/Resources/" + MonsterFolderPath + _dna.Name + Extension;

        using (StreamWriter stream = new StreamWriter(path))
        {
            string json = JsonUtility.ToJson(js);
            stream.Write(json);
            //PlayerPrefs.SetString("MonsterData", json);
        }

        Debug.Log($"Saved {js.data} at {path}");
    }

    public DNA LoadMonster(string _name)
    {
        var data = LoadResourceTextfile(_name);//PlayerPrefs.GetString("MonsterData");
        Debug.Log(data);
        JSONSave js = JsonUtility.FromJson<JSONSave>(data);
        DNA d = new DNA();
        d.Name = js.data.Name;
        foreach (var n in js.data.dnaSequence)
        {
            var element = ConvertTagToNucleotide(n.NucleotideTag);
            element.Nucleotide = n.NucleotideTag;
            element.IntrinsicValue = n.IntrinsicValue;
            element.State = n.MutationState;
            d.AddNucleotide(element);
        }
        return d;
    }

    private string LoadResourceTextfile(string _name)
    {
        string path = MonsterFolderPath + _name;
        TextAsset targetFile = Resources.Load<TextAsset>(path);
        return targetFile.text;
    }

    public iNucleotide ConvertTagToNucleotide(iNucleotide.NUCLEOTIDE _num)
    {
        iNucleotide nt;
        switch (_num)
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
                nt = new Normal();// this should never be hit
                break;
        }
        return nt;
    }
    public string GenerateName(int len)
    {
        System.Random r = new System.Random();
        string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
        string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
        string Name = "";
        Name += consonants[r.Next(consonants.Length)].ToUpper();
        Name += vowels[r.Next(vowels.Length)];
        int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
        while (b < len)
        {
            Name += consonants[r.Next(consonants.Length)];
            b++;
            Name += vowels[r.Next(vowels.Length)];
            b++;
        }
        return Name;
    }
}