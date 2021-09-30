using System.Collections;
using System.Collections.Generic;

public abstract class iCell {
    public List<iProtein> baseProtiens = new List<iProtein>();
    public Dictionary<iNucleotide.NUCLEOTIDE, iDNAData> cells = new Dictionary<iNucleotide.NUCLEOTIDE, iDNAData>();
    public abstract void CompressProteins();
    public abstract void DEBUG_PrintInfo();
}