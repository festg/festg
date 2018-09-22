using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TimeController : MonoBehaviour {

    private Bar timeBar;
    public event Action OnTimeOver;

    public void SetTimeBar(Bar timeBar,int startTime)
    {
        this.timeBar = timeBar;
        this.timeBar.SetMaxVal(startTime);
        this.timeBar.SetVal(startTime);
    }


	
	// Update is called once per frame
	void Update () {
        timeBar.SetVal(timeBar.GetVal()- Time.deltaTime);
        if (timeBar.GetVal() < 0)
            OnTimeOver();
	}
}
