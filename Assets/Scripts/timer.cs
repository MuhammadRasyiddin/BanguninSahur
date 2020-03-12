using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    Image timebar;
    public float maxTime = 5f;
    float timeLeft;
    public GameObject timesUpText;

	// Use this for initialization
	void Start () {
        timesUpText.SetActive(false);
        timebar = GetComponent<Image>();
        timeLeft = maxTime;
	}

    // Update is called once per frame
    void Update () {
        if(timeLeft > 0){
            timeLeft -= Time.deltaTime;
            timebar.fillAmount = timeLeft / maxTime;
        }else{
            if (singleton.day != 3) {
                singleton.day += 1;
                Application.LoadLevel("MainMenu");
                timesUpText.SetActive(false);
            }else {
                Application.LoadLevel("Start");
            }
            
        }
		
	}
}
