﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChenger : MonoBehaviour {

public string sceneName;

	// Use this for initialization
	void Start () {

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("Return key was pressed.");
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log("Return key was released");
            SceneManager.LoadScene(sceneName);

        }
	}
}
