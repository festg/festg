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
    private EnemyBuilder enemyBuilder;

    [SerializeField]
    private Views views;


    void NextQuestion()
    {
        var question = questionManager.Next();
        if (question == null)
        {
            SceneManager.LoadScene("score1");
        }
        else
        {
            var trueChoiceName=views.QuestionPresenter.SetQuestion(question);
            enemyBuilder.CreateEnemies(trueChoiceName);
        }
    }

    // Use this for initialization
    void Start () {
        
        timeController.SetTimeBar(views.TimeBar,1000);
        timeController.OnTimeOver+=() => {
            SceneManager.LoadScene("score1");
        };
        NextQuestion();
        enemyBuilder.OnQuestionResult += (clearFlag) =>
        {
            NextQuestion();
        };
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
