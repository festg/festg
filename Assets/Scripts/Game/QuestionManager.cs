using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour {

    private List<QuestionsData.Question> questions;
    private IEnumerator<QuestionsData.Question> iterator;

    //総問題数取得
    public int GetQuestionCount()
    {
       return questions.Count;
    }

	// Use this for initialization
	void Start () {
       questions= QuestionGetter.Deserialize("Assets/Question/question.json").Questions;
        for (var i = questions.Count - 1; i > 0; i--)
        {
            var r = (int)Mathf.Floor(Random.value * (i + 1));
            var tmp = questions[i];
            questions[i] = questions[r];
            questions[r] = tmp;
        }
        iterator = questions.GetEnumerator();
	}

    public QuestionsData.Question Next()
    {
        if (iterator.MoveNext())
            return iterator.Current;
        return null;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
