﻿using System.Collections;
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
       iterator= questions.GetEnumerator();
	}

    QuestionsData.Question Next()
    {
        if (iterator.MoveNext())
            return iterator.Current;
        return null;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}