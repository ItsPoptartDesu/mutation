using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Cell : iCell
{
    public Cell(iProtein[] _p)
    {
        for (int i = 0; i < _p.Length; ++i)
        {
            baseProtiens.Add(_p[i]);
        }
        CompressProteins();
    }

    public override void CompressProteins()
    {
        foreach (var p in baseProtiens)
        {
            foreach (var n in p.protiens)
            {
                if (!cells.ContainsKey(n.Key))
                    cells.Add(n.Key, new iDNAData(n.Value.value));
                else
                {
                    cells[n.Key].weight++;
                    cells[n.Key].value += (n.Value.weight * n.Value.value);
                    cells[n.Key].amount++;
                }
            }
        }
        
        foreach (var c in cells)
            c.Value.weight /= cells.Count;
    }

    public override void DEBUG_PrintInfo()
    {
        foreach (var c in cells)
        {
            Debug.Log($"{c.Value.amount} of {c.Key} with a weight of {c.Value.weight} and a value of {c.Value.value}");
        }
    }
}