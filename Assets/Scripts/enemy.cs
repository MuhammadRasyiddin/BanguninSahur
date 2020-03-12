using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

    //UI initialization
    public UnityEngine.UI.Text hpDisplay;
    public UnityEngine.UI.Text goldDisplay;

    //Variable initialization
    public float hp { get; set; }
    public float maxHp { get; set; }
    //===================================================//

    // Use this for initialization
    void Start () {
        maxHp = 100;
        hp = maxHp;
    }
	
	// Update is called once per frame
	void Update (){
        hpDisplay.text = "HP: " + hp;
        goldDisplay.text = "Gold : " + singleton.gold;
    }

    //Pengaturan untuk pengurangan darah.
    public void hpTotal(float inDmg){
        hp = hp - inDmg;
        singleton.gold += 1;
        singleton.score += 1;

        if (hp <= 0)
        {
            maxHp = maxHp + 50;
            hp = maxHp;
            goldDrop();
        }
    }

    public void goldDrop(){
        if (this.goldChance())
        {
            singleton.gold += 30;
            singleton.score += 30;
        }
        else
        {
            singleton.gold += 10;
            singleton.score += 10;
        }
    } 

    public bool goldChance()
    {
        float golChance = Random.Range(0.00f, 2.00f);
        return (golChance >= 0.15f && golChance<= toko.luck);
    }
}