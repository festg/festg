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


	// Use this for initialization
	void Start () {
        var question =questionManager.Next();
        if (question == null)
        {
            SceneManager.LoadScene("score1");
        }
        else
        {
            views.QuestionPresenter.SetQuestion(question);
        }

        timeController.SetTimeBar(views.TimeBar,1000);
        timeController.OnTimeOver+=() => {
            SceneManager.LoadScene("score1");
        };
        enemyBuilder.CreateEnemies();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
