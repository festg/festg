using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private QuestionManager questionManager;

    [SerializeField]
    private TenController tenController;

    [SerializeField]
    private TimeController timeController;

    [SerializeField]
    private Views views;

	// Use this for initialization
	void Start () {
        timeController.SetTimeBar(views.TimeBar,1000);
        timeController.OnTimeOver+=() => {
            SceneManager.LoadScene("score1");
        };
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
