using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    //速度
    public float speed = 5;

    //Use this for initialization
    private void Start()
    {

    }

    //Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(0.0f, 3f, 0.0f);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, -3f, 0.0f);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-3f, 0.0f, 0.0f);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(3f, 0.0f, 0.0f);

        }
    }

}