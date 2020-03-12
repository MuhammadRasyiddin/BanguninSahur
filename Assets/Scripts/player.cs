using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    //UI initialization
    public UnityEngine.UI.Text goldDisplay;

    //Variable initialization
    public float dmg { get; set; }
    public float crit { get; set; }
    public float normalDmg { get; set; }
    public float critDmg { get; set; }
    public float critChance { get; set; }
    public float goldChance { get; set; }
    //===================================================//

    

    // Use this for initialization
    void Start () {
        // Dammage 
        dmg = 10 + toko.suara;
        //Critical
        crit = dmg * 0.5f;
        
	}

	// Update is called once per frame
	void Update () {
        goldDisplay.text = "Gold : " + singleton.gold;
    }
    
    //Pengaturan untuk attack
    public void Attack(){
        float total = dmg;

        if (this.RandomChance())
        {
            total = dmg + crit;
        }
        else
        {
            total = dmg;
        }

        GameObject.Find("Click").GetComponent<enemy>().hpTotal(total);
    }

    //Pengaturan untuk Critical
    public void Critical(){
        critDmg = dmg + crit;
    }
    
    //Pengaturan untuk chance critical
    public bool RandomChance()
    {
        float chance = Random.Range(0.00f, 2.00f);
        return (chance >= 0.15f && chance <=toko.kaget);
    }

}
