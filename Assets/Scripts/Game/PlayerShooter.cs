using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour {

    private BulletPool bulletPool;

    private int count = 0;

    [SerializeField]
    private Bullet bullet;

	// Use this for initialization
	void Start () {
        bulletPool = new BulletPool();
        bulletPool.CreatePool(bullet, 20);
	}
	
	// Update is called once per frame
	void Update () {
        if(count>0)count++;
        if (count % 10 == 0) count = 0;
        if (count==0 && Input.GetKey(KeyCode.Space))
        {
            count = 1;
            var bullet = bulletPool.GetObject();
            bullet.GetRigidbody().velocity = new Vector2(1500.0f, 0);
            bullet.transform.position = transform.position;
        }
	}
}
