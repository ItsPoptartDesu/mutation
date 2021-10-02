using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Nucleotide : MonoBehaviour
{
    public iNucleotide.NUCLEOTIDE type;
    private Button button;
    private UI_MonsterBuilder monsterBuilder;

    // Start is called before the first frame update
    void Awake()
    {
        button = GetComponent<Button>();
        //TODO fix this lazy shit teehee
        monsterBuilder = GameObject.FindObjectOfType<UI_MonsterBuilder>();
    }

    void Start()
    {
        button.onClick.AddListener(OnClickButtonEvent);
    }

    private void OnClickButtonEvent()
    {
        monsterBuilder.NucleotideType = type;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
