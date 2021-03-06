﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private QuestionManager questionManager;

    [SerializeField]
    private TenController tenController;

    [SerializeField]
    private TimeController timeController;

    [SerializeField]
    private EnemyBuilder enemyBuilder;

    [SerializeField]
    private Views views;

    [SerializeField]
    private RankManagement rankManagement;


    void NextQuestion()
    {
        var question = questionManager.Next();
        if (question == null)
            EndGame();
        else
        {
            var trueChoiceName=views.QuestionPresenter.SetQuestion(question);
            enemyBuilder.CreateEnemies(trueChoiceName);
        }
    }

    // Use this for initialization
    void Start () {

        tenController.SetTenBar(views.TenBar,100.0f/questionManager.GetQuestionCount());
        timeController.SetTimeBar(views.TimeBar, questionManager.GetQuestionCount() * 15);
        timeController.OnTimeOver+=() => {
            EndGame();
        };
        NextQuestion();
        enemyBuilder.OnQuestionResult += (clearFlag) =>
        {
            if (clearFlag == true)
                tenController.AddScore();
            NextQuestion();
        };
	}

    void EndGame()
    {
        SceneManager.LoadScene("score1");
        rankManagement.SetScore(views.TenBar.GetVal());
    }

    // Update is called once per frame
    void Update () {
		
	}
}
