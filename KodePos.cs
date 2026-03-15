using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

public class KodePos
{
    private Dictionary<string, int> _daftarKode = new Dictionary<string, int>();
    public Dictionary<string, int> DaftarKode
    {
        get => _daftarKode;
        set => _daftarKode = value;
    }

    public KodePos() 
    {
        DaftarKode.Add("Batununggal", 40266);
        DaftarKode.Add("Kujangsari", 40287);
        DaftarKode.Add("Mengger", 40267);
        DaftarKode.Add("Wates", 40256);
        DaftarKode.Add("Cijaura", 40287);
        DaftarKode.Add("Jatisari", 40286);
        DaftarKode.Add("Margasari", 40286);
        DaftarKode.Add("Sekejati", 40286);
        DaftarKode.Add("Kebonwaru", 40272);
        DaftarKode.Add("Maleer", 40274);
    }

    public void GetKodePos()
    {
        Console.WriteLine("Kelurahan \t Kode Pos");
        foreach (var p in DaftarKode) 
        {
            Console.WriteLine($"{p.Key} \t {p.Value}");
        }
    }
}
