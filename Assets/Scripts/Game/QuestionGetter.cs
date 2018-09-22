using UnityEngine;
using System.IO;

public class QuestionGetter {
    public static  QuestionsData Deserialize(string yamlName)
    {
        StreamReader sr = new StreamReader(yamlName);
        string text = sr.ReadToEnd();
        var data=JsonUtility.FromJson<QuestionsData>(text);
        return data;
    }
}
