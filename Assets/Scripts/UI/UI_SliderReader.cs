using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_SliderReader : MonoBehaviour
{
    public TextMeshProUGUI amountText;
    public string FlavorText;
    private float selectedAmount;
    public float SelectedAmount
    {
        get { return selectedAmount; }
        set
        {
            selectedAmount = value;
            amountText.text = $"{FlavorText} : {selectedAmount}";
        }
    }

    public void OnSliderChanged(float _v)
    {
        SelectedAmount = _v;

    }
    // Start is called before the first frame update
    void Start()
    {
        SelectedAmount = 0;
    }
}
