using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MutationState
{
    public enum STATE
    {
        BASE, AMINO, PROTEIN, CELL, AFFINITY
    }
    public STATE State { get; set; }
}
