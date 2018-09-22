using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TenController : MonoBehaviour {

    private Bar tenBar;

    public void SetTenBar(Bar timeBar)
    {

        this.tenBar = timeBar;
        this.tenBar.SetMaxVal(100);
        this.tenBar.SetVal(0);

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
