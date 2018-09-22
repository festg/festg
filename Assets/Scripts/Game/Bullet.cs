using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    [SerializeField]
    private Rigidbody2D rigidBody;

    public Rigidbody2D GetRigidbody() { return rigidBody; }

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if(
            transform.position.x != Mathf.Clamp(transform.position.x, -700, 700) ||
            transform.position.y != Mathf.Clamp(transform.position.y, -600, 600)
           )
        {
            gameObject.SetActive(false);
        }
    }
}
