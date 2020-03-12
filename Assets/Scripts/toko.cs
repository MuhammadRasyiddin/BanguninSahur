using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public static class toko {


    public static float suara { get; set; }
    public static float kaget { get; set; }
    public static float luck { get; set; }
    public static int hargaSuara { get; set; }
    public static int hargaKaget { get; set; }
    public static int hargaLuck { get; set; }
    
    public static void Suara()
    {
        if (singleton.gold > hargaSuara)
        {
            suara += 10;
            hargaSuara += 1;
            singleton.gold -= hargaSuara;
        }
        if (singleton.gold <= 0)
        {
            singleton.gold = 0;
        }
    }

    public static void Kaget()
    {
        if (singleton.gold > hargaLuck)
        {
            kaget += 0.15f;
            hargaKaget += 2;
            singleton.gold -= hargaKaget;
        }
        if (singleton.gold <= 0)
        {
            singleton.gold = 0;
        }
        
    }

    public static void Luck()
    {
        if (singleton.gold > hargaLuck)
        {
            luck += 0.15f;
            hargaLuck += 5;
            singleton.gold -= hargaLuck;
        }
        if (singleton.gold <= 0)
        {
            singleton.gold = 0;
        }
    }

}
