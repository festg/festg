﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMusicNight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Return))
        {

           Destroy(GameObject.Find("TitleMusic"));

        }

	}
}
