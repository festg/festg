using UnityEngine;
using UnityEngine.UI;
using System;


public class Enemy : MonoBehaviour {

    [SerializeField]
    Text choicesText;

    uint hp = 10;

    BaseMover mover;

    public event Action OnDead;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerBullet")
        {
            hp--;
            if (hp <= 0)
            {
                OnDead();
                OnDead = null;
                Destroy(gameObject);
            }
        }
    }

    public void SetChoicesText(string text)
    {
        choicesText.text = text;
    }

    // Use this for initialization
    void Start () {
        mover = new YMover(this);
	}
	
	// Update is called once per frame
	void Update () {
		mover.Move();
	}
}
