using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestionsData
{
    [SerializeField]
    public List<Question> Questions;

    [System.Serializable]
    public class Question
    {
        public string Text;
        public List<string> Choices;
    }

}
