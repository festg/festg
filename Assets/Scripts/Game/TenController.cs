using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TenController : MonoBehaviour {

    private Bar tenBar;

    //加点数
    private float addScore;

    public void SetTenBar(Bar timeBar,float addScore)
    {
        this.addScore = addScore;
        tenBar = timeBar;
        tenBar.SetMaxVal(100);
        tenBar.SetVal(0);

    }


    public void AddScore()
    {
        tenBar.SetVal(tenBar.GetVal()+addScore);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
