using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu2 : MonoBehaviour {
    
    //UI initialization
    public UnityEngine.UI.Text day;
    public UnityEngine.UI.Text gold;
    public UnityEngine.UI.Text score;
    public UnityEngine.UI.Text hargaSuara;
    public UnityEngine.UI.Text hargaKaget;
    public UnityEngine.UI.Text hargaLuck;
    public UnityEngine.UI.Text damage;
    public UnityEngine.UI.Text critical;
    public UnityEngine.UI.Text golDrop;



    // Use this for initialization
    void Start () {
        allOutput();
    }
	
	// Update is called once per frame
	void Update () {
        day.text = "Day: " + singleton.day.ToString();
        gold.text = "Gold: " + singleton.gold.ToString();
        score.text = "Score: " + singleton.score.ToString();
        damage.text = toko.suara.ToString();
        hargaSuara.text = toko.hargaSuara.ToString() + "G";
        critical.text = toko.kaget.ToString();
        hargaKaget.text = toko.hargaKaget.ToString() + "G";
        golDrop.text = toko.luck.ToString();
        hargaLuck.text = toko.hargaLuck.ToString() + "G";
    }

    public void allOutput()
    {
        day.text = "Day: " + singleton.day.ToString();
        gold.text = "Gold: " + singleton.gold.ToString();
        score.text = "Score: " + singleton.score.ToString();
        outputSuara();
        outputKaget();
        outputLuck();
    }

    public void outputSuara()
    {
        toko.suara = 10;
        toko.hargaSuara = 1;
        damage.text = toko.suara.ToString();
        hargaSuara.text = toko.hargaSuara.ToString() + "G";
    }

    public void outputKaget()
    {
        toko.kaget = 0.15f;
        toko.hargaKaget = 2;
        critical.text = toko.kaget.ToString();
        hargaKaget.text = toko.hargaKaget.ToString() + "G";
    }

    public void outputLuck()
    {
        toko.luck = 0.15f;
        toko.hargaLuck = 5;
        golDrop.text = toko.luck.ToString();
        hargaLuck.text = toko.hargaLuck.ToString() + "G";
    }

    public void Suara()
    {
        toko.Suara();
    }

    public void kaget()
    {
        toko.Kaget();
    }

    public void luck()
    {
        toko.Luck();
    }

    public void Clicked()
    {
        Application.LoadLevel("GamePlay");
    }
}
