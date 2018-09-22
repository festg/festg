using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    [SerializeField]
    Text choicesText;


    public void SetChoicesText(string text)
    {
        choicesText.text = text;
    }

    // Use this for initialization
    void Start () {
        SetChoicesText("B");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
