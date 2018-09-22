using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyBuilder : MonoBehaviour {

    [SerializeField]
    Enemy baseEnemy;
    int count = 0;

    public event Action<bool> OnQuestionResult;
    List<Enemy> enemies = new List<Enemy>(4);

    public void CreateEnemies(string trueChoice)
    {
        var choices=new string[] { "A", "B", "C", "D" };

        count = 4;
        for (var i= 0; i<choices.Length;i++ )
        {
            var enemy = Instantiate(baseEnemy);
            enemies.Add(enemy);
            var ii = i;
            enemy.OnDead += () =>
            {
                count--;
                enemies[ii] = null;
                if (trueChoice == choices[ii])
                {
                    foreach (var x in enemies.FindAll(x => x != null))
                        Destroy(x.gameObject);
                    enemies.Clear();
                    OnQuestionResult(false);
                }
                if (count <= 1)
                {
                    foreach (var x in enemies.FindAll(x => x != null))
                        Destroy(x.gameObject);
                    enemies.Clear();
                    OnQuestionResult(true);
                }
            };
            enemy.transform.position = new Vector3(UnityEngine.Random.Range(-100, 600), UnityEngine.Random.Range(-500, 500));
            enemy.SetChoicesText(choices[i]);
        }

    }
}
