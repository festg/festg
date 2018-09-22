using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Views: MonoBehaviour {

    [SerializeField]
    private Bar timeBar;

    [SerializeField]
    private Bar tenBar;

    public Bar TenBar
    {
        get
        {
            return tenBar;
        }
    }

    public Bar TimeBar
    {
        get
        {
            return timeBar;
        }
    }
}
