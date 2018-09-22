using UnityEngine;
using UnityEngine.UI;

public class QuestionPresenter : MonoBehaviour {

    [SerializeField]
    Text text;


    public string SetQuestion(QuestionsData.Question question)
    {
        var trueChoice = question.Choices[0];
        for (var i = question.Choices.Count - 1; i > 0; i--)
        {
            var r = (int)Mathf.Floor(Random.value * (i + 1));
            var tmp = question.Choices[i];
            question.Choices[i] = question.Choices[r];
            question.Choices[r] = tmp;
        }
        text.text = question.Text+"\n";
        var choiceNames = new string[] { "A", "B", "C", "D" };
        string trueChoiceName="";

        for (var i = 0; i < question.Choices.Count; i++)
        {
            text.text += choiceNames[i] + ":" + question.Choices[i] + " , ";
            if (question.Choices[i] == trueChoice)
                trueChoiceName = choiceNames[i];
        }
        return trueChoiceName;
    }
}
