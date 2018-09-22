using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBuilder : MonoBehaviour {

    [SerializeField]
    private Enemy baseEnemy;


    public void CreateEnemies()
    {
        foreach( var x in new string[] { "A", "B", "C", "D" })
        {
            var enemy = Instantiate(baseEnemy);
            enemy.transform.position = new Vector3(Random.Range(-100, 600), Random.Range(-500, 500));
            enemy.SetChoicesText(x);
        }

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
