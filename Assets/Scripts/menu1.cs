using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        singleton.day = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Clicked()
    {
        Application.LoadLevel("MainMenu");
    }
}
