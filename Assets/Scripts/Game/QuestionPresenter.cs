using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionPresenter : MonoBehaviour {

    [SerializeField]
    Text text;


    public void SetQuestion(QuestionsData.Question question)
    {
      text.text =  question.Text;
    }
}
