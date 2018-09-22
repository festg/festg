using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    //速度
    public float speed = 5;

    //移動制限
    private Vector2 player_pos;

        void Clamp()
        {
            //プレイヤーの位置を取得
            player_pos = transform.position;       
            
            //x位置が常に範囲内か監視
            player_pos.x = Mathf.Clamp(player_pos.x, -590, 590);
            //y位置が常に範囲内か監視
            player_pos.y = Mathf.Clamp(player_pos.y, -475, 475);
            //範囲内であれば常にその位置にそのまま入る
            transform.position = new Vector2(player_pos.x, player_pos.y);

        }


    //Use this for initialization
    private void Start()
    {

    }

    //Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(0.0f, 8f, 0.0f);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, -8f, 0.0f);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-8f, 0.0f, 0.0f);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(8f, 0.0f, 0.0f);

        }

        Clamp();

    }

}