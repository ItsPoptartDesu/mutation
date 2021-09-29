using System.Collections;
using System.Collections.Generic;

public class CellValues
{
    public float weight;
    public float value;
    public CellValues(float _w, float _v)
    {
        weight = _w;
        value = _v;
    }

}
public abstract class iCell {
    public List<iProtein> baseProtiens = new List<iProtein>();
    public Dictionary<iNucleotide.NUCLEOTIDE, CellValues> cells = new Dictionary<iNucleotide.NUCLEOTIDE, CellValues>();
    public abstract void CompressProteins();
    public abstract void DEBUG_PrintInfo();
}